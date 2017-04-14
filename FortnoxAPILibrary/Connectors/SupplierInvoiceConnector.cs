using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class SupplierInvoiceConnector : FinancialYearBasedEntityConnector<SupplierInvoice, SupplierInvoices, Sort.By.SupplierInvoice>
	{
        /// <remarks/>
        public enum VATType
        {
            /// <remarks/>
            NORMAL,
            /// <remarks/>
            REVERSE,
            /// <remarks/>
            EUINTERNAL
        }

        /// <remarks/>
        public enum SalesType
        {
            /// <remarks/>
            STOCK,
            /// <remarks/>
            SERVICE
        }


		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string SupplierNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string SupplierName { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string OrganisationNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string Phone { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string ZipCode { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string City { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string Email { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string OCR { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string CostCenter { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string Project { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string OurReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string YourReference { get; set; }

        private bool filterBySet = false;
        private Filter.SupplierInvoice filterBy;
        /// <remarks/>
        [FilterProperty("filter")]
        public Filter.SupplierInvoice FilterBy
        {
            get { return filterBy; }
            set
            {
                filterBy = value;
                filterBySet = true;
            }
        }

		/// <remarks/>
		public SupplierInvoiceConnector()
		{
			base.Resource = "supplierinvoices";
		}


		/// <summary>
		/// Get a supplier invoice based on document number
		/// </summary>
		/// <param name="documentNumber">The document number to find</param>
		/// <returns></returns>
		public SupplierInvoice Get(string documentNumber, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, documentNumber.ToString());
		}

		/// <summary>
		/// Updates a supplier invoice
		/// </summary>
		/// <param name="supplierInvoice">the supplier invoice to update</param>
		/// <returns></returns>
		public SupplierInvoice Update(SupplierInvoice supplierInvoice, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(supplierInvoice, accessToken, clientSecret, supplierInvoice.GivenNumber.ToString());
		}

		/// <summary>
		/// Create a new supplier invoice
		/// </summary>
		/// <param name="supplierInvoice">The supplier invoice to create</param>
		/// <returns>The created supplier invoice</returns>
		public SupplierInvoice Create(SupplierInvoice supplierInvoice, string accessToken, string clientSecret)
		{
			return base.BaseCreate(supplierInvoice, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets at list of supplier invoices
		/// </summary>
		/// <returns>A list of supplier invoices</returns>
		public SupplierInvoices Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}

		/// <summary>
		/// Bookkeeps a supplier invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to bookkeep.</param>
		/// <returns>The bookkept invoice</returns>
		public SupplierInvoice Bookkeep(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "bookkeep", accessToken, clientSecret);
		}

		/// <summary>
		/// Cancels a supplier invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to be cancelled</param>
		/// <returns>The cancelled invoice</returns>
		public SupplierInvoice Cancel(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "cancel", accessToken, clientSecret);
		}

		/// <summary>
		/// Credits a supplier invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the supplier invoice to credit</param>
		/// <returns>The credited supplier invoice</returns>
		public SupplierInvoice Credit(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "credit", accessToken, clientSecret);
		}

		/// <summary>
		/// Approves a payment
		/// </summary>
		/// <param name="documentNumber">The doucment number of the supplier invoice to approve</param>
		/// <returns></returns>
		public SupplierInvoice ApprovalPayment(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "approvalpayment", accessToken, clientSecret);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentNumber"></param>
		/// <returns></returns>
		public SupplierInvoice ApprovalBookkeep(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "approvalbookkeep", accessToken, clientSecret);
		}
	}
}