
namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class PreDefinedAccountConnector : FinancialYearBasedEntityConnector<PreDefinedAccount, PreDefinedAccounts, Sort.By.PreDefinedAccount>
	{
		/// <remarks/>
		public PreDefinedAccountConnector()
		{
			base.Resource = "predefinedaccounts";
		}

		/// <summary>
		/// Gets a predefined account
		/// </summary>
		/// <param name="name">The name of the predefined account to get</param>
		/// <returns>a predefined account</returns>
		public PreDefinedAccount Get(string name, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, name);
		}

		/// <summary>
		/// Updates a predefined account
		/// </summary>
		/// <param name="preDefinedAccount">The predefined account to update</param>
		/// <returns>The updated predefined account</returns>
		public PreDefinedAccount Update(PreDefinedAccount preDefinedAccount, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(preDefinedAccount, accessToken, clientSecret, preDefinedAccount.Name);
		}

		/// <summary>
		/// Gets a list of predefined accounts
		/// </summary>
		/// <returns>A list of predefined accounts</returns>
		public PreDefinedAccounts Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
