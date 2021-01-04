using System.Collections.Generic;
using GalaSoft.MvvmLight;

namespace Simulatore_Danieli.Models
{
    public class Product : ObservableObject
    {

	    private int _code; // TODO: UUID or Incremental

        private long _startProduction;
        private long _endProduction;

        private int _length;
        private int _weight;

        private int _section; // TODO: Verify types

        private IList<Cast> _casts;

        public int Code
        {
            get => _code;
            set => Set<int>(() => this._code, ref _code, value);
        }

        public long StartProduction
        {
            get => _startProduction;
            set => Set(() => this._startProduction, ref _startProduction, value);
        }

        public long EndProduction
        {
            get => _endProduction;
            set => Set(() => this._endProduction, ref _endProduction, value);
        }

        public int Length
        {
            get => _length;
            set => Set(() => this._length, ref _length, value);
        }

        public int Weight
        {
            get => _weight;
            set => Set(() => this._weight, ref _weight, value);
        }

        public int Section
        {
            get => _section;
            set => Set(() => this._section, ref _section, value);
        }

        public IList<Cast> Casts
        {
	        get => _casts;
	        set => Set(() => this._casts, ref _casts, value);
        }

    }
}