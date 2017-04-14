using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class SupplierInvoicePaymentConnector : FinancialYearBasedEntityConnector<SupplierInvoicePayment, SupplierInvoicePayments, Sort.By.SupplierInvoicePayment>
	{
        /// <remarks/>
        [FilterProperty]
        public string InvoiceNumber { get; set; }

		/// <remarks/>
		public SupplierInvoicePaymentConnector()
		{
			base.Resource = "supplierinvoicepayments";
		}

		/// <summary>
		/// Create a new supplier invoice payment
		/// </summary>
		/// <param name="supplierInvoicePayment">The supplier invoice payment to be created</param>
		/// <returns>The created supplier invoice payment</returns>
		public SupplierInvoicePayment Create(SupplierInvoicePayment supplierInvoicePayment, string accessToken, string clientSecret)
		{
			return base.BaseCreate(supplierInvoicePayment, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets a list of supplier payments
		/// </summary>
		/// <returns>A list of payments</returns>
		public SupplierInvoicePayments Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}

        /// <summary>
        /// Gets a supplier invoice payment based on supplier invoice payment number
        /// </summary>
        /// <param name="supplierInvoicePaymentNumber">The supplier invoice payment number to find</param>
        /// <returns>The found supplier invoice payment</returns>
        public SupplierInvoicePayment Get(string supplierInvoicePaymentNumber, string accessToken, string clientSecret)
        {
            return base.BaseGet(accessToken, clientSecret, supplierInvoicePaymentNumber);
        }

		/// <summary>
		/// Bookkeep a supplier invoice payment
		/// </summary>
		/// <param name="supplierInvoicePaymentNumber">The number of the supplier invoice payment to bookkeep.</param>
		public void Bookkeep(string supplierInvoicePaymentNumber, string accessToken, string clientSecret)
		{
			base.DoAction(supplierInvoicePaymentNumber, "bookkeep", accessToken, clientSecret);
		}
	}
}
