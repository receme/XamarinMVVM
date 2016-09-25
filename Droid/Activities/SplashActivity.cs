
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MVVMTest.Droid
{
	[Activity (Label = "SplashActivity", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
			   ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashActivity : MvxSplashScreenActivity
	{
		public SplashActivity () : base (Resource.Layout.activity_splash) { }
	}
}
