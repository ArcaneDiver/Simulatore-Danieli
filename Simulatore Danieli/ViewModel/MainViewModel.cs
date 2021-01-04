using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using RestSharp;
using Simulatore_Danieli.Models;
using Simulatore_Danieli.Services;

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
			StartCastCommand = new RelayCommand(StartCastMethod);
			PauseCastCommand = new RelayCommand(PauseCastMethod);
			StopCastCommand = new RelayCommand(StopCastMethod);
			CreateProductCommand = new RelayCommand(CreateProductMethod);

			RetrieveProducts();
		}

		public ICommand StartCastCommand { get; }
		public ICommand PauseCastCommand { get; }
		public ICommand StopCastCommand { get; }
		public ICommand CreateProductCommand { get; }

		public ObservableCollection<Product> Products => _products;
		public ObservableCollection<Cast> Casts => _casts;

		public IDataService Service => SimpleIoc.Default.GetInstance<IDataService>();

		private void StartCastMethod()
		{
			Service.StartProduction(1);
		}

		private void PauseCastMethod()
		{
			Service.PauseProduction(1);
		}

		private void StopCastMethod()
		{
			Service.StopProduction(1);
		}

		private void CreateProductMethod()
		{
			Service.ProduceBillet(1);
		}

		private void RetrieveProducts()
		{
			IList<Cast> casts = Service.GetCasts();
			_casts = new ObservableCollection<Cast>(casts);
		}
	}
}