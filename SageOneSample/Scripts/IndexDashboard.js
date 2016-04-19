$(document).ready(function () {
    $('#btnSubmitPuzzle').click(function () { Handle_btnSubmitPuzzle_Click(); });
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

function Handle_btnSubmitPuzzle_Click() {
    var pageSudokuPuzzle = $('#sudokustring').val();
    ShowSudokuPuzzleNoAjax(pageSudokuPuzzle);
    //ShowSudokuPuzzle(pageSudokuPuzzle);
}

function ShowSudokuPuzzleNoAjax(data) {
    document.location.href = "/Sudoku/Sudoku?puzzleInputs=" + data;
}

function ShowSudokuPuzzle(data) {
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