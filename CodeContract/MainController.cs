using System;
using MonoTouch.UIKit;

using System.Diagnostics.Contracts;

namespace CodeContract
{
	public class MainController : UIViewController
	{
		public MainController()
		{
		}

		public override void ViewDidLoad()
		{
			Contract.Requires(true);

			View.BackgroundColor = UIColor.White;

			base.ViewDidLoad();
		}
	}
}

