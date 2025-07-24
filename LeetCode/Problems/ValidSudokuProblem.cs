using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    //ValidSudokuProblem validSudokuProblem = new ValidSudokuProblem();

    //Console.WriteLine(validSudokuProblem.IsValidSudoku(validSudokuProblem.board));
    internal class ValidSudokuProblem
    {
        public char[][] board = [
            new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '6', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        ];

        public char[][] board1 = [
            new char[] { '.', '.', '.', '.', '.', '.', '5', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '9', '3', '.', '.', '2', '.', '4', '.', '.' },
            new char[] { '.', '.', '7', '.', '.', '.', '3', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '3', '4', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '3', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '5', '2', '.', '.' }
        ];

        private char[][] checkRow = [
            new char[9],
            new char[9],
            new char[9],
            new char[9],
            new char[9],
            new char[9],
            new char[9],
            new char[9],
            new char[9]
        ];
        private List<List<char>> checkGrid = [
            new List<char> {},
            new List<char> {},
            new List<char> {},
            new List<char> {},
            new List<char> {},
            new List<char> {},
            new List<char> {},
            new List<char> {},
            new List<char> { }
        ];
        public bool IsValidSudoku(char[][] board)
        {
            List<char> seen = new();
            for (int col = 0; col < board[0].Length; col++)
            {
                for (int row = 0; row < board.Length; row++)
                {
                    var currentValue = board[row][col];
                    var currentGrid = (row / 3) * 3 + (col / 3);

                    if (currentValue == '.')
                    {
                        continue;
                    }
                    // check to see if column contains the same value
                    if (seen.Contains(currentValue))
                    {
                        Console.WriteLine($"Column Contains Same Value.");
                        return false;
                    }

                    // check to see if row contains the same value
                    if (checkRow[row].Contains(currentValue))
                    {
                        Console.WriteLine($"Row Contains Same Value.");
                        return false;
                    }
                    checkRow[row][col] = currentValue;

                    if (checkGrid[currentGrid].Contains(currentValue))
                    {
                        Console.WriteLine($"Grid Contains Same Value.");
                        return false;
                    }
                    checkGrid[currentGrid].Add(currentValue);

                    Console.WriteLine($"{currentValue}");
                    seen.Add(currentValue);
                }
                seen.Clear();
            }
            

            return true;
        }

        public void PrintPosition()
        {
            //Console.WriteLine(board[2][0]);
        }
    }
}
