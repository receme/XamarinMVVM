
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace MVVMTest.Droid
{
	[MvxFragment (typeof (MainViewModel), Resource.Id.content_frame, true)]
	[Register ("mvvmtest.droid.JourneyDetailsFragment")]
	public class AddTodoFragment : MvxFragment<AddTodoViewModel>
	{

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{

			base.OnCreateView (inflater, container, savedInstanceState);

			return this.BindingInflate (Resource.Layout.fragment_addtodo, null);
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
			(this.Activity as MainActivity).SetTitle ("Add Todo");
		}
	}
}
