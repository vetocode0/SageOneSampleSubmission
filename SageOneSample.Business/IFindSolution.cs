using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SageOneSample.Shared;

namespace SageOneSample.Business
{
    public interface IFindSolution
    {
        SudokuPuzzle GetPuzzle();
        SudokuPuzzle GetPuzzle(string incompletePuzzle);
    }
}
