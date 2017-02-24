using System;

namespace TicTacToeApp
{
    class SpielLogik
    {
        private bool TestRows(String[,] coords)
        {
            if (coords[0, 0].Equals(coords[0, 1]) && coords[0, 1].Equals(coords[0, 2]))
            {
                return true;
            }else
            if (coords[1, 0].Equals(coords[1, 1]) && coords[1, 1].Equals(coords[1, 2]))
            {
                return true;
            }else
            if (coords[2, 0].Equals(coords[2, 1]) && coords[2, 1].Equals(coords[2, 2]))
            {
                return true;
            }else
            if (coords[0, 0].Equals(coords[1,0 ]) && coords[1, 0].Equals(coords[2, 0]))
            {
                return true;
            }else
            if (coords[0, 1].Equals(coords[1, 1]) && coords[1, 1].Equals(coords[2, 1]))
            {
                return true;
            }else
            if (coords[0, 2].Equals(coords[1, 2]) && coords[1, 2].Equals(coords[2, 2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool StraightWin(String[,] field)
        {
            if (field[0, 0].Equals(field[1, 1]) && field[1, 1].Equals(field[2, 2]))
            {
                return true;
            }
            else if (field[0, 2].Equals(field[1, 1]) && field[1, 1].Equals(field[2, 0]))
            {
                return true;
            }
            else
                return false;
        }

        public bool isGameWon(String[,] coords)
        {
            if (TestRows(coords) || StraightWin(coords))
            {
                return true;
            }
            return false;
        }

//        public bool IsFieldFull(String[,] coords)
//        {
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    if (coords[i, j] == "X" && coords[i, j] == "O")
//                    {
//                        return true;
//                    }
//                }
//            }
//            return false;
//        }
//    }
    }
}