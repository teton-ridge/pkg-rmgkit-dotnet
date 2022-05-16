using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace RMGKit.Models.Account
{
	/// <summary>
	/// Represents subscription details for an account include available and owned products.
	/// </summary>
	[DataContract]
	public class ProductsDetail
	{
		public ProductsDetail()
		{
		}

		#region Properties

		[DataMember(Name = "owned_products")]
		public OwnedProductList? OwnedProducts { get; set; }

		[DataMember(Name = "available_products")]
		public List<string>? AvailableProducts { get; set; }

		#endregion

		#region Methods

		/// <summary>
		/// Indicates if owned products exist.
		/// </summary>
		/// <returns></returns>
		public bool DoesOwnProducts()
        {
			return (this.OwnedProducts?.Count ?? 0) > 0;
		}

		/// <summary>
		/// Indicates if there are available products.
		/// </summary>
		/// <returns></returns>
		public bool AreAvailableProducts()
        {
			return (this.AvailableProducts?.Count ?? 0) > 0;
        }

		/// <summary>
		/// Indicates if the provided product id is considered an available product.
		/// </summary>
		/// <param name="productId"></param>
		/// <returns></returns>
		public bool IsAvailableProduct(string productId)
        {
			if (this.AreAvailableProducts())
            {
				return this.AvailableProducts?.Contains(productId) ?? false;
            }
			return false;
        }

		/// <summary>
		/// Find first owned product, if any, with the provided id.
		/// </summary>
		/// <param name="productId"></param>
		/// <returns></returns>
		public OwnedProduct? GetOwnedProduct(string productId)
        {
			if (this.DoesOwnProducts())
            {
				return this.OwnedProducts!.Find(delegate (OwnedProduct op)
				{
					return op.Id == productId;
				});
            }
			return null;
        }

		/// <summary>
		/// Find first owned product, if any, that can be upgraded or downgraded with the provided id.
		/// </summary>
		/// <param name="productId"></param>
		/// <returns></returns>
		public OwnedProduct? GetOwnedProductWithCrossGrade(string productId)
		{
			if (this.DoesOwnProducts())
			{
				return this.OwnedProducts!.Find(delegate (OwnedProduct op)
				{
					return op.UpgradeProductId == productId || op.DowngradeProductId == productId;
				});
			}
			return null;
		}

		/// <summary>
		/// Returns all available (that may be purchased) product id's.
		/// </summary>
		/// <returns></returns>
		public List<string> GetPurchasableProductIds()
        {
			List<string> ids = new List<string>();

			if (this.AreAvailableProducts())
				ids.AddRange(this.AvailableProducts);

			if (this.DoesOwnProducts())
            {
				this.OwnedProducts!.ForEach(delegate (OwnedProduct op)
				{
					if (op.UpgradeIsAvailable())
						ids.Add(op.UpgradeProductId!);
					if (op.DowngradeIsAvailable())
						ids.Add(op.DowngradeProductId!);
				});
            }

			return ids;
		}

		#endregion
	}
}

