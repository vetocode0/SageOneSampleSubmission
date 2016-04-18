using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SageOneSample.Models;
using SageOneSample.Business;

namespace SageOneSample.Controllers
{
    public class SudokuController : Controller
    {
        private IFindSolution _solutionFinder; 
        public SudokuController(IFindSolution solutionFinder)
        {
            _solutionFinder = solutionFinder;
        }
        // GET: Sudoku
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sudoku(string puzzleInputs)
        {
            var solution = _solutionFinder.GetPuzzle();
            SudokuViewModel svm = new SudokuViewModel()
            {
                PuzzlePiecesJsonObject = solution.PuzzlePiecesNumbers,
                PuzzlePieces = solution.PuzzlePiecesStrings
            };
            return View(svm);
        }
        [HttpPost]
        public JsonResult SudokuSolver(string puzzlePieces)
        {
            var solution = _solutionFinder.GetPuzzle(puzzlePieces);
            SudokuViewModel svm = new SudokuViewModel()
            {
                PuzzlePiecesJsonObject = solution.PuzzlePiecesNumbers,
                PuzzlePieces = solution.PuzzlePiecesStrings
            };
            return Json(svm.PuzzlePieces, JsonRequestBehavior.AllowGet);
        }
        public ActionResult SolvedPuzzle(string puzzleInputs)
        {
            var solution = _solutionFinder.GetPuzzle(puzzleInputs);
            SudokuViewModel svm = new SudokuViewModel()
            {
                PuzzlePiecesJsonObject = solution.PuzzlePiecesNumbers,
                PuzzlePieces = solution.PuzzlePiecesStrings
            }; ;
            return View(svm);
            //SudokuSolver sSolver = new SudokuSolver(puzzleInputs);
            //return View(sSolver);
        }
    }
}
