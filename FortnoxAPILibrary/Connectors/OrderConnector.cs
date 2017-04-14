using System;
using System.Collections.Generic;
using System.Reflection;

namespace FortnoxAPILibrary.Connectors
{

	/// <remarks/>
	public class OrderConnector : FinancialYearBasedEntityConnector<Order, Orders, Sort.By.Order>
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
		[FilterProperty]
		public string CustomerNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		public string DocumentNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string ExternalInvoiceReference1 { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string ExternalInvoiceReference2 { get; set; }

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
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
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
		[FilterProperty]
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
		private Filter.Order filterBy;
		/// <remarks/>
		[FilterProperty("filter")]
		public Filter.Order FilterBy
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
		public OrderConnector()
		{
			base.Resource = "orders";
		}


		/// <summary>
		/// Gets an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to find</param>
		/// <returns>An order</returns>
		public Order Get(string documentNumber, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, documentNumber.ToString());
		}

		/// <summary>
		/// Updates an order
		/// </summary>
		/// <param name="order">The order to update</param>
		/// <returns>The updated order</returns>
		public Order Update(Order order, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(order, accessToken, clientSecret, order.DocumentNumber.ToString());
		}

		/// <summary>
		/// Creates a new order
		/// </summary>
		/// <param name="order">The order to create</param>
		/// <returns>The created order</returns>
		public Order Create(Order order, string accessToken, string clientSecret)
		{
			return base.BaseCreate(order, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets a list of orders
		/// </summary>
		/// <returns>A list of orders</returns>
		public Orders Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}

		/// <summary>
		/// Cancel an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to canceld</param>
		/// <returns>The cancelled order</returns>
		public Order Cancel(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "cancel", accessToken, clientSecret);
		}

		/// <summary>
		/// Emails an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to be emailed</param>
		public void Email(string documentNumber, string accessToken, string clientSecret)
		{
			base.DoAction(documentNumber, "email", accessToken, clientSecret);
		}


		/// <summary>
		/// Print an order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to print</param>
		/// <param name="localPath">Where to save the printed order. If omitted the order will be set to printed (i.e Sent = true) and no pdf is returned. </param>
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
		/// Creates an invoice from the specified order
		/// </summary>
		/// <param name="documentNumber">The document number of the order to create invoice from</param>
		/// <returns></returns>
		public Order CreateInvoice(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "createinvoice", accessToken, clientSecret);
		}

        /// <summary>
        /// Marks the document as externally printed
        /// </summary>
        /// <param name="documentNumber"></param>
        public void ExternalPrint(string documentNumber, string accessToken, string clientSecret)
        {
            base.DoAction(documentNumber, "externalprint", accessToken, clientSecret);
        }
	}
}
