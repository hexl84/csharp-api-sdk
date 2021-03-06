﻿using System;
using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class AccountConnector : FinancialYearBasedEntityConnector<Account, Accounts, Sort.By.Account>
	{
		/// <remarks/>
		public enum CostCenterSettingsValue
		{
			/// <remarks/>
			ALLOWED,
			/// <remarks/>
			NOTALLOWED,
			/// <remarks/>
			MANDATORY
		}

		/// <remarks/>
		public enum ProjectSettingsValue
		{
			/// <remarks/>
			ALLOWED,
			/// <remarks/>
			NOTALLOWED,
			/// <remarks/>
			MANDATORY
		}

		/// <remarks/>
		public enum TransactionInfoSettingsValue
		{
			/// <remarks/>
			ALLOWED,
			/// <remarks/>
			NOTALLOWED,
			/// <remarks/>
			MANDATORY
		}

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string SRU { get; set; }

		/// <remarks/>
		public AccountConnector()
		{
			base.Resource = "accounts";
		}

		/// <summary>
		/// Find an account based on account number
		/// </summary>
		/// <param name="accountNumber">Tha account number to find</param>
		/// <returns>The found account</returns>
		public Account Get(string accountNumber,string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, accountNumber);
		}

		/// <summary>
		/// Updates an account
		/// </summary>
		/// <param name="account">Account to update</param>
		/// <returns>The updated account</returns>
		public Account Update(Account account, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(account, accessToken, clientSecret, account.Number.ToString());
		}

		/// <summary>
		/// Create a new account
		/// </summary>
		/// <param name="account">The account to create</param>
		/// <returns>The created account</returns>
		public Account Create(Account account, string accessToken, string clientSecret)
		{
			return base.BaseCreate(account, accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes an account
		/// </summary>
		/// <param name="accountNumber">The account number to delete</param>
		/// <returns>If the account was deleted or not</returns>
		public void Delete(string accountNumber, string accessToken, string clientSecret)
		{
			base.BaseDelete(accountNumber, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets at list of accounts
		/// </summary>
		/// <returns>A list of accounts</returns>
		public Accounts Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
