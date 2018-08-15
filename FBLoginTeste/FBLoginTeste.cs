using System;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace FBLoginTeste
{
	public class App : Application
	{
		public static Action HideLoginView
		{
			get {
				return new Action (() => App.Current.MainPage.Navigation.PopModalAsync ());
			}
		}

		public async static Task NavigateToProfile(string message)
		{
			await App.Current.MainPage.Navigation.PushAsync (new Profile(message));
		}

		public App ()
		{
			MainPage = new NavigationPage (new Main());
		}
	}
}