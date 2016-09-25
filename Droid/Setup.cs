using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using Android.Content;
namespace MVVMTest.Droid
{
	public class Setup : MvxAndroidSetup
	{
		public Setup (Context applicationContext) : base (applicationContext)
		{
		}

		protected override IMvxApplication CreateApp ()
		{
			return new App ();
		}

		protected override void InitializeIoC ()
		{
			base.InitializeIoC ();
		}

		protected override MvvmCross.Droid.Views.IMvxAndroidViewPresenter CreateViewPresenter ()
		{

		}
	}
}
