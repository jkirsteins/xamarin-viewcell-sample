using System;
using Xamarin.Forms;

namespace CellTest
{
	public partial class CellTestPage : ContentPage
	{
		public CellTestPage()
		{
			InitializeComponent();

			this.listView.ItemsSource = new string[] {
				Faker.Name.FullName() + Environment.NewLine + Faker.Address.Country(),
					 Faker.Name.FullName() + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Woop woop",
					 Faker.Name.FullName()
			};
		}
	}
}

