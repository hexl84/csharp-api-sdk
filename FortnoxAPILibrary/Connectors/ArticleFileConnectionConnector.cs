using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class ArticleFileConnectionConnector : EntityConnector<ArticleFileConnection, ArticleFileConnections, Sort.By.ArticleFileConnection>
	{
		/// <summary>
		/// Use with Find() to limit the search result
        /// </summary>
        [FilterProperty]
		public string ArticleNumber { get; set; }

		/// <remarks/>
		public ArticleFileConnectionConnector()
		{
			base.Resource = "articlefileconnections";
		}

		/// <summary>
		/// Get a article file connection based on fileId
		/// </summary>
		/// <param name="fileId">The id of the file to get</param>
		/// <returns>The found article file connection</returns>
		public ArticleFileConnection Get(string fileId, string accessToken, string clientSecret)
		{
			return base.BaseGet(fileId,accessToken,clientSecret);
		}

		/// <summary>
		/// Creates a new connection between a file and an article
		/// </summary>
		/// <param name="articleFileConnection">The article file connection to create</param>
		/// <returns>The created article file connection</returns>
		public ArticleFileConnection Create(ArticleFileConnection articleFileConnection, string accessToken, string clientSecret)
		{
			return base.BaseCreate(articleFileConnection,accessToken,clientSecret);
		}

		/// <summary>
		/// Deletes a connected file from a article
		/// </summary>
		/// <param name="fileId">The id of the file to delete</param>
		public void Delete(string fileId, string accessToken, string clientSecret)
		{
			base.BaseDelete(fileId, accessToken, clientSecret);
		}


		/// <summary>
		/// Gets a list of article file Connections
		/// </summary>
		/// <returns></returns>
		public ArticleFileConnections Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken,clientSecret);
		}
	}
}
