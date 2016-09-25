using System;
using MvvmCross.Core.ViewModels;

namespace MVVMTest
{
	public class AppStart : MvxNavigatingObject, IMvxAppStart
	{
		public AppStart ()
		{
		}

		public void Start (object hint = null)
		{
			throw new NotImplementedException ();
		}
	}
}
