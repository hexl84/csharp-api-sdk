using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public class ContractAccrualConnector : EntityConnector<ContractAccrual, ContractAccruals, Sort.By.ContractAccrual>
    {
		/// <remarks/>
        public ContractAccrualConnector()
		{
			base.Resource = "contractaccruals";
		}

        /// <summary>
        /// Get an contract accrual	
        /// </summary>
        /// <param name="contractNumber">The contract number of the contract accrual to get</param>
        /// <returns>The found contract accrual</returns>
        public ContractAccrual Get(string contractNumber, string accessToken, string clientSecret)
        {
            return base.BaseGet(contractNumber,accessToken,clientSecret);
        }

        /// <summary>
        /// Updates an contract accrual
        /// </summary>
        /// <param name="contractAccrual">The contract accrual to update</param>
        /// <returns>The updated contract accrual</returns>
        public ContractAccrual Update(ContractAccrual contractAccrual)
        {
            return base.BaseUpdate(contractAccrual, contractAccrual.DocumentNumber);
        }

        /// <summary>
        /// Create a new contract accrual
        /// </summary>
        /// <param name="contractAccrual">The contract accrual to create</param>
        /// <returns>The created contract accrual</returns>
        public ContractAccrual Create(ContractAccrual contractAccrual)
        {
            return base.BaseCreate(contractAccrual);
        }

        /// <summary>
        /// Deletes an contract accrual
        /// </summary>
        /// <param name="contractNumber">The contract number of the contract accrual to delete</param>
        public void Delete(string contractNumber, string accessToken, string clientSecret)
        {
            base.BaseDelete(contractNumber, accessToken, clientSecret);
        }

        /// <summary>
        /// Gets a list of contract accruals
        /// </summary>
        /// <returns>A list of contract accruals</returns>
        public ContractAccruals Find(string accessToken, string clientSecret)
        {
            return base.BaseFind(accessToken,clientSecret);
        }
    }
}
