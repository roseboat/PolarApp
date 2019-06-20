using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Polar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            //Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);

            ImageView polar = FindViewById<ImageView>(Resource.Id.polar_id);
            Button button = FindViewById<Button>(Resource.Id.button_id);


            polar.Click += delegate
            {
                button.Visibility = ViewStates.Invisible;
                polar.Visibility = ViewStates.Invisible;
                var transaction = this.SupportFragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.fragment_container, new HomeFragment());
                transaction.AddToBackStack(null);
                transaction.Commit();
            };

            button.Click += delegate
            {
                button.Visibility = ViewStates.Invisible;
                polar.Visibility = ViewStates.Invisible;
                var transaction = this.SupportFragmentManager.BeginTransaction();
                transaction.Replace(Resource.Id.fragment_container, new HomeFragment());
                transaction.AddToBackStack(null);
                transaction.Commit();
            };
        }





        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

