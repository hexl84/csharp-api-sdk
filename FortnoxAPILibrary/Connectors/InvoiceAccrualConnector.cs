﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class InvoiceAccrualConnector : EntityConnector<InvoiceAccrual, InvoiceAccruals, Sort.By.InvoiceAccrual>
	{
		/// <remarks/>
		public InvoiceAccrualConnector()
		{
			base.Resource = "invoiceaccruals";
		}

		/// <remarks/>
		public enum Period
		{
			/// <remarks/>
			MONTHLY,
			/// <remarks/>
			BIMONTHLY,
			/// <remarks/>
			QUARTERLY,
			/// <remarks/>
			SEMIANNUALLY,
			/// <remarks/>
			ANNUALLY
		}

		/// <summary>
		/// Get an invoice accrual	
		/// </summary>
		/// <param name="invoiceNumber">The invoice number of the invoice accrual to get</param>
		/// <returns>The found invoice accrual</returns>
		public InvoiceAccrual Get(string invoiceNumber, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, invoiceNumber);
		}

		/// <summary>
		/// Updates an invoice accrual
		/// </summary>
		/// <param name="invoiceAccrual">The invoice accrual to update</param>
		/// <returns>The updated invoice accrual</returns>
		public InvoiceAccrual Update(InvoiceAccrual invoiceAccrual, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(invoiceAccrual, accessToken, clientSecret, invoiceAccrual.InvoiceNumber);
		}

		/// <summary>
		/// Create a new invoice accrual
		/// </summary>
		/// <param name="invoiceAccrual">The invoice accrual to create</param>
		/// <returns>The created invoice accrual</returns>
		public InvoiceAccrual Create(InvoiceAccrual invoiceAccrual, string accessToken, string clientSecret)
		{
			return base.BaseCreate(invoiceAccrual,accessToken,clientSecret);
		}

		/// <summary>
		/// Deletes an invoice accrual
		/// </summary>
		/// <param name="invoiceNumber">The invoice number of the invoice accrual to delete</param>
		public void Delete(string invoiceNumber, string accessToken, string clientSecret)
		{
			base.BaseDelete(invoiceNumber,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets a list of invoice accruals
		/// </summary>
		/// <returns>A list of invoice accruals</returns>
		public InvoiceAccruals Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
