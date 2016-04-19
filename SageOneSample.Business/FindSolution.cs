using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SageOneSample.Shared;
using SageOneSample.Repository;

namespace SageOneSample.Business
{
    public class FindSolution : IFindSolution
    {
        private ISudokuSolutionsRepository _repo;
        public FindSolution(ISudokuSolutionsRepository repo)
        {
            _repo = repo;
        }
        public SudokuPuzzle GetPuzzle()
        {
            var Results = _repo.GetSample();
            List<string> inputparsed = new List<string>();
            SudokuPuzzle ProcessedPuzzleResults = new SudokuPuzzle()
            {
                id = Results.id,
                puzzle = Results.puzzle,
            };
            char[] delim = { ',' };
            string[] inputs = ProcessedPuzzleResults.puzzle.Split(delim);
            foreach (string s in inputs)
            {
                if(s == "")
                {
                    inputparsed.Add("-");
                }
                else
                {
                    inputparsed.Add(s);
                }
                ProcessedPuzzleResults.PuzzlePiecesStrings = inputparsed;
                //ProcessedPuzzleResults.PuzzlePiecesNumbers.Add(Convert.ToInt32(s));
            }
            return ProcessedPuzzleResults;
        }

        public SudokuPuzzle GetPuzzle(string incompletePuzzle)
        {
            _repo.GetSolutionByPuzzle(incompletePuzzle);
            throw new NotImplementedException();
        }
    }
}
