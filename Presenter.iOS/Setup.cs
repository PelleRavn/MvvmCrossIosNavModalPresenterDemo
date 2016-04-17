using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform.Platform;
using Presenter.Core;
using UIKit;
using MvvmCross.iOS.Views.Presenters;

namespace Presenter.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup (MvxApplicationDelegate applicationDelegate, UIWindow window) : base (applicationDelegate, window)
		{


		}

		protected override IMvxApplication CreateApp ()
		{
			return new App ();
		}

		protected override IMvxTrace CreateDebugTrace ()
		{
			return new DebugTrace ();
		}

		protected override MvvmCross.iOS.Views.Presenters.IMvxIosViewPresenter CreatePresenter ()
		{
			return new MvxModalNavSupportIosViewPresenter (ApplicationDelegate, Window);
		}
	}
}
