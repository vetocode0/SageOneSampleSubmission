using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SageOneSample.Models
{
    public class SudokuViewModel
    {
        public List<string> ParsedInput = new List<string>();
        public string puzzleString { get; set; }
        public List<int> PuzzlePiecesJsonObject { get; set; }
        public List<string> PuzzlePieces { get; set; }
    }
}