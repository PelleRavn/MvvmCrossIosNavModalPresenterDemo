using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace Presenter.Core.ViewModels
{
	public class SecondViewModel : FirstViewModel 
	{

	}
	
	public class FirstViewModel : MvxViewModel
	{
		private string _hello = "Hello MvvmCross";

		public string Hello { 
			get { return _hello; }
			set {
				_hello = value;
				RaisePropertyChanged (() => Hello);
			}
		}

		private MvxCommand _modalCommand;

		public ICommand ModalCommand {
			get {
				_modalCommand = _modalCommand ?? new MvxCommand (DoModalCommand);
				return _modalCommand;
			}
		}

		private void DoModalCommand ()
		{
			ShowViewModel<SecondViewModel> ();
		}

		private MvxCommand _pushCommand;

		public ICommand PushCommand {
			get {
				_pushCommand = _pushCommand ?? new MvxCommand (DoPushCommand);
				return _pushCommand;
			}
		}

		private void DoPushCommand ()
		{
			ShowViewModel<FirstViewModel> ();
		}

		private MvxCommand _closeCommand;

		public ICommand CloseCommand {
			get {
				_closeCommand = _closeCommand ?? new MvxCommand (DoCloseCommand);
				return _closeCommand;
			}
		}

		private void DoCloseCommand ()
		{
			Close (this);
		}
	}
}

