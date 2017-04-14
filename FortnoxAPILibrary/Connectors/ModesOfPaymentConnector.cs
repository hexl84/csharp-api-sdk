using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class ModesOfPaymentConnector : FinancialYearBasedEntityConnector<ModeOfPayment, ModesOfPayments, Sort.By.ModesOfPayment>
	{
		/// <remarks/>
		public ModesOfPaymentConnector()
		{
			base.Resource = "modesofpayments";
		}

		/// <summary>
		/// Find a mode of payment 
		/// </summary>
		/// <param name="code">The code to find</param>
		/// <returns>The found mode of payment</returns>
		public ModeOfPayment Get(string code, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, code);
		}

		/// <summary>
		/// Updates a mode of payment
		/// </summary>
		/// <param name="modeofpayment">The mode of payment to update</param>
		/// <returns>The updated mode of payment</returns>
		public ModeOfPayment Update(ModeOfPayment modeofpayment, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(modeofpayment, accessToken, clientSecret, modeofpayment.Code);
		}

		/// <summary>
		/// Create a new Mode of payment
		/// </summary>
		/// <param name="modeOfPayment">The mode of payment to create</param>
		/// <returns>The created mode of payment</returns>
		public ModeOfPayment Create(ModeOfPayment modeOfPayment, string accessToken, string clientSecret)
		{
			return base.BaseCreate(modeOfPayment, accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes a mode of payment
		/// </summary>
		/// <param name="code">The code of the mode of payment to delete</param>
		public void Delete(string code, string accessToken, string clientSecret)
		{
			base.BaseDelete(code,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets a list of Modes of payment
		/// </summary>
		/// <returns></returns>
		public ModesOfPayments Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
