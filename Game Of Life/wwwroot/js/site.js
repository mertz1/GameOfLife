// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function changeGridColor(id) {
    var element = document.getElementById(id);

    // change value
    var value = element.getAttribute('value');
    element.setAttribute('value', value == 1 ? 0 : 1);

    // change class
    var className = element.className;
    element.className = className == "cell" ? "filled-cell" : "cell";
};

function getGridValues() {
    var htmlGrid = document.getElementById('game-of-life-grid');

    var columns = htmlGrid.getAttribute('columnCount');
    var rows = htmlGrid.getAttribute('rowCount');

    let grid = [];

    for (var i = 0; i < columns; i++) {
        grid[i] = [];
        for (var j = 0; j < rows; j++) {
            grid[i][j] = document.getElementById(`${i}-${j}`).getAttribute('value');
        }
    }

    return grid;
};

function printGridValues() {
    var url = "Home/Grid";
    var data = { grid: getGridValues() };

    Ajax.Post(url, data, function (res) {
        $('#GridPartial').html(res);
    })
};
