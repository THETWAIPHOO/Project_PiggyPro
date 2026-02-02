using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace Project_PiggyPro.Services
{
    /// <summary>
    /// Real email sender implementation using SMTP
    /// </summary>
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(IConfiguration configuration, ILogger<EmailSender> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                // Get SMTP settings from configuration
                var smtpServer = _configuration["EmailSettings:SmtpServer"];
                var smtpPort = int.Parse(_configuration["EmailSettings:SmtpPort"] ?? "587");
                var senderEmail = _configuration["EmailSettings:SenderEmail"];
                var senderName = _configuration["EmailSettings:SenderName"];
                var username = _configuration["EmailSettings:Username"];
                var password = _configuration["EmailSettings:Password"];

                // Validate configuration
                if (string.IsNullOrEmpty(smtpServer) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    _logger.LogWarning("Email settings not configured. Email not sent.");
                    _logger.LogInformation($"Would have sent email to: {email}");
                    _logger.LogInformation($"Subject: {subject}");
                    return;
                }

                // Create mail message
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(senderEmail ?? username, senderName ?? "PiggyPro"),
                    Subject = subject,
                    Body = htmlMessage,
                    IsBodyHtml = true
                };

                mailMessage.To.Add(email);

                // Create SMTP client
                using var smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(username, password),
                    EnableSsl = true,
                    Timeout = 10000
                };

                // Send email
                await smtpClient.SendMailAsync(mailMessage);

                _logger.LogInformation($"✓ Email sent successfully to {email}");
            }
            catch (SmtpException smtpEx)
            {
                _logger.LogError(smtpEx, $"SMTP Error sending email to {email}: {smtpEx.Message}");
                throw; // Re-throw so registration knows it failed
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error sending email to {email}: {ex.Message}");
                throw;
            }
        }
    }

    /// <summary>
    /// Extension method for Identity email sender
    /// </summary>
    public static class IdentityEmailSenderExtensions
    {
        public static async Task SendConfirmationLinkAsync(
            this IEmailSender emailSender,
            Project_PiggyPro.Data.Project_PiggyProUser user,
            string email,
            string confirmationLink)
        {
            var subject = "Confirm your email - PiggyPro";
            var htmlMessage = $@"
                <html>
                <body style='font-family: Arial, sans-serif; color: #333; max-width: 600px; margin: 0 auto;'>
                    <div style='background: linear-gradient(135deg, #e91e63 0%, #f06292 100%); padding: 30px; text-align: center; border-radius: 10px 10px 0 0;'>
                        <h1 style='color: white; margin: 0; font-size: 28px;'>🐷 PiggyPro</h1>
                    </div>
                    
                    <div style='padding: 30px; background: white; border-radius: 0 0 10px 10px; box-shadow: 0 4px 6px rgba(0,0,0,0.1);'>
                        <h2 style='color: #e91e63; margin-top: 0;'>Welcome to PiggyPro!</h2>
                        
                        <p>Hi <strong>{user.FirstName}</strong>,</p>
                        
                        <p>Thank you for registering with PiggyPro - Your Personal Budget Assistant!</p>
                        
                        <p>Please confirm your email address by clicking the button below:</p>
                        
                        <div style='text-align: center; margin: 30px 0;'>
                            <a href='{confirmationLink}' 
                               style='display: inline-block; 
                                      padding: 15px 40px; 
                                      background: #e91e63; 
                                      color: white; 
                                      text-decoration: none; 
                                      border-radius: 8px; 
                                      font-weight: bold;
                                      font-size: 16px;'>
                                ✓ Confirm Email Address
                            </a>
                        </div>
                        
                        <p style='color: #666; font-size: 14px;'>
                            If the button doesn't work, copy and paste this link into your browser:<br/>
                            <a href='{confirmationLink}' style='color: #e91e63; word-break: break-all;'>{confirmationLink}</a>
                        </p>
                        
                        <div style='margin-top: 30px; padding: 20px; background: #f9f9f9; border-radius: 8px;'>
                            <h3 style='margin-top: 0; color: #333;'>🎯 What's Next?</h3>
                            <ul style='color: #666; line-height: 1.8;'>
                                <li>Set up your monthly budget using the 50/30/20 rule</li>
                                <li>Add your first income and expense transactions</li>
                                <li>Create savings goals and track your progress</li>
                                <li>View your financial dashboard and insights</li>
                            </ul>
                        </div>
                        
                        <p style='color: #999; font-size: 12px; margin-top: 30px; border-top: 1px solid #e0e0e0; padding-top: 20px;'>
                            This email was sent to {email}. If you didn't create an account with PiggyPro, you can safely ignore this email.
                        </p>
                    </div>
                </body>
                </html>";

            await emailSender.SendEmailAsync(email, subject, htmlMessage);
        }
    }

    /// <summary>
    /// Adapter to make IEmailSender work with IEmailSender<TUser>
    /// </summary>
    public class IdentityEmailSenderAdapter : IEmailSender<Project_PiggyPro.Data.Project_PiggyProUser>
    {
        private readonly IEmailSender _emailSender;

        public IdentityEmailSenderAdapter(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public Task SendConfirmationLinkAsync(Project_PiggyPro.Data.Project_PiggyProUser user, string email, string confirmationLink)
        {
            return _emailSender.SendConfirmationLinkAsync(user, email, confirmationLink);
        }

        public Task SendPasswordResetLinkAsync(Project_PiggyPro.Data.Project_PiggyProUser user, string email, string resetLink)
        {
            var subject = "Reset your password - PiggyPro";
            var htmlMessage = $@"
                <html>
                <body style='font-family: Arial, sans-serif; color: #333; max-width: 600px; margin: 0 auto;'>
                    <div style='background: linear-gradient(135deg, #e91e63 0%, #f06292 100%); padding: 30px; text-align: center; border-radius: 10px 10px 0 0;'>
                        <h1 style='color: white; margin: 0; font-size: 28px;'>🐷 PiggyPro</h1>
                    </div>
                    
                    <div style='padding: 30px; background: white; border-radius: 0 0 10px 10px; box-shadow: 0 4px 6px rgba(0,0,0,0.1);'>
                        <h2 style='color: #e91e63; margin-top: 0;'>Reset Your Password</h2>
                        
                        <p>Hi <strong>{user.FirstName}</strong>,</p>
                        
                        <p>We received a request to reset your password for your PiggyPro account.</p>
                        
                        <p>Click the button below to reset your password:</p>
                        
                        <div style='text-align: center; margin: 30px 0;'>
                            <a href='{resetLink}' 
                               style='display: inline-block; 
                                      padding: 15px 40px; 
                                      background: #e91e63; 
                                      color: white; 
                                      text-decoration: none; 
                                      border-radius: 8px; 
                                      font-weight: bold;
                                      font-size: 16px;'>
                                🔒 Reset Password
                            </a>
                        </div>
                        
                        <p style='color: #666; font-size: 14px;'>
                            If the button doesn't work, copy and paste this link into your browser:<br/>
                            <a href='{resetLink}' style='color: #e91e63; word-break: break-all;'>{resetLink}</a>
                        </p>
                        
                        <p style='color: #999; font-size: 12px; margin-top: 30px; border-top: 1px solid #e0e0e0; padding-top: 20px;'>
                            If you didn't request a password reset, you can safely ignore this email. Your password will not be changed.
                        </p>
                    </div>
                </body>
                </html>";

            return _emailSender.SendEmailAsync(email, subject, htmlMessage);
        }

        public Task SendPasswordResetCodeAsync(Project_PiggyPro.Data.Project_PiggyProUser user, string email, string resetCode)
        {
            var subject = "Your password reset code - PiggyPro";
            var htmlMessage = $@"
                <html>
                <body style='font-family: Arial, sans-serif; color: #333; max-width: 600px; margin: 0 auto;'>
                    <div style='background: linear-gradient(135deg, #e91e63 0%, #f06292 100%); padding: 30px; text-align: center; border-radius: 10px 10px 0 0;'>
                        <h1 style='color: white; margin: 0; font-size: 28px;'>🐷 PiggyPro</h1>
                    </div>
                    
                    <div style='padding: 30px; background: white; border-radius: 0 0 10px 10px; box-shadow: 0 4px 6px rgba(0,0,0,0.1);'>
                        <h2 style='color: #e91e63; margin-top: 0;'>Password Reset Code</h2>
                        
                        <p>Hi <strong>{user.FirstName}</strong>,</p>
                        
                        <p>Your password reset code is:</p>
                        
                        <div style='text-align: center; margin: 30px 0; padding: 20px; background: #f9f9f9; border-radius: 8px;'>
                            <p style='font-size: 32px; font-weight: bold; color: #e91e63; margin: 0; letter-spacing: 4px;'>
                                {resetCode}
                            </p>
                        </div>
                        
                        <p>Enter this code on the password reset page to continue.</p>
                        
                        <p style='color: #999; font-size: 12px; margin-top: 30px; border-top: 1px solid #e0e0e0; padding-top: 20px;'>
                            If you didn't request a password reset, you can safely ignore this email.
                        </p>
                    </div>
                </body>
                </html>";

            return _emailSender.SendEmailAsync(email, subject, htmlMessage);
        }
    }
}
