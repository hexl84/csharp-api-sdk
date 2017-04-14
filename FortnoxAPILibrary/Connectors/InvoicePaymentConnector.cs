using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class InvoicePaymentConnector : FinancialYearBasedEntityConnector<InvoicePayment, InvoicePayments, Sort.By.InvoicePayment>
	{
		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string InvoiceNumber { get; set; }

		/// <remarks/>
		public InvoicePaymentConnector()
		{
			base.Resource = "invoicepayments";
		}

		/// <summary>
		/// Gets an invoice payment
		/// </summary>
		/// <param name="number">The number of the invoice payment to find</param>
		/// <returns>The found invoice payment</returns>
		public InvoicePayment Get(string number, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, number);
		}

		/// <summary>
		/// Updates an invoice payment
		/// </summary>
		/// <param name="invoicePayment">The invoice payment to update</param>
		/// <returns>The updated invoice payment</returns>
		public InvoicePayment Update(InvoicePayment invoicePayment, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(invoicePayment, accessToken, clientSecret, invoicePayment.Number.ToString());
		}

		/// <summary>
		/// Create a new invoice payment
		/// </summary>
		/// <param name="invoicePayment">The invoice payment to be created</param>
		/// <returns>The created invoice payment</returns>
		public InvoicePayment Create(InvoicePayment invoicePayment, string accessToken, string clientSecret)
		{
			return base.BaseCreate(invoicePayment,accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes a payment
		/// </summary>
		/// <param name="number">The number of the payment to delete</param>
		public void Delete(string number, string accessToken, string clientSecret)
		{
			base.BaseDelete(number,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets a list of payments
		/// </summary>
		/// <returns>A list of payments</returns>
		public InvoicePayments Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}

		/// <summary>
		/// Bookkeep an invoice payment
		/// </summary>
		/// <param name="invoicePaymentNumber">The number of the invoice payment to bookkeep.</param>
		public void Bookkeep(string invoicePaymentNumber, string accessToken, string clientSecret)
		{
			base.DoAction(invoicePaymentNumber, "bookkeep", accessToken,clientSecret);
		}
	}
}
