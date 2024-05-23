using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1
{
    [Activity(Label = "summary")]
    public class summary : Activity
    {
        Intent i;
        Button Homebtn;
        TextView n, bd, bp, elem, hs;
        string name, birthday, birthplace, elementary, highschool;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.summary);
            n = FindViewById<TextView>(Resource.Id.textView2);
            bd = FindViewById<TextView>(Resource.Id.textView4);
            bp = FindViewById<TextView>(Resource.Id.textView6);
            elem = FindViewById<TextView>(Resource.Id.textView8);
            hs = FindViewById<TextView>(Resource.Id.textView10);
            Homebtn = FindViewById<Button>(Resource.Id.button1);
            name = Intent.GetStringExtra("n");
            birthday = Intent.GetStringExtra("bd");
            birthplace = Intent.GetStringExtra("bp");
            elementary = Intent.GetStringExtra("elem");
            highschool = Intent.GetStringExtra("hs");

            // Create your application here

            n.Text = name;
            bd.Text = birthday;
            bp.Text = birthplace;
            elem.Text = elementary;
            hs.Text = highschool;

            Homebtn.Click += Home;
        }
        
        public void Home(object sender,  EventArgs e)
        {
            i = new Intent(this,typeof(MainActivity));
        }

    }
}