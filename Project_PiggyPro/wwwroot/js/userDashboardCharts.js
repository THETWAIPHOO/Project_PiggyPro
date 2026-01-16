// Chart Helpers for UserDashboard (matching Reports.razor format)

window.chartHelpers = window.chartHelpers || {};

// Line Chart (for Spending Overview)
window.chartHelpers.createLineChart = function (canvasId, labels, data, label) {
    console.log(`Creating line chart on ${canvasId}`);

    const ctx = document.getElementById(canvasId);
    if (!ctx) {
        console.error(`Canvas ${canvasId} not found`);
        return;
    }

    // Destroy existing chart if it exists
    if (window[canvasId + '_instance']) {
        window[canvasId + '_instance'].destroy();
    }

    window[canvasId + '_instance'] = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: label || 'Daily Spending',
                data: data,
                borderColor: '#e91e63',
                backgroundColor: 'rgba(233, 30, 99, 0.1)',
                borderWidth: 2,
                tension: 0.4,
                fill: true,
                pointRadius: 4,
                pointHoverRadius: 6,
                pointBackgroundColor: '#e91e63',
                pointBorderColor: '#fff',
                pointBorderWidth: 2
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: {
                    display: false
                },
                tooltip: {
                    callbacks: {
                        label: function (context) {
                            return '$' + context.parsed.y.toFixed(2);
                        }
                    }
                }
            },
            scales: {
                y: {
                    beginAtZero: true,
                    ticks: {
                        callback: function (value) {
                            return '$' + value.toFixed(0);
                        }
                    },
                    grid: {
                        color: 'rgba(0, 0, 0, 0.05)'
                    }
                },
                x: {
                    grid: {
                        display: false
                    }
                }
            }
        }
    });

    console.log(`✓ Line chart created on ${canvasId}`);
};

// Pie Chart (for Top Categories)
window.chartHelpers.createPieChart = function (canvasId, labels, data, colors) {
    console.log(`Creating pie chart on ${canvasId}`);

    const ctx = document.getElementById(canvasId);
    if (!ctx) {
        console.error(`Canvas ${canvasId} not found`);
        return;
    }

    // Destroy existing chart if it exists
    if (window[canvasId + '_instance']) {
        window[canvasId + '_instance'].destroy();
    }

    // Default colors if not provided
    const defaultColors = [
        '#e91e63',
        '#2196f3',
        '#4caf50',
        '#ff9800',
        '#9c27b0',
        '#f44336',
        '#00bcd4',
        '#ffeb3b'
    ];

    window[canvasId + '_instance'] = new Chart(ctx, {
        type: 'pie',
        data: {
            labels: labels,
            datasets: [{
                data: data,
                backgroundColor: colors || defaultColors.slice(0, labels.length),
                borderColor: '#fff',
                borderWidth: 2
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: {
                    position: 'right',
                    labels: {
                        padding: 15,
                        font: {
                            size: 12
                        }
                    }
                },
                tooltip: {
                    callbacks: {
                        label: function (context) {
                            const label = context.label || '';
                            const value = context.parsed || 0;
                            const total = context.dataset.data.reduce((a, b) => a + b, 0);
                            const percentage = ((value / total) * 100).toFixed(1);
                            return label + ': $' + value.toFixed(2) + ' (' + percentage + '%)';
                        }
                    }
                }
            }
        }
    });

    console.log(`✓ Pie chart created on ${canvasId}`);
};

// Bar Chart (if needed for future use)
window.chartHelpers.createBarChart = function (canvasId, labels, datasets) {
    console.log(`Creating bar chart on ${canvasId}`);

    const ctx = document.getElementById(canvasId);
    if (!ctx) {
        console.error(`Canvas ${canvasId} not found`);
        return;
    }

    // Destroy existing chart if it exists
    if (window[canvasId + '_instance']) {
        window[canvasId + '_instance'].destroy();
    }

    window[canvasId + '_instance'] = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: datasets
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: {
                    display: true,
                    position: 'top'
                }
            },
            scales: {
                y: {
                    beginAtZero: true,
                    ticks: {
                        callback: function (value) {
                            return '$' + value.toFixed(0);
                        }
                    }
                }
            }
        }
    });

    console.log(`✓ Bar chart created on ${canvasId}`);
};

console.log('✓ Chart helpers loaded');