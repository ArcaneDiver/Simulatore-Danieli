using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;

namespace Simulatore_Danieli.Models
{
	public class Cast : ObservableObject
	{
		private int _code;
		private bool _state;
		private int _sort;
		private int _weight;

		private DateTime _start;
		private DateTime _end;

		private IList<TypeOfSteel> _steels;


		public int Code
		{
			get => _code;
			set => Set(() => this._code, ref _code, value);
		}

		public bool State
		{
			get => _state;
			set => Set(() => this._state, ref _state, value);
		}

		public int Sort
		{
			get => _sort;
			set => Set(() => this._sort, ref _sort, value);
		}

		public int Weight
		{
			get => _weight;
			set => Set(() => this._weight, ref _weight, value);
		}

		public DateTime Start
		{
			get => _start;
			set => Set(() => this._start, ref _start, value);
		}

		public DateTime End
		{
			get => _end;
			set => Set(() => this._end, ref _end, value);
		}

		public IList<TypeOfSteel> Steels
		{
			get => _steels;
			set => Set(() => this._steels, ref _steels, value);
		}
	}
}