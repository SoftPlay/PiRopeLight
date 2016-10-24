namespace TfsOnPremDriver
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Infrastucture;
	using Windows.Web.Http;

	public class TfsOnPremService : ITfsService
	{
		private readonly HttpClient httpClient;

		public TfsOnPremService()
		{
			this.httpClient = new HttpClient();
		}

		public async Task<IQueryable<string>> GetCompletedBuilds(string project)
		{
			var json = await this.httpClient.GetStringAsync(new Uri("http://tfs:8080/tfs/ApdCollection/API/", UriKind.Absolute));
		}
	}
}
