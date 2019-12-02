using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorIphone
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
			nav.Clicked += Nav_Clicked;
		}

		private async void Nav_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage());

		}
	}
}