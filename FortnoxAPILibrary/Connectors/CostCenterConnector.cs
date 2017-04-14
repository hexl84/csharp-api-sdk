
namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class CostCenterConnector : EntityConnector<CostCenter, CostCenters, Sort.By.CostCenter>
	{
		/// <remarks/>
		public CostCenterConnector()
		{
			base.Resource = "costcenters";
		}

		/// <summary>
		/// Finds a cost center based on cost center code
		/// </summary>
		/// <param name="costCenterCode">The cost center code to find</param>
		/// <returns>The resulting cost center</returns>
		public CostCenter Get(string costCenterCode, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, costCenterCode);
		}


		/// <summary>
		/// Updates a cost center
		/// </summary>
		/// <param name="costCenter">The cost center entity to update</param>
		/// <returns>The updated CostCenter</returns>
		public CostCenter Update(CostCenter costCenter, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(costCenter, costCenter.Code, accessToken, clientSecret);
		}

		/// <summary>
		/// Creates a new cost center
		/// </summary>
		/// <param name="costCenter"></param>
		/// <returns></returns>
		public CostCenter Create(CostCenter costCenter, string accessToken, string clientSecret)
		{
			return base.BaseCreate(costCenter, accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes a cost center
		/// </summary>
		/// <param name="costCenterCode">The cost center to delete</param>
		/// <returns>If the cost center was deleted or not</returns>
		public void Delete(string costCenterCode, string accessToken, string clientSecret)
		{
			base.BaseDelete(costCenterCode, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets a list of cost centers
		/// </summary>
		/// <returns>A list of cost centers</returns>
		public CostCenters Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
