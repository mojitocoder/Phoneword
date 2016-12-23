using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Phoneword
{
	public class StockListing
	{
		public StockListing()
		{

		}

		private IEnumerable<Stock> LoadFromFile(Exchange exchange, string fileName)
		{
			var stocks = new List<Stock>();

			var assembly = typeof(StockListing).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("Phoneword.Resources." + fileName);
			using (var reader = new StreamReader(stream))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					var elements = line.Split('\t');
					var stock = new Stock
					{
						Name = elements[0],
						Symbol = elements[1],
						Exchange = exchange
					};
					stocks.Add(stock);
				}
			}

			return stocks;
		}

		public IEnumerable<Stock> ListStocks()
		{
			var stocks = new List<Stock>();

			stocks.AddRange(LoadFromFile(Exchange.NYSE, "StocksNYSE.txt"));
			stocks.AddRange(LoadFromFile(Exchange.NASDAQ, "StocksNASDAQ.txt"));

			return stocks;
		}
	}

	public class Stock
	{
		public string Name
		{
			get;
			set;
		}
		public string Symbol
		{
			get;
			set;
		}

		public Exchange Exchange
		{
			get;
			set;
		}
	}

	public enum Exchange
	{ 
		NYSE,
		NASDAQ
	}
}
