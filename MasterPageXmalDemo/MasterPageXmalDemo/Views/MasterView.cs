using System;

using Xamarin.Forms;

namespace MasterPageXmalDemo.Views
{
	public class MasterView : MasterDetailPage
	{
		public MasterView()
		{
			// Load the default content for the Master and Details
			MenuView menu = ViewFactory.CreatePage<MenuViewModel, MenuView>() as MenuView;
			menu.Menu.ItemSelected += Menu_ItemSelected;

			Master = menu;
			Detail = new NavigationPage(ViewFactory.CreatePage<HomeViewModel, HomeView>() as HomeView);

			// Subscribe Message center to make the navigation
			//MessagingCenter.Subscribe<object, MenuListElem>(this, "NavigateToMenu", (sender, arg) => NavigateToElem (arg));

			//MessagingCenter.Subscribe<object, Type>(this, "NavigateToPage", (sender, arg) => NavigateToPage (arg));
		}

		private void Menu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			this.NavigateToElem(e.SelectedItem as MenuListElem);
			((ListView)sender).SelectedItem = null;
		}

		private void NavigateToElem(MenuListElem menuElem)
		{
			if (menuElem == null)
				return;

			Detail = new NavigationPage (menuElem.PageToNavigate);
			IsPresented = false;
		}

		public void NavigateToPage<TViewModel, TPage>() where TViewModel : ViewModel where TPage : Page
		{
			Detail = new NavigationPage(ViewFactory.CreatePage<TViewModel, TPage>() as TPage);
			IsPresented = false;
		}
	}
}


