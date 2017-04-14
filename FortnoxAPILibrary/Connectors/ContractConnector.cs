using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public class ContractConnector : FinancialYearBasedEntityConnector<Contract, Contracts, Sort.By.Contract>
    {
        /// <remarks/>
        [FilterProperty]
        public string DocumentNumber { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string CustomerNumber { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string CustomerName { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string TemplateNumber { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string ContractLength { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string InvoiceInterval { get; set; }

        /// <remarks/>
        public string LastInvoiceDate { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string Total { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string InvoicesRemaining { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string PeriodStart { get; set; }

        /// <remarks/>
        [FilterProperty]
        public string PeriodEnd { get; set; }

        private bool filterBySet = false;
        private Filter.Contract filterBy;
        /// <remarks/>
        [FilterProperty("filter")]
        public Filter.Contract FilterBy
        {
            get { return filterBy; }
            set
            {
                filterBy = value;
                filterBySet = true;
            }
        }

        /// <remarks/>
        public ContractConnector()
        {
            base.Resource = "contracts";
        }
        
		/// <summary>
		/// Find a Contract
		/// </summary>
		/// <param name="documentNumber">The document number of the Contract to find</param>
		/// <returns>The found Contract</returns>
        public Contract Get(string documentNumber, string accessToken, string clientSecret)
        {
            return base.BaseGet(documentNumber, accessToken, clientSecret);
        }

        /// <summary>
        /// Updates a Contract
        /// </summary>
        /// <param name="contract">The Contract to update</param>
        /// <returns>The updated Contract</returns>
        public Contract Update(Contract contract, string accessToken, string clientSecret)
        {
            return base.BaseUpdate(contract, contract.DocumentNumber, accessToken, clientSecret);
        }

        /// <summary>
        /// Create a new Contract
        /// </summary>
        /// <param name="contract">The Contract to create</param>
        /// <returns>The created Contract</returns>
        public Contract Create(Contract contract, string accessToken, string clientSecret)
        {
            return base.BaseCreate(contract, accessToken, clientSecret);
        }

        /// <summary>
        /// Gets at list of Contracts
        /// </summary>
        /// <returns>A list of Contracts</returns>
        public Contracts Find(string accessToken, string clientSecret)
        {
            return base.BaseFind(accessToken, clientSecret);
        }

        /// <summary>
        /// Finish a contract
        /// </summary>
        /// <param name="documentNumber">The document number of the contract to finish.</param>
        /// <returns>The finished contract</returns>
        public Contract Finish(string documentNumber, string accessToken, string clientSecret)
        {
            return base.DoAction(documentNumber, "finish", accessToken, clientSecret);
        }

        /// <summary>
        /// Create an invoice from a contract
        /// </summary>
        /// <param name="documentNumber">The document number of the contract to create an Invoice from.</param>
        /// <returns>The Contract that the Invoice was created from</returns>
        public Contract CreateInvoice(string documentNumber, string accessToken, string clientSecret)
        {
            return base.DoAction(documentNumber, "createinvoice", accessToken, clientSecret);
        }

        /// <summary>
        /// Increase the Invoice count for the Contract
        /// </summary>
        /// <param name="documentNumber">The document number of the Contract to increase the Invoice.</param>
        /// <returns>The Contract that the Invoice was created from</returns>
        public Contract IncreaseInvoiceCount(string documentNumber, string accessToken, string clientSecret)
        {
            return base.DoAction(documentNumber, "increaseinvoicecount", accessToken, clientSecret);
        }
    }
}
