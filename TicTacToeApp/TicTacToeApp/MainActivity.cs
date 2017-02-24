using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace TicTacToeApp
{
    [Activity(Label = "TicTacToe", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Spieler _player = new Spieler();
        Spielfeld field = new Spielfeld();
        SpielLogik logic = new SpielLogik();
        Spielfluss flow = new Spielfluss();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bundle"></param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Button Button1 = FindViewById<Button>(Resource.Id.button1);
            Button Button2 = FindViewById<Button>(Resource.Id.button2);
            Button Button3 = FindViewById<Button>(Resource.Id.button3);
            Button Button4 = FindViewById<Button>(Resource.Id.button4);
            Button Button5 = FindViewById<Button>(Resource.Id.button5);
            Button Button6 = FindViewById<Button>(Resource.Id.button6);
            Button Button7 = FindViewById<Button>(Resource.Id.button7);
            Button Button8 = FindViewById<Button>(Resource.Id.button8);
            Button Button9 = FindViewById<Button>(Resource.Id.button9);
            Button Reset = FindViewById<Button>(Resource.Id.button10);

            InitialiseButtons();

            Button1.Click += Clickbutton;
            Button2.Click += Clickbutton;
            Button3.Click += Clickbutton;
            Button4.Click += Clickbutton;
            Button5.Click += Clickbutton;
            Button6.Click += Clickbutton;
            Button7.Click += Clickbutton;
            Button8.Click += Clickbutton;
            Button9.Click += Clickbutton;
            Reset.Click += Clickbutton;

            Button1.Clickable = true;
            Button2.Clickable = true;
            Button3.Clickable = true;
            Button4.Clickable = true;
            Button5.Clickable = true;
            Button6.Clickable = true;
            Button7.Clickable = true;
            Button8.Clickable = true;
            Button9.Clickable = true;
        }

        public void Clickbutton(object sender, EventArgs args)
        {
            Button button = (Button) sender;
            if (button.Id != Resource.Id.button10)
            {
                if (field.Running)
                {
                    
                    field.ChangeButtons(button);
                    if (logic.isGameWon(field.Coords))
                    {
                        Button reset = FindViewById<Button>(Resource.Id.button10);
                       
                        reset.Text = "Start";
                        ResetField();
                        field.ResetArray(field.Coords);

                    }
//                   else if (logic.IsFieldFull(field.Coords))
//                    {
//                        Button reset = FindViewById<Button>(Resource.Id.button10);
//
//                        reset.Text = "Start";
//                        ResetField();
//                    }
                }
            }
            else
            {
                if (button.Text == "Reset")
                {
                    field.Running = false;
                    button.Text = "Start";
                    ResetField();
                    field.ResetArray(field.Coords);

                }
                else
                 if (button.Text == "Start")
                {
                    field.Running = true;
                    button.Text = "Reset";
                }
            }
        }

        private void ResetField()
        {

            Button Button1 = FindViewById<Button>(Resource.Id.button1);
            Button Button2 = FindViewById<Button>(Resource.Id.button2);
            Button Button3 = FindViewById<Button>(Resource.Id.button3);
            Button Button4 = FindViewById<Button>(Resource.Id.button4);
            Button Button5 = FindViewById<Button>(Resource.Id.button5);
            Button Button6 = FindViewById<Button>(Resource.Id.button6);
            Button Button7 = FindViewById<Button>(Resource.Id.button7);
            Button Button8 = FindViewById<Button>(Resource.Id.button8);
            Button Button9 = FindViewById<Button>(Resource.Id.button9);


            Button1.Text = "";
            Button2.Text = "";
            Button3.Text = "";
            Button4.Text = "";
            Button5.Text = "";
            Button6.Text = "";
            Button7.Text = "";
            Button8.Text = "";
            Button9.Text = "";

            Button1.Clickable = true;
            Button2.Clickable = true;
            Button3.Clickable = true;
            Button4.Clickable = true;
            Button5.Clickable = true;
            Button6.Clickable = true;
            Button7.Clickable = true;
            Button8.Clickable = true;
            Button9.Clickable = true;
        }

        private void InitialiseButtons()
        {
            Button Button1 = FindViewById<Button>(Resource.Id.button1);
            Button Button2 = FindViewById<Button>(Resource.Id.button2);
            Button Button3 = FindViewById<Button>(Resource.Id.button3);
            Button Button4 = FindViewById<Button>(Resource.Id.button4);
            Button Button5 = FindViewById<Button>(Resource.Id.button5);
            Button Button6 = FindViewById<Button>(Resource.Id.button6);
            Button Button7 = FindViewById<Button>(Resource.Id.button7);
            Button Button8 = FindViewById<Button>(Resource.Id.button8);
            Button Button9 = FindViewById<Button>(Resource.Id.button9);


            Button1.ContentDescription = "0,0";
            Button2.ContentDescription = "0,1";
            Button3.ContentDescription = "0,2";

            Button4.ContentDescription = "1,0";
            Button5.ContentDescription = "1,1";
            Button6.ContentDescription = "1,2";

            Button7.ContentDescription = "2,0";
            Button8.ContentDescription = "2,1";
            Button9.ContentDescription = "2,2";
        }
    }
}

