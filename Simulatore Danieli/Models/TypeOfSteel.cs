using GalaSoft.MvvmLight;

namespace Simulatore_Danieli.Models
{
	public class TypeOfSteel : ObservableObject
	{
		private int _code;
		private string _description;
		private bool _isNotProducible;

		public int Code
		{
			get => _code;
			set => Set(() => this._code, ref _code, value);
		}

		public string Description
		{
			get => _description;
			set => Set(() => this._description, ref _description, value);
		}

		public bool IsNotProducible
		{
			get => _isNotProducible;
			set => Set(() => this._isNotProducible, ref _isNotProducible, value);
		}
	}
}