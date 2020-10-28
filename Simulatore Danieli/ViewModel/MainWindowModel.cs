

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Simulatore_Danieli.Models;

namespace Simulatore_Danieli.ViewModels
{
    class MainWindowModel : ViewModelBase
    {
	    private ObservableCollection<Product> products;

	    public MainWindowModel()
	    {
		    StartProductionCommand = new RelayCommand(StartProductionMethod);
		    PauseProductionCommand = new RelayCommand(PauseProductionMethod);
		    StopProductionCommand = new RelayCommand(StopProductionMethod);
		}

		public ICommand StartProductionCommand { get; private set; }
		public ICommand PauseProductionCommand { get; private set; }
		public ICommand StopProductionCommand { get; private set; }


		public ObservableCollection<Product> Products
	    {
		    get
		    {
			    return products;
		    }
	    }


	    private void StartProductionMethod()
	    {
		    Messenger.Default.Send<NotificationMessage>(new NotificationMessage("Start Prod"));
	    }

	    private void PauseProductionMethod()
	    {
		    Messenger.Default.Send<NotificationMessage>(new NotificationMessage("Pause Prod"));
	    }

	    private void StopProductionMethod()
	    {
		    Messenger.Default.Send<NotificationMessage>(new NotificationMessage("Stop Prod"));
	    }
    }
}
