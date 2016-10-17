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

		public Settings()
		{
			var applicationData = Windows.Storage.ApplicationData.Current;

			this.application = applicationData.LocalSettings;
		}

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
				return (ushort)this.application.Values["Port"];
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
				return (string)this.application.Values["Project"];
			}

			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
