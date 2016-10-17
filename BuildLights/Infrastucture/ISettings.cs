namespace Infrastucture
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface ISettings
	{
		string HostName { get; set; }

		ushort Port { get; set; }

		string Project { get; set; }
	}
}
