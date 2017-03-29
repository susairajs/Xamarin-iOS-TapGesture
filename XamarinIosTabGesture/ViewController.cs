using System;

using UIKit;

namespace XamarinIosTabGesture
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			imgGesture.UserInteractionEnabled = true;

			UITapGestureRecognizer tapGesture = new UITapGestureRecognizer(Tap);

			tapGesture.NumberOfTapsRequired = 1;

			imgGesture.AddGestureRecognizer(tapGesture);
		}

		void Tap(UITapGestureRecognizer tap1)
		{
			
			lblDisplay.Text = "You Touched Me..";
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
