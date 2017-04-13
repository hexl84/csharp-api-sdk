using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class TermsOfDeliveryConnector : EntityConnector<TermsOfDelivery, TermsOfDeliveries, Sort.By.TermsOfDelivery>
	{
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string Code { get; set; }

		/// <remarks/>
		public TermsOfDeliveryConnector()
		{
			base.Resource = "termsofdeliveries";
		}

		/// <summary>
		/// Find a terms of delivery based on terms of delivery code
		/// </summary>
		/// <param name="termsOfDeliveryCode">The terms of deliverycode to find</param>
		/// <returns>The resulting terms of delivery</returns>
		public TermsOfDelivery Get(string termsOfDeliveryCode, string accessToken, string clientSecret)
		{
			return base.BaseGet(termsOfDeliveryCode, accessToken, clientSecret);
		}

		/// <summary>
		/// Updates a terms of delivery
		/// </summary>
		/// <param name="termsOfDelivery">The terms of delivery entity to update</param>
		/// <returns>The updated terms of delivery</returns>
		public TermsOfDelivery Update(TermsOfDelivery termsOfDelivery)
		{
			return base.BaseUpdate(termsOfDelivery, termsOfDelivery.Code);
		}

		/// <summary>
		/// Create a new terms of delivery
		/// </summary>
		/// <param name="termsOfDelivery">The terms of delivery entity to create</param>
		/// <returns>The created terms of delivery</returns>
		public TermsOfDelivery Create(TermsOfDelivery termsOfDelivery)
		{
			return base.BaseCreate(termsOfDelivery);
		}


		/// <summary>
		/// Deletes a terms of delivery
		/// </summary>
		/// <param name="termsOfDeliveryCode">The terms of delivery code to delete</param>
		/// <returns>If the terms of delivery was deleted or not</returns>
		public void Delete(string termsOfDeliveryCode, string accessToken, string clientSecret)
		{
			base.BaseDelete(termsOfDeliveryCode,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets a list of terms of deliveries
		/// </summary>
		/// <returns>A list of terms of deliveries</returns>
		public TermsOfDeliveries Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken,clientSecret);
		}
	}
}
