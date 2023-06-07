using PizzaProjekt.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.BaseClass;

namespace PizzaProjekt.ViewModel
{
    public class PizzaViewModel : ViewModelBase
    {

        PizzaProjekt.Model.Pizza pizza;

        public RelayCommand RendelesCmd { get; private set; }

        public PizzaViewModel()
        {
            pizza = new Model.Pizza();
            RendelesCmd = new RelayCommand(execute => CalculateFt());
        }

        public bool KicsiPizza
        {
            get
            {
                if(pizza.Meret == PizzaMeret.KIS)
                {
                    return true;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    pizza.Meret = PizzaMeret.KIS;

                }
                OnPropertyChanged(nameof(Ar));
            }
        }
        public bool KozepesPizza
        {
            get
            {
                if (pizza.Meret == PizzaMeret.KOZEPES)
                {
                    return true;
                }
                return false;
            }

            set
            {
                if (value)
                {
                    pizza.Meret = PizzaMeret.KOZEPES;
                   
                }
                OnPropertyChanged(nameof(Ar));
            }
        }
        public bool NagyPizza
        {
            get
            {
                if (pizza.Meret == PizzaMeret.NAGY)
                {
                    return true;
                }
                return false;
            }

            set
            {
                if (value)
                {
                    pizza.Meret = PizzaMeret.NAGY;

                }
                OnPropertyChanged(nameof(Ar));
            }
        }

        private void CalculateFt()
        {
            OnPropertyChanged(nameof(Ar));
        }

        public bool Ontet
        {
            get
            {
                return pizza.Ontet;
            }
            set
            {
                pizza.Ontet = value;
                OnPropertyChanged(nameof(Ar));

            }
        }

        public bool Sonka
        {
            get
            {
                return pizza.Sonka;
            }
            set
            {
                pizza.Sonka = value;
                OnPropertyChanged(nameof(Ar));

            }
        }
        public bool Kolbasz
        {
            get
            {
                return pizza.Kolbasz;
            }
            set
            {
                pizza.Kolbasz = value;
                OnPropertyChanged(nameof(Ar));

            }
        }
        public bool Sajt
        {
            get
            {
                return pizza.Sajt;
            }
            set
            {
                pizza.Sajt = value;
                OnPropertyChanged(nameof(Ar));

            }
        }

        public string KivalasztottHely
        {
            get
            {
                return pizza.KivalasztottFogyasztasiHely;
            }
            set
            {
                pizza.KivalasztottFogyasztasiHely = value;
                OnPropertyChanged(nameof(Ar));

            }
        }

        public int Db
        {
            get
            {
                return pizza.Db;
            }
            set
            {
                pizza.Db = value;
                OnPropertyChanged(nameof(Ar));

            }
        }

        public string Ar
        {
            get
            {
                return $"{pizza.Ar} Ft"; 
            }
        }
    }
}
