﻿using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors
{
	public class VoucherFileConnectionConnector : EntityConnector<VoucherFileConnection, VoucherFileConnections, Sort.By.VoucherFileConnection>
	{
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string VoucherDescription { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string VoucherNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
        [FilterProperty]
		public string VoucherSeries { get; set; }

		/// <remarks/>
		public VoucherFileConnectionConnector()
		{
			base.Resource = "voucherfileconnections";
		}

		/// <summary>
		/// Get a voucher file connection based on fileId
		/// </summary>
		/// <param name="fileId">The id of the file to find.</param>
		/// <returns>The found voucher file connection</returns>
		public VoucherFileConnection Get(string fileId, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, fileId);
		}

		/// <summary>
		/// Creates a new connection between a file and a voucher.
		/// </summary>
		/// <param name="voucherFileConnection">The voucher file connection to create</param>
		/// <returns>The created voucher file connection</returns>
		public VoucherFileConnection Create(VoucherFileConnection voucherFileConnection, string accessToken, string clientSecret)
		{
			return base.BaseCreate(voucherFileConnection, accessToken, clientSecret);
		}

		/// <summary>
		/// Deletes a connected file from a voucher
		/// </summary>
		/// <param name="fileId"></param>
		public void Delete(string fileId, string accessToken, string clientSecret)
		{
			base.BaseDelete(fileId,accessToken,clientSecret);
		}

		/// <summary>
		/// Gets a list of VoucherFile Connections
		/// </summary>
		/// <returns></returns>
		public VoucherFileConnections Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}
