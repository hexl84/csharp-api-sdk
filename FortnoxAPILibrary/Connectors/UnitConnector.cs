﻿
namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class UnitConnector : EntityConnector<Unit, Units, Sort.By.Unit>
	{
		/// <remarks/>
		public UnitConnector()
		{
			base.Resource = "units";
		}

		/// <summary>
		/// Gets a unit based on unit code
		/// </summary>
		/// <param name="unitCode">The unit code to find</param>
		/// <returns>The found unit</returns>
		public Unit Get(string unitCode, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, unitCode);
		}

		/// <summary>
		/// Updates a unit
		/// </summary>
		/// <param name="unit">Unit to update</param>
		/// <returns>The updated unit</returns>
		public Unit Update(Unit unit, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(unit, accessToken, clientSecret, unit.Code);
		}

		/// <summary>
		/// Create a new unit
		/// </summary>
		/// <param name="unit">The unit to create</param>
		/// <returns>The created unit</returns>
		public Unit Create(Unit unit, string accessToken, string clientSecret)
		{
			return base.BaseCreate(unit, accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes a unit
		/// </summary>
		/// <param name="unitCode">The unit code to delete</param>
		/// <returns>If the unit was deleted or not.</returns>
		public void Delete(string unitCode, string accessToken, string clientSecret)
		{
			base.BaseDelete(unitCode,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets a list of units
		/// </summary>
		/// <returns>A list of units</returns>
		public Units Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
