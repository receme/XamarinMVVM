using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
namespace MVVMTest
{
	public class App : MvxApplication
	{
		public App ()
		{
		}

		public override void Initialize ()
		{
			base.Initialize ();

			CreatableTypes ().EndingWith ("Repository").AsInterfaces ().RegisterAsLazySingleton ();
			CreatableTypes ().EndingWith ("Service").AsInterfaces ().RegisterAsLazySingleton ();

			RegisterAppStart (new AppStart ());
		}
	}
}
