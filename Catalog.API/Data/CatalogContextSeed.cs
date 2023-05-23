﻿using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
	public static class CatalogContextSeed
	{
		public static void SeedData(IMongoCollection<Product> productCollection)
		{
			var existProduct = productCollection.Find(p => true).Any();

			if (!existProduct)
			{
				productCollection.InsertManyAsync(GetPreconfiguredProducts());
			}
		}

		private static IEnumerable<Product> GetPreconfiguredProducts()
		{
			var list = new List<Product>
			{
				new()
				{
					Name = "IPhone X",
					Summary = "Summary",
					Description = "Description",
					ImageFile = "product-1.png",
					Price = 950.00M,
					Category = "Smart Phone"
				},
				new()
				{
					Name = "Samsung 10",
					Summary = "Summary",
					Description = "Description",
					ImageFile = "product-2.png",
					Price = 840.00M,
					Category = "Smart Phone"
				},
				new()
				{
					Name = "Huawei Plus",
					Summary = "Summary",
					Description = "Description",
					ImageFile = "product-3.png",
					Price = 650.00M,
					Category = "White Appliances"
				},
				new()
				{
					Name = "Xiaomi Mi 9",
					Summary = "Summary",
					Description = "Description",
					ImageFile = "product-4.png",
					Price = 470.00M,
					Category = "White Appliances"
				},
				new()
				{
					Name = "LG G 10",
					Summary = "Summary",
					Description = "Description",
					ImageFile = "product-5.png",
					Price = 320.00M,
					Category = "Home Kitchen"
				},
				new()
				{
					Name = "Sony 10",
					Summary = "Summary",
					Description = "Description",
					ImageFile = "product-6.png",
					Price = 240.00M,
					Category = "Home Kitchen"
				}
			};

			return list;
		}
	}
}
