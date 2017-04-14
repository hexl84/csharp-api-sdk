﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class InvoiceConnector : FinancialYearBasedEntityConnector<Invoice, Invoices, Sort.By.Invoice>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string FromDate { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string ToDate { get; set; }

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
        [FilterProperty]
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
		public string OCR { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string OurReference { get; set; }

        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
        public string InvoiceDate { get; set; }

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
		private Filter.Invoice filterBy;
        /// <remarks/>
        [FilterProperty("filter")]
		public Filter.Invoice FilterBy
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
		public enum InvoiceType
		{
			/// <remarks/>
			INVOICE,
			/// <remarks/>
			CASHINVOICE,
			/// <remarks/>
			INTRESTINVOICE,
			/// <remarks/>
			AGREEMENTINVOICE,
			/// <remarks/>
			SUMMARYINVOICE
		}

		/// <remarks/>
		public InvoiceConnector()
		{
			base.Resource = "invoices";
		}

		/// <summary>
		/// Find an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to find</param>
		/// <returns>The found invoice</returns>
		public Invoice Get(string documentNumber, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, documentNumber);
		}

		/// <summary>
		/// Updates an Invoice
		/// </summary>
		/// <param name="invoice">The invoice to update</param>
		/// <returns>The updated invoice</returns>
		public Invoice Update(Invoice invoice, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(invoice, accessToken, clientSecret, invoice.DocumentNumber);
		}

		/// <summary>
		/// Create a new invoice
		/// </summary>
		/// <param name="invoice">The invoice to create</param>
		/// <returns>The created invoice</returns>
		public Invoice Create(Invoice invoice, string accessToken, string clientSecret)
		{
			return base.BaseCreate(invoice, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets at list of Invoices
		/// </summary>
		/// <returns>A list of invoices</returns>
		public Invoices Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}

		/// <summary>
		/// Bookkeep an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to bookkeep.</param>
		/// <returns>The bookkept invoice</returns>
		public Invoice Bookkeep(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "bookkeep", accessToken, clientSecret);
		}

		/// <summary>
		/// Cancel an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to cancel</param>
		/// <returns>The cancelled invoice</returns>
		public Invoice Cancel(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "cancel", accessToken, clientSecret);
		}

		/// <summary>
		/// Credit an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to credit</param>
		/// <returns>The credited invoice</returns>
		public Invoice Credit(string documentNumber, string accessToken, string clientSecret)
		{
			return base.DoAction(documentNumber, "credit", accessToken, clientSecret);
		}

		/// <summary>
		/// Emails an invoice
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to be emailed</param>
		public void Email(string documentNumber, string accessToken, string clientSecret)
		{
			base.DoAction(documentNumber, "email", accessToken, clientSecret);
		}

		/// <summary>
		/// Print an invoice to pdf
		/// </summary>
		/// <param name="documentNumber">The document number of the invoice to print</param>
		/// <param name="localPath">The path where to save the generated pdf. If omitted the invoice will be set to printed (i.e Sent = true) and no pdf is returned. </param>
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
        
        /// <param name="documentNumber">The document number of the invoice to print</param>
        public void EPrint(string documentNumber, string accessToken, string clientSecret)
        {
            base.DoAction(documentNumber, "eprint", accessToken, clientSecret);
        }

		/// <summary>
		/// Prints a reminder to pdf and increments <Reminders></Reminders> on the invoice
		/// </summary>
		/// <param name="documentNumber"></param>
		/// <param name="localPath">The path where to save the reminder </param>
		public void PrintReminder(string documentNumber, string localPath, string accessToken, string clientSecret)
		{
			base.LocalPath = localPath;
			base.DoAction(documentNumber, "printreminder", accessToken, clientSecret);
		}

        /// <summary>
        /// Prints a preview as pdf
        /// </summary>
        /// <param name="documentNumber"></param>
        /// <param name="localPath">The path where to save the preview</param>
        public void Preview(string documentNumber, string localPath, string accessToken, string clientSecret)
        {
            base.LocalPath = localPath;
            base.DoAction(documentNumber, "preview", accessToken, clientSecret);
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
