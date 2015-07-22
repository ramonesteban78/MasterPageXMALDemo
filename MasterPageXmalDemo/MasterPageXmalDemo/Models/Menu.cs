using System;

namespace MasterPageXmalDemo.Models
{
	public class Menu
	{
		public string Title { get; set; }

		public string IconSource { get; set; }

		public Type PageToNavigate { get; set; } 
	}
}

