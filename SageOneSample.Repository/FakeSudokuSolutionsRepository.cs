using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageOneSample.Repository
{
    public class FakeSudokuSolutionsRepository : ISudokuSolutionsRepository
    {
        public Puzzle GetSample()
        {
            return new Puzzle {
                id = 1,
                puzzle = ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,"
            };
        }

        public Puzzle GetSolutionById(string id)
        {
            throw new NotImplementedException();
        }

        public Puzzle GetSolutionByPuzzle(string partialPuzzle)
        {
            return new Puzzle { id = 1, puzzle = "" };
        }
    }
}
