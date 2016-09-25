using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MVVMTest
{
	public class MainViewModel : MvxViewModel
	{
		private readonly Lazy<AddTodoViewModel> _addTodoViewModel;

		public AddTodoViewModel AddTodoViewModel => _addTodoViewModel.Value;

		public MainViewModel ()
		{
			_addTodoViewModel = new Lazy<AddTodoViewModel> (Mvx.IocConstruct<AddTodoViewModel>);
		}

		public void ShowAddTodoScreen ()
		{
			ShowViewModel<AddTodoViewModel> ();
		}
	}
}
