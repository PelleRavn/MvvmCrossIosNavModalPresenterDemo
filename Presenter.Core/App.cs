using MvvmCross.Platform.IoC;
using Presenter.Core.ViewModels;
using Presenter.Core.Settings;
using MvvmCross.Platform;

namespace Presenter.Core
{
	public class App : MvvmCross.Core.ViewModels.MvxApplication
	{
		public override void Initialize ()
		{
			CreatableTypes ()
                .EndingWith ("Service")
                .AsInterfaces ()
                .RegisterAsLazySingleton ();

			#if DEBUG
			Mvx.RegisterType<IAppSettings, AppSettingsDebug> ();
			#else
			Mvx.RegisterType<IAppSettings, AppSettingsRelease> ();
			#endif

			Mvx.RegisterSingleton<ISessionHandler> (() => Mvx.IocConstruct<SessionHandler> ());

			RegisterAppStart<FirstViewModel> ();
		}
	}
}
