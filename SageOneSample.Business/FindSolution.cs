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
            _repo.GetSample();
            
            throw new NotImplementedException();
        }

        public SudokuPuzzle GetPuzzle(string incompletePuzzle)
        {
            _repo.GetSolutionByPuzzle(incompletePuzzle);
            throw new NotImplementedException();
        }
    }
}
