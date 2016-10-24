namespace TfsOnPremDriver
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Infrastucture;

	public class TfsOnPremService : ITfsService
	{
		public Task<IQueryable<string>> GetCompletedBuilds(string project)
		{
			throw new NotImplementedException();
		}
	}
}
