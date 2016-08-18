using System;
using Xamarin.Forms;

namespace CellTest
{
	public class MyViewCell : ViewCell
	{
		public static readonly BindableProperty FullNameProperty =
			BindableProperty.Create("FullName", typeof(string), typeof(MyViewCell), "John Doe");

		public string FullName
		{
			get { return (string)GetValue(FullNameProperty); }
			set { SetValue(FullNameProperty, value); }
		}
	}
}

