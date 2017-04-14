using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public class SupplierInvoiceExternalURLConnectionConnector : EntityConnector<SupplierInvoiceExternalURLConnection, SupplierInvoiceExternalURLConnection, Sort.By.SupplierInvoiceURLConnection>
    {
        /// <remarks/>
        public SupplierInvoiceExternalURLConnectionConnector()
        {
            base.Resource = "supplierinvoiceexternalurlconnections";
        }

        /// <remarks/>
        public SupplierInvoiceExternalURLConnection Get(string id, string accessToken, string clientSecret)
        {
            return base.BaseGet(accessToken, clientSecret, id);
        }

        /// <remarks/>
        public SupplierInvoiceExternalURLConnection Create(SupplierInvoiceExternalURLConnection supplierInvoiceExternalUrlConnection, string accessToken, string clientSecret)
        {
            return base.BaseCreate(supplierInvoiceExternalUrlConnection, accessToken, clientSecret);
        }

        /// <remarks/>
        public SupplierInvoiceExternalURLConnection Update(SupplierInvoiceExternalURLConnection supplierInvoiceExternalUrlConnection, string accessToken, string clientSecret)
        {
            return base.BaseUpdate(supplierInvoiceExternalUrlConnection, accessToken, clientSecret, supplierInvoiceExternalUrlConnection.Id);
        }

        /// <remarks/>
        public void Delete(string id, string accessToken, string clientSecret)
        {
            base.BaseDelete(id, accessToken, clientSecret);
        }
    }
}
