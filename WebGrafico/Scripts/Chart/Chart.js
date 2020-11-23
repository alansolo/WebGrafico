$(function () {
    console.log("ready!");

    var ctx = document.getElementById("myChart");

    var mixedChart = new Chart(ctx, {
        type: 'bar',
        data: {
            datasets: [{
                label: 'Bar Dataset',
                data: [10, 20, 5, 40],
                borderColor: '#2196f3', // Add custom color border (Line)
                //backgroundColor: '#2196f3',
                type: 'line'
            }, {
                label: 'Line Dataset',
                data: [50, 50, 50, 50],

                // Changes this dataset to become a line
                type: 'line'
            }],
            labels: ['January', 'February', 'March', 'April']
        },
        options: {
            responsive: true, // Instruct chart js to respond nicely.
            maintainAspectRatio: false, // Add to prevent default behaviour of full-width/height 
        }
    });


    $("#btnCargar").click(function () {
        alert("Handler for .click() called.");

        var array = [30, 30, 30, 30];

        array.forEach(function (valor, indice, array) {
            console.log("En el índice " + indice + " hay este valor: " + valor);
        });

        var ctx = document.getElementById("myChart");

        var mixedChart = new Chart(ctx, {
            type: 'bar',
            data: {
                datasets: [{
                    label: 'Bar Dataset',
                    data: [40, 5, 50, 15],
                    borderColor: '#2196f3', // Add custom color border (Line)
                    //backgroundColor: '#2196f3',
                    type: 'line'
                }, {
                        label: 'Line Dataset',
                        data: array,

                    // Changes this dataset to become a line
                    type: 'line'
                }],
                labels: ['January', 'February', 'March', 'April']
            },
            options: {
                responsive: true, // Instruct chart js to respond nicely.
                maintainAspectRatio: false, // Add to prevent default behaviour of full-width/height 
            }
        });

    });
});

