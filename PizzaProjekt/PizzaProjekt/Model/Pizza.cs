using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProjekt.Model
{
    public enum PizzaMeret { KIS, KOZEPES, NAGY }
    public class Pizza
    {
        
        private PizzaMeret _meret;
        private bool _ontet;
        private bool _sonka, _kolbasz, _sajt;
        private int _db;
        public bool Ontet { get
            {
                return _ontet;
            } set {

                _ontet = value;
            }
            
            }

        public bool Sonka { get
            {
                return _sonka;
            } set {

                _sonka = value;
            }
            
            }

        public bool Kolbasz { get
            {
                return _kolbasz;
            } set {

                _kolbasz = value;
            }
            
            }

        public bool Sajt { get
            {
                return _sajt;
            } set {

                _sajt = value;
            }
            
            }

        public PizzaMeret Meret
        {
            get
            {
                return _meret;
            }
            set
            {
                _meret = value;
            }
        }

        List<string> _fogyasztasHelye = new List<string> { "helyben", "elvitelre", "kiszállítva" };

        public List<string> FogyasztasHelye
        {
            get
            {
                return _fogyasztasHelye;
            }
        }
             
        private string _kivalasztottFogyasztasiHely = string.Empty;


        public string KivalasztottFogyasztasiHely
        {
            get
            {
                return _kivalasztottFogyasztasiHely;
            }
            set
            {
                _kivalasztottFogyasztasiHely = value;
            }
        }
        public Pizza()
        {
            _meret = PizzaMeret.KIS;
            _ontet = false;
            _sonka = false;
            _kolbasz = false;
            _sajt = false;
            _db = 1;
            _kivalasztottFogyasztasiHely = "helyben";
        }


        public int Db
        {
            get
            {
                return _db;
            }
            set
            {
                _db = value;
            }
        }
        public int Ar
        {
            get
            {
                int ar = 0;

                switch (_meret)
                {
                    case PizzaMeret.KIS:
                        ar += 300;
                        break;
                    case PizzaMeret.KOZEPES:
                        ar += 400;
                        break;
                    case PizzaMeret.NAGY:
                        ar += 500;
                        break;
                }

                if (Sonka)
                {
                    ar += 100;
                }

                if (Ontet)
                {
                    ar += 100;
                }
                if (Sajt)
                {
                    ar += 100;
                }
                if (Kolbasz)
                {
                    ar += 100;
                }

                if (KivalasztottFogyasztasiHely == "elvitelre") ar += 100;
                if (KivalasztottFogyasztasiHely == "kiszállítva") ar += 300;
                return ar*Db;
            }
        }
    }
}
