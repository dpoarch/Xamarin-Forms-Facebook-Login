using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FBLoginTeste
{
	public partial class Profile : ContentPage
	{
		public Profile (string message)
		{
			InitializeComponent ();

			this.lblMessage.Text = message;
		}
	}
}

