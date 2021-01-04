using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using Simulatore_Danieli.Models;

namespace Simulatore_Danieli.Services
{
	class TestDataService : IDataService
	{
		public IList<Cast> GetCasts()
		{
			var res = new List<Cast>();
			res.Add(new Cast
			{
				Code = 1,
				Weight = 100,
				Start = 1607771522,
				End = 1607871522,
				Sort = 1,
				State = true,
				Steels = new List<TypeOfSteel>()
			});

			return res;
		}

		public bool StartProduction(int id)
		{
			Messenger.Default.Send(new NotificationMessage("Start Cast"));

			return true;
		}

		public bool PauseProduction(int id)
		{
			Messenger.Default.Send(new NotificationMessage("Pause Cast"));

			return true;
		}

		public bool StopProduction(int id)
		{
			Messenger.Default.Send(new NotificationMessage("Stop Cast"));

			return true;
		}

		public bool ProduceBillet(int id)
		{
			Messenger.Default.Send(new NotificationMessage("Produce Billet"));

			return true;
		}
	}
}
