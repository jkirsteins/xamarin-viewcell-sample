// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CellTest.iOS
{
	[Register ("MyTableViewCell")]
	partial class MyTableViewCell
	{
		[Outlet]
		UIKit.UIButton leftButton { get; set; }

		[Outlet]
		UIKit.UIButton rightButton { get; set; }

		[Outlet]
		UIKit.UILabel textLabel { get; set; }

		[Action ("onLeft:")]
		partial void onLeft (Foundation.NSObject sender);

		[Action ("onRight:")]
		partial void onRight (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (leftButton != null) {
				leftButton.Dispose ();
				leftButton = null;
			}

			if (textLabel != null) {
				textLabel.Dispose ();
				textLabel = null;
			}

			if (rightButton != null) {
				rightButton.Dispose ();
				rightButton = null;
			}
		}
	}
}
