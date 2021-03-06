﻿using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class CustomerConnector : EntityConnector<Customer, Customers, Sort.By.Customer>
	{
		/// <remarks/>
		public enum Type
		{
			/// <remarks/>
			PRIVATE,
			/// <remarks/>
			COMPANY,
			/// <remarks/>
			UNDEFINED
		}

		/// <remarks/>
		public enum VATType
		{
			/// <remarks/>
			SEVAT,
			/// <remarks/>
			SEREVERSEDVAT,
			/// <remarks/>
			EUREVERSEDVAT,
			/// <remarks/>
			EUVAT,
			/// <remarks/>
			EXPORT
		}

		/// <remarks/>
		public enum DefaultInvoiceDeliveryType
		{
			/// <remarks/>
			EMAIL,
			/// <remarks/>
			PRINT,
			/// <remarks/>
			PRINTSERVICE,
            /// <remarks/>
            ELECTRONICINVOICE
		}

		/// <remarks/>
		public enum DefaultOfferDeliveryType
		{
			/// <remarks/>
			EMAIL,
			/// <remarks/>
			PRINT
		}

		/// <remarks/>
		public enum DefaultOrderDeliveryType
		{
			/// <remarks/>
			EMAIL,
			/// <remarks/>
			PRINT
		}

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string City { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string CustomerNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string Email { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string Name { get; set; }

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

		/// <remarks/>
		public CustomerConnector()
		{
			base.Resource = "customers";
		}


		/// <summary>
		/// Find a customer based on customernumber
		/// </summary>
		/// <param name="customerNumber">The customernumber to find</param>
		/// <returns>The found customer</returns>
		public Customer Get(string customerNumber, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, customerNumber);
		}

		/// <summary>
		/// Updates a customer
		/// </summary>
		/// <param name="customer">The customer to update</param>
		/// <returns>The updated customer</returns>
		public Customer Update(Customer customer, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(customer,accessToken, clientSecret, customer.CustomerNumber);
		}

		/// <summary>
		/// Create a new customer
		/// </summary>
		/// <param name="customer">The customer to create</param>
		/// <returns>The created customer</returns>
		public Customer Create(Customer customer, string accessToken, string clientSecret)
		{
			return base.BaseCreate(customer, accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes a customer
		/// </summary>
		/// <param name="customerNumber">The customernumber to delete</param>
		public void Delete(string customerNumber, string accessToken, string clientSecret)
		{
			base.BaseDelete(customerNumber,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets a list of customers
		/// </summary>
		/// <returns>A list of customers</returns>
		public Customers Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}