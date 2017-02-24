using System;
using System.IO;
using Android.Widget;

namespace TicTacToeApp
{
    class Spielfeld
    {
        public String[ , ] Coords = new String[3, 3];
        private bool Order;
        public bool Running;

        public Spielfeld()
        {
            ResetArray(Coords);
        }

        private bool IsFree(Button button)
        {

            if (!button.Text.Equals("X") && !button.Text.Equals("O"))
            {
                return true;
            }
             return false;
        }

        public void ChangeButtons(Button button)
        {
               bool free = IsFree(button);

                if (free)
                {
                    String xs = button.ContentDescription;
                    String[] xa = xs.Split(',');
                    var x = Convert.ToInt16(xa[1]);
                    var y = Convert.ToInt16(xa[0]);
                    if(Order)
                    {
                        Coords[x, y] = "X";
                        button.Text = "X";
                        Order = false;
                    }
                    else if (Order == false)
                    {
                        Coords[x, y] = "O";
                        button.Text = "O";
                        Order = true;
                    }
                    button.Clickable = false;
                }
            }
        //        public void StartResetControl(Button button)
        //        {
        //            if (button.Text == "Reset")
        //            {
        //                Running = false;
        //                button.Text = "Start";
        //            }
        //            else
        //              if (button.Text == "Start")
        //            {
        //                Running = true;
        //                button.Text = "Reset";
        //            }
        //        }
        public void ResetArray(String[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Coords[i, j] = rnd.Next(0, 20000).ToString();
                }
            }
        }
    }

   }
