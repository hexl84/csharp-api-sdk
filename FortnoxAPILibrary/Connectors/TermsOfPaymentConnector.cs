using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class TermsOfPaymentConnector : EntityConnector<TermsOfPayment, TermsOfPayments, Sort.By.TermsOfPayment>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string Code { get; set; }

		/// <remarks/>
		public TermsOfPaymentConnector()
		{
			base.Resource = "termsofpayments";
		}

		/// <summary>
		/// Gets a Terms of payment by code
		/// </summary>
		/// <param name="termsOfPaymentCode"></param>
		/// <returns></returns>
		public TermsOfPayment Get(string termsOfPaymentCode, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, termsOfPaymentCode);
		}

		/// <summary>
		/// Updates a terms of payment
		/// </summary>
		/// <param name="termsOfPayment"></param>
		/// <returns></returns>
		public TermsOfPayment Update(TermsOfPayment termsOfPayment, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(termsOfPayment, accessToken, clientSecret, termsOfPayment.Code);
		}

		/// <summary>
		/// Create a new Terms of payment
		/// </summary>
		/// <param name="termsOfPayment">The terms of payment entity to create</param>
		/// <returns>The created terms of payment.</returns>
		public TermsOfPayment Create(TermsOfPayment termsOfPayment, string accessToken, string clientSecret)
		{
			return base.BaseCreate(termsOfPayment, accessToken, clientSecret);
		}

		/// <summary>
		/// Delete a terms of payment
		/// </summary>
		/// <param name="termsOfPaymentCode">The terms of payemnt code to delete</param>
		/// <returns>If the terms of payment was deleted. </returns>
		public void Delete(string termsOfPaymentCode, string accessToken, string clientSecret)
		{
			base.BaseDelete(termsOfPaymentCode, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets a list of terms of payments
		/// </summary>
		/// <returns>A list of terms of payments</returns>
		public TermsOfPayments Find(string accessToken, string clientSecret)
        {
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
