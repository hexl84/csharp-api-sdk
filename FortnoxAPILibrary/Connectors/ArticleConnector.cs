using System.Collections.Generic;

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class ArticleConnector : FinancialYearBasedEntityConnector<Article, Articles, Sort.By.Article>
	{
		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string ArticleNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string Description { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string EAN { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string SupplierNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string Manufacturer { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string ManufacturerArticleNumber { get; set; }

		/// <summary>
		/// Use with Find() to limit the search result
		/// </summary>
		[FilterProperty]
		public string Webshop { get; set; }

		/// <remarks/>
		public enum ArticleType
		{
			/// <remarks/>
			STOCK,
			/// <remarks/>
			SERVICE
		}

		/// <remarks/>
		public ArticleConnector()
		{
			base.Resource = "articles";
		}

		/// <summary>
		/// Gets an article based on articlenumber
		/// </summary>
		/// <param name="articleNumber">The articlenumber to find</param>
		/// <returns>The found article</returns>
		public Article Get(string articleNumber, string accessToken, string clientSecret)
		{
			return base.BaseGet(accessToken, clientSecret, articleNumber);
		}

		/// <summary>
		/// Updates an article
		/// </summary>
		/// <param name="article">The article to update</param>
		/// <returns>The updated article</returns>
		public Article Update(Article article, string accessToken, string clientSecret)
		{
			return base.BaseUpdate(article, accessToken, clientSecret, article.ArticleNumber);
		}

		/// <summary>
		/// Creates a new article
		/// </summary>
		/// <param name="article">The article to create</param>
		/// <returns>The created article</returns>
		public Article Create(Article article, string accessToken, string clientSecret)
		{
			return base.BaseCreate(article,accessToken,clientSecret);
		}

		/// <summary>
		/// Deletes an article
		/// </summary>
		/// <param name="articleNumber">The articlenumber of the article to delete</param>
		/// <returns>If the article was deleted or not</returns>
		public void Delete(string articleNumber, string accessToken, string clientSecret)
		{
			base.BaseDelete(articleNumber, accessToken, clientSecret);
		}

		/// <summary>
		/// Gets a list of articles
		/// </summary>
		/// <returns>A list of articles</returns>
		public Articles Find(string accessToken, string clientSecret)
		{
			return base.BaseFind(accessToken, clientSecret);
		}
	}
}