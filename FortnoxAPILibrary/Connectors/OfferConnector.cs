using System;
using System.Collections.Generic;
using System.Reflection;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class OfferConnector : FinancialYearBasedEntityConnector<Offer, Offers, Sort.By.Offer>
	{
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string CostCenter { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string CustomerName { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		public string CustomerNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string DocumentNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string OurReference { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string Project { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string YourReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string Label { get; set; }


		private bool sentSet = false;
		private bool sent;
		/// <remarks/>
		[FilterProperty]
		public bool Sent
		{
			get
			{
				return sent;
			}
			set
			{
				sent = value;
				sentSet = true;
			}
		}

		private bool notCompletedSet = false;
		private bool notcompleted;
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		public bool NotCompleted
		{
			get
			{
				return notcompleted;
			}
			set
			{
				notcompleted = value;
				notCompletedSet = true;
			}
		}

		private bool filterBySet = false;
		private Filter.Offer filterBy;
		/// <remarks/>
		[FilterProperty("filter")]
		public Filter.Offer FilterBy
		{
			get { return filterBy; }
			set
			{
				filterBy = value;
				filterBySet = true;
			}
		}

		/// <remarks/>
		public enum DiscountType
		{
			/// <remarks/>
			AMOUNT,
			/// <remarks/>
			PERCENT
		}

		/// <remarks/>
		public OfferConnector()
		{
			base.Resource = "offers";
		}

		/// <summary>
		/// Gets an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to find</param>
		/// <returns>An offer</returns>
		public Offer Get(string documentNumber, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, documentNumber.ToString());
		}

		/// <summary>
		/// Updates an offer
		/// </summary>
		/// <param name="offer">The offer to update</param>
		/// <returns>The updated offer</returns>
		public Offer Update(Offer offer, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(offer, accessToken, clientSecret, offer.DocumentNumber.ToString());
		}

		/// <summary>
		/// Create a new offer
		/// </summary>
		/// <param name="offer">The offer to create</param>
		/// <returns>The created offer</returns>
		public Offer Create(Offer offer, string accessToken, string clientSecret)
		{
			return base.BaseCreate(offer, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets a list of offers
		/// </summary>
		/// <returns>A list of offers</returns>
		public Offers Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}

		/// <summary>
		/// Cancel an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to cancel</param>
		/// <returns>The cancelled offer</returns>
		public Offer Cancel(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "cancel", accessToken, clientSecret);
		}

		/// <summary>
		/// Emails an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to be emailed</param>
		public void Email(string documentNumber, string accessToken, string clientSecret)
		{
			base.DoAction(documentNumber, "email", accessToken, clientSecret);
		}

		/// <summary>
		/// Prints an offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to print</param>
		/// <param name="localPath">Where to save the printed offer. If omitted the offer will be set to printed (i.e Sent = true) and no pdf is returned. </param>
		public void Print(string documentNumber, string accessToken, string clientSecret, string localPath = "")
		{
			if (string.IsNullOrEmpty(localPath))
			{
				base.DoAction(documentNumber, "externalprint", accessToken, clientSecret);
			}
			else
			{
				base.LocalPath = localPath;
				base.DoAction(documentNumber, "print", accessToken, clientSecret);
			}
		}

        /// <summary>
        /// Marks the document as externally printed
        /// </summary>
        /// <param name="documentNumber"></param>
        public void ExternalPrint(string documentNumber, string accessToken, string clientSecret)
        {
            base.DoAction(documentNumber, "externalprint", accessToken, clientSecret);
        }

		/// <summary>
		/// Creates an order from the specified offer
		/// </summary>
		/// <param name="documentNumber">The document number of the offer to create order from</param>
		/// <returns></returns>
		public Offer CreateOrder(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "createorder", accessToken, clientSecret);
		}
	}
}
