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
    [Activity(Label = "educbg")]
    public class educbg : Activity
    {
        EditText elem, hs;
        Button back, next;
        Intent i;
        string n, bd, bp;
        string name,birthday,birthplace;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.educbg);
            elem = FindViewById<EditText>(Resource.Id.editText1);
            hs = FindViewById<EditText>(Resource.Id.editText2);
            back = FindViewById<Button>(Resource.Id.button1);
            next = FindViewById<Button>(Resource.Id.button2);
            n = Intent.GetStringExtra("name");
            bd = Intent.GetStringExtra("birthday");
            bp = Intent.GetStringExtra("birthplace");
            // Create your application here

            back.Click += Back;
            next.Click += Next;

        }

        public void Next(object sender, EventArgs e)
        {
            i = new Intent(this, typeof(summary));
            i.PutExtra("elem", elem.Text.ToString());
            i.PutExtra("hs", hs.Text.ToString());
            i.PutExtra("n",n.ToString());
            i.PutExtra("bp", bp.ToString());
            i.PutExtra("bd", bd.ToString());
            StartActivity(i);
        }

        public void Back(object sender, EventArgs e)
        {
            i = new Intent(this, typeof(MainActivity));
        } 

    }
}