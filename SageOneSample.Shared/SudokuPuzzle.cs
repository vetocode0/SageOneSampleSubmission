using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageOneSample.Shared
{
    public class SudokuPuzzle
    {
        public int id { get; set; }
        public string puzzle { get; set; }
        public List<int> PuzzlePiecesNumbers { get; set; }
        public List<string> PuzzlePiecesStrings { get; set; }
    }
}
