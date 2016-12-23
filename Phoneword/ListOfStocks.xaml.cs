using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

using Xamarin.Forms;

namespace Phoneword
{
	public partial class ListOfStocks : ContentPage
	{
		public ListOfStocks()
		{
			InitializeComponent();


			var stocks = new StockListing().ListStocks().Take(100);

			listViewOfStocks.ItemsSource = stocks; //new[] { "x", "y", "z" };
		}
	}
}
