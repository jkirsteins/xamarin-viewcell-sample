using System;
using System.Diagnostics;
using Foundation;
using UIKit;

namespace CellTest.iOS
{
	public partial class MyTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString("MyTableViewCell");
		public static readonly UINib Nib;

		static MyTableViewCell()
		{
			Nib = UINib.FromName("MyTableViewCell", NSBundle.MainBundle);
		}

		internal void UpdateCell(MyViewCell x)
		{
			this.leftButton.TouchUpInside += (sender, e) =>
			{
				Debug.WriteLine("Left");
			};

			this.rightButton.TouchUpInside += (sender, e) =>
			{
				Debug.WriteLine("Right");
			};

			this.textLabel.Text = x.FullName;
		}

		protected MyTableViewCell(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

	}
}
