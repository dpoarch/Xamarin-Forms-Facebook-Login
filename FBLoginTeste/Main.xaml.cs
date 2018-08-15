using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FBLoginTeste
{
	public partial class Main : ContentPage
	{
		public Main ()
		{
			InitializeComponent ();

			this.btnLogar.Clicked += async (sender, e) => {
				await Navigation.PushAsync(new Login());
			};
		}
	}
}

