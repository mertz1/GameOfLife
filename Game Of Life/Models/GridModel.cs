using Game_Of_Life.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Of_Life.Models
{
    public class GridModel
    {
        public GridModel()
        {
            Grid = new int[Rows][].Initialize(Rows, Columns);
        }

        public GridModel(int _rows, int _columns)
        {
            Rows = _rows;
            Columns = _columns;
        }

        public int Rows { get; set; } = 25;
        public int Columns { get; set; } = 25;
        public int[][] Grid { get; set; }
    }
}
