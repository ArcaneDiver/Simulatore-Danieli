using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulatore_Danieli.Models;

namespace Simulatore_Danieli.Services
{
	public interface IDataService
	{
		IList<Cast> GetCasts();

		bool StartProduction(int id);
		bool PauseProduction(int id);
		bool StopProduction(int id);
		bool ProduceBillet(int id);
	}
}
