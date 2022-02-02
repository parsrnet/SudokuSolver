using System;

using static System.Console;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =
                "123456789" +
                "123456789" +
                "123456789" +
                //---------//
                "123456789" +
                "123456789" +
                "123456789" +
                //---------//
                "123456789" +
                "123456789" +
                "123456789";

            Board board = new Board(input);

            for (int i = 0; i < 9; i++)
            {
                WriteLine("ROW {0}: {1}", i, board.CheckRow(i));
                WriteLine("COL {0}: {1}", i, board.CheckCol(i));
            }

            for (int i = 0; i < 3; i++)
                for (int ii = 0; ii < 3; ii++)
                    WriteLine("BOX {0}, {1}: {2}", i, ii, board.CheckBox(i, ii));
        }
    }
}
