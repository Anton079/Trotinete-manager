using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trotinete_manager
{
    public class Trotineta
    {
        private int _id;
        private int _putere;
        private int _capacitateBaterie;
        private bool _disponibila;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Putere
        {
            get { return _putere; }
            set { _putere = value; }
        }

        public int CapacitateBaterie
        {
            get { return _capacitateBaterie; }
            set { _capacitateBaterie = value; }
        }

        public bool Disponibila
        {
            get { return _disponibila; }
            set { _disponibila = value; }
        }

        public Trotineta(int id, int putere, int capacitateBaterie, bool disponibila)
        {
            Id = id;
            Putere = putere;
            CapacitateBaterie = capacitateBaterie;
            Disponibila = disponibila;
        }

        public string TrotinetaInfo()
        {
            string text = " ";
            text += "Id " + Id + "\n";
            text += "Putere " + Putere + "\n";
            text += "Capacitate " + CapacitateBaterie + "\n";
            text += "Disponibila " + Disponibila + "\n";
            return text;
        }
    }
}
