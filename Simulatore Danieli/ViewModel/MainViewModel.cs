using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using RestSharp;
using Simulatore_Danieli.Models;

namespace Simulatore_Danieli.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
	    private RestClient apiClient;

		private ObservableCollection<Product> _products;
		private ObservableCollection<Cast> _casts;

		public MainViewModel()
		{
			var restEndpoint = ConfigurationManager.AppSettings.Get("restEndpoint");

			apiClient = new RestClient(restEndpoint);
			Debug.WriteLine(restEndpoint);


			StartCastCommand = new RelayCommand(StartCastMethod);
			PauseCastCommand = new RelayCommand(PauseCastMethod);
			StopCastCommand = new RelayCommand(StopCastMethod);
			CreateProductCommand = new RelayCommand(CreateProductMethod);

			if (IsInDesignMode)
			{
				
			}
			else
			{

			}
		}

		public ICommand StartCastCommand { get; }
		public ICommand PauseCastCommand { get; }
		public ICommand StopCastCommand { get; }
		public ICommand CreateProductCommand { get; }

		public ObservableCollection<Product> Products => _products;
		public ObservableCollection<Cast> Casts => _casts;

		private void StartCastMethod()
		{
			Messenger.Default.Send(new NotificationMessage("Start Cast"));
		}

		private void PauseCastMethod()
		{
			Messenger.Default.Send(new NotificationMessage("Pause Cast"));
		}

		private void StopCastMethod()
		{
			Messenger.Default.Send(new NotificationMessage("Stop Cast"));
		}

		private void CreateProductMethod()
		{
			Messenger.Default.Send(new NotificationMessage("Billetta creata"));
		}
	}
}