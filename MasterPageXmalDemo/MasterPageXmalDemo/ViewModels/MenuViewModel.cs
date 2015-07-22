using System;
using MasterPageXmalDemo.Models;
using System.Collections.Generic;

namespace MasterPageXmalDemo.ViewModels
{
	public class MenuViewModel: ViewModelBase
	{
		public MenuViewModel ()
		{
			MenuItems = new List<Menu>()
			{
				new Menu()
				{
					Title = "Contacts",
					IconSource = "Images/contacts-2-256.png",
					PageToNavigate = null
				},
				new Menu()
				{
					Title = "GitHub",
					IconSource = "Images/github-10-256.png",
					PageToNavigate = null
				},
				new Menu()
				{
				},
				new Menu()
				{
				},
				new Menu()
				{
				}
			}
		}


		#region MenuItems

		private List<Menu> _MenuItems;

		public List<Menu> MenuItems {
			get {
				return _MenuItems;
			}
			set {
				if (_MenuItems != value) {
					_MenuItems = value;
					OnPropertyChanged ("MenuItems");
				}
			}
		}

		#endregion
	}
}

