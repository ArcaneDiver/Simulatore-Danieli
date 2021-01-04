using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Simulatore_Danieli.Models;

namespace Simulatore_Danieli.Services
{
	class DataService : IDataService
	{
		private RestClient apiClient;

		public DataService()
		{
			var restEndpoint = ConfigurationManager.AppSettings.Get("restEndpoint");
			apiClient = new RestClient(restEndpoint);
		}

		public IList<Cast> GetCasts()
		{
			throw new NotImplementedException();
		}

		public bool StartProduction(int id)
		{
			throw new NotImplementedException();
		}

		public bool PauseProduction(int id)
		{
			throw new NotImplementedException();
		}

		public bool StopProduction(int id)
		{
			throw new NotImplementedException();
		}

		public bool ProduceBillet(int id)
		{
			throw new NotImplementedException();
		}
	}
}
