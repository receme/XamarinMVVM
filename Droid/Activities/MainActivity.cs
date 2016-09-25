using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V4.Widget;
using Com.Lilarcor.Cheeseknife;
using Android.Support.V7.Widget;

namespace MVVMTest.Droid
{
	[Activity (Label = "MVVMTest", Icon = "@mipmap/icon")]
	public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
	{
		[InjectView (Resource.Id.drawer_layout)]
		DrawerLayout drawerLayout;
		[InjectView (Resource.Id.toolbar)]
		Toolbar toolBar;

		private MvxActionBarDrawerToggle drawerToggle;
		private FragmentManager fragmentManager;

		public new MainViewModel mainViewModel {
			get {
				return (MainViewModel)ViewModel;
			}
			set {
				ViewModel = value;
			}
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Cheeseknife.Inject (this);

			SetSupportActionBar (toolBar);

			SupportActionBar.SetDisplayShowTitleEnabled (false);
			SupportActionBar.SetDisplayHomeAsUpEnabled (true);
			drawerToggle.DrawerIndicatorEnabled = true;
			drawerLayout.AddDrawerListener (drawerToggle);


		}


	}
}

