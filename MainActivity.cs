using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText name, birthday, birthplace;
        Intent i;
        Button btn;
        string n, bd, bp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            name = FindViewById<EditText>(Resource.Id.editText1);
            birthday = FindViewById<EditText>(Resource.Id.editText2);
            birthplace = FindViewById<EditText>(Resource.Id.editText3);
            btn = FindViewById<Button>(Resource.Id.button1);

            btn.Click+= Next;
        }

        public void Next(object sender, EventArgs e)
        {
            i = new Intent(this, typeof(educbg));
            i.PutExtra("name",name.Text.ToString());
            i.PutExtra("birthday", birthday.Text.ToString());
            i.PutExtra("birthplace", birthplace.Text.ToString());
            StartActivity(i);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}