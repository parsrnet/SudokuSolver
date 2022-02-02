using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    class Board
    {
        public const int EMPTY_SPACE = 0;

        public int Rows
        {
            get => 9;
        }
        public int Columns
        {
            get => 9;
        }

        private int[,] _board;

        public Board()
        {
            _board = new int[Rows, Columns]; // ROW by COLUMN
            for (int y = 0; y < Rows; y++)
                for (int x = 0; x < Columns; x++) 
                    _board[y, x] = EMPTY_SPACE; // EMPTY
        }
        public Board(string input)
        {
            _board = new int[Rows, Columns];
            for (int i = 0; i < 81; i++)
                _board[i % 9, i / 9] = input.Length > i ? Convert.ToInt32(input[i]) : 0;
        }

        public bool CheckRow(int row)
        {
            List<int> check = new List<int>(9);
            for (int col = 0; col < 9; col++)
            {
                int curCheck = _board[row, col];
                if (!check.Contains(curCheck))
                    check.Add(curCheck);
                else
                    return false;
            }
            return true;
        }
        public bool CheckCol(int col)
        {
            List<int> check = new List<int>(9);
            for (int row = 0; row < 9; row++)
            {
                int curCheck = _board[row, col];
                if (!check.Contains(curCheck))
                    check.Add(curCheck);
                else
                    return false;
            }
            return true;
        }
        public bool CheckBox(int row, int col) // 0 <= ROW <= 2; 0 <= COL <= 2
        {
            

            return false;
        }
    }
}