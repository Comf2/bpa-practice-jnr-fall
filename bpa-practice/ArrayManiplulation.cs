using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bpa_practice
{
    internal class ArrayManiplulation
    {
        // --- Creating Arrays and Manplulating them --- //

        //Initializing
        public int[] staticIntArray = new int[3] { 1, 3, 5 };
        public int[] dynamicIntarray = new int[] { 1, 3, 5, 7, 6, 7 };

        // - Multi-Dimensional - //
        public int[,] staticMultiDimIntArray = new int[3, 2] { { 1, 4 }, { 5, 8 }, { 9, 3 } };
        // Outer array can be as long as you'd like, inner one must stick to expected Length (First array length)
        public int[,] dynamicMultiDimIntarray = new int[,] { { 5, 7, 8 }, { 9, 3, 5 } };

        // - Jagged Arrays - //
        public int[][] intJaggedArray = new int[3][];
        public void accessArrays()
        {
            // -- multi-dim -- //
            //Creates a copy of data, the arrays first ele is still 5
            int firstVal = dynamicMultiDimIntarray[0, 0];
            firstVal = 999;
            Debug.WriteLine(dynamicMultiDimIntarray[0, 0]);

            // -- jagged -- //
            intJaggedArray[0] = new int[3] { 5, 7, 8 };

            // Convert Array to List
            int[] myArray = new int[5] { 1, 4, 7, 88, 9 };
            List<int> myList = new List<int>(myArray);
            string result = string.Join(", ", myList.ToArray());
            Debug.WriteLine(result);

        }

    }
}
