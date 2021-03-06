﻿
namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class CurrencyConnector : EntityConnector<Currency, Currencies, Sort.By.Currency>
	{
		/// <remarks/>
		public CurrencyConnector()
		{
			base.Resource = "currencies";
		}

		/// <summary>
		/// Gets a currency based on currency code
		/// </summary>
		/// <param name="currencyCode"></param>
		/// <returns></returns>
		public Currency Get(string currencyCode, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, currencyCode);
		}

		/// <summary>
		/// Updates a currency
		/// </summary>
		/// <param name="currency">The currency entity to update</param>
		/// <returns>The updated currency entity</returns>
		public Currency Update(Currency currency, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(currency, accessToken, clientSecret, currency.Code);
		}

		/// <summary>
		/// Create a new currency
		/// </summary>
		/// <param name="currency">The currency entity to create</param>
		/// <returns>The created currency entity</returns>
		public Currency Create(Currency currency, string accessToken, string clientSecret)
		{
			return base.BaseCreate(currency, accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes a currency
		/// </summary>
		/// <param name="currencyCode">The currency code to delete</param>
		/// <returns>If the currency was deleted or not</returns>
		public void Delete(string currencyCode, string accessToken, string clientSecret)
		{
			base.BaseDelete(currencyCode,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets at list of currencies
		/// </summary>
		/// <returns>A list of currencies</returns>
		public Currencies Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
