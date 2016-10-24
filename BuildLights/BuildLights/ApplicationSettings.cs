namespace BuildLights
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Infrastucture;
	using Windows.Storage;

	public class ApplicationSettings : IApplicationSettings
	{
		private readonly ApplicationDataContainer localSettings;
		private readonly StorageFolder localFolder;

		public ApplicationSettings()
		{
			this.localSettings = ApplicationData.Current.LocalSettings;
			this.localFolder = ApplicationData.Current.LocalFolder;
		}

		public string CollectionName
		{
			get
			{
				return (string)this.localSettings.Values["CollectionName"];
			}
		}

		public string ProjectName
		{
			get
			{
				return (string)this.localSettings.Values["ProjectName"];
			}
		}

		public ushort TfsPort
		{
			get
			{
				return ushort.Parse((string)this.localSettings.Values["TfsPort"]);
			}
		}

		public string TfsServer
		{
			get
			{
				return (string)this.localSettings.Values["TfsServer"];
			}
		}
	}
}
