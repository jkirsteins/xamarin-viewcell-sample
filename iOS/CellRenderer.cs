using System;
using CellTest;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XViewCellRenderer = Xamarin.Forms.Platform.iOS.ViewCellRenderer;

[assembly: ExportRenderer(typeof(MyViewCell), typeof(CellTest.iOS.ViewCellRenderer))]

namespace CellTest.iOS
{
	public class ViewCellRenderer : XViewCellRenderer
	{
		public override UITableViewCell GetCell(Xamarin.Forms.Cell item, UITableViewCell reusableCell, UITableView tv)
		{
			// TODO: this should be in a listview renderer (so it is not set constantly)
			tv.RowHeight = UITableView.AutomaticDimension;
			tv.EstimatedRowHeight = 40f;
			tv.SeparatorStyle = UITableViewCellSeparatorStyle.None;
			// -------

			var x = (MyViewCell)item;
			Console.WriteLine(x);

			MyTableViewCell c = reusableCell as MyTableViewCell;

			if (c == null)
			{
				c = (CellTest.iOS.MyTableViewCell)MyTableViewCell.Nib.Instantiate(null, null)[0];
			}

			c.UpdateCell(x);

			return c;
		}
	}
}

