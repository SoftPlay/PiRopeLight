namespace BuildLights
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Infrastucture;
	using Windows.Storage;

	public class Settings : ISettings
	{
		private ApplicationDataContainer application;

		public string HostName
		{
			get
			{
				return (string)this.application.Values["HostName"];
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public ushort Port
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public string Project
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				throw new NotImplementedException();
			}
		}

		public Settings()
		{
			var applicationData = Windows.Storage.ApplicationData.Current;

			this.application = applicationData.LocalSettings;
		}
	}
}
