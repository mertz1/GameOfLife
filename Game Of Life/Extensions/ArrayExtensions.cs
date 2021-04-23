using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_Of_Life.Extensions
{
    public static class ArrayExtensions
    {
        public static int GetColumnCount<T>(this T[][] array)
        {
            var temp = array.GetLength(0);
            return array.GetLength(0);
        }

        public static int GetRowCount<T>(this T[][] array)
        {
            if (array == null)
                throw new IndexOutOfRangeException("There are no rows for this object!");

            return array[0].Length;
        }
        
        public static T[][] Initialize<T>(this T[][] array, int row, int column)
        {
            array = new T[row][];

            for (int i = 0; i < column; i++)
            {
                array[i] = new T[column];
            }

            return array;
        }
    }
}
