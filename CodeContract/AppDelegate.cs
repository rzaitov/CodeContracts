using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CodeContract
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		private UIWindow window;
		private MainController _mainController;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow(UIScreen.MainScreen.Bounds);
			
			// If you have defined a root view controller, set it here:
			// window.RootViewController = myViewController;

			_mainController = new MainController();
			window.RootViewController = _mainController;

			window.MakeKeyAndVisible();

			return true;
		}
	}
}

