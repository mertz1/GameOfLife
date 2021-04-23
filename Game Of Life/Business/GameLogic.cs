using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game_Of_Life.Extensions;
using Game_Of_Life.Metadata;

namespace Game_Of_Life.Business
{
    public class GameLogic
    {
        public int[][] Play(int[][] grid)
        {
            int rows = grid.GetColumnCount();
            int columns = grid.GetRowCount();

            if (grid == null || rows < 1 || columns < 1)
                throw new ArgumentException("Invalid grid to play!");

            int[][] newGrid = new int[rows][].Initialize(rows, columns);

            for(var r = 0; r < rows; r++)
            {
                for(var c = 0; c < columns; c++)
                {
                    newGrid[r][c] = SetValue(grid[r][c], CheckSpace(grid, r, c));
                }
            }

            return newGrid;
        }

        public int CheckSpace(int[][] grid, int row, int column)
        {
            int count = 0;

            for(int i = 0; i < 3; i++) // incrementally check rows
            {
                if ((row - 1 + i >= 0) && ((row - 1 + i) < grid.GetRowCount())) // make sure on grid
                {
                    for(int j = 0; j < 3; j++) // incrementally check columns
                    {
                        if (((column - 1 + j) >= 0) // make sure on grid
                            && ((column - 1 + j) < grid.GetColumnCount())
                            && (i != 1 || j != 1)) // don't count this current space
                        {
                            count += grid[row-1+i][column-1+j];
                        }
                    }
                }

            }

            return count;
        }

        public int SetValue(int currentValue, int neighbors)
        {
            if ((currentValue == GameMetadata.States.Alive && (neighbors == 2 || neighbors == 3))
                || currentValue == GameMetadata.States.Dead && (neighbors == 3))
                return 1;

            return 0;
        }
    }
}
