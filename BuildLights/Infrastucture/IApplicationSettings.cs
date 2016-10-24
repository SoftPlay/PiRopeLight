namespace Infrastucture
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IApplicationSettings
	{
		string TfsServer { get; }

		ushort TfsPort { get; }

		string CollectionName { get; }

		string ProjectName { get; }
	}
}
