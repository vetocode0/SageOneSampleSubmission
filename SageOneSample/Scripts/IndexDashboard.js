$(document).ready(function () {
    $('#btnSubmitPuzzle').click(function () { RenderContent(); });
    $("#btnPostDBCall").click(function () { RenderContent(); });
    $("#btnPostAPICall").click(function () { RenderContent(); });
});

function RenderContent() {
    alert("Function Attached");
}

function PostToSage() {
    var testData = "SampleString"
    $.ajax({
        type: "POST",
        url: "/api/Values",
        data: car,
        datatype: "html",
        success: function (data) {
            $('#result').html(data);
        }
    });
}

function handle_btnSubmitPuzzle_click() {
    var pageSudokuPuzzle = $('#sudokustring').val();
    showSudokuPuzzleNoAjax(pageSudokuPuzzle);
    //showSudokuPuzzle(pageSudokuPuzzle);
}

function showSudokuPuzzleNoAjax(data) {
    document.location.href = "/Sudoku/Sudoku?puzzleInputs=" + data;
}

function showSudokuPuzzle(data) {
    $.ajax({
        type: "POST",
        url: '/Sudoku/Sudoku/',
        data: { puzzleInputs: data },
        async: true,
        cache: false,
        datatype: "json",
        traditional: true,
        success: function () {

        },
    });
}