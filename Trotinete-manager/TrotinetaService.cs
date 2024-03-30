using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trotinete_manager
{
    public class TrotinetaService
    {
        private List <Trotineta> _Trotinetes;

        public TrotinetaService()
        {
            _Trotinetes = new List<Trotineta>();
            this.LoadData();
        }

        public void LoadData()
        {
            Trotineta trotineta1 = new Trotineta(1,200,300,true);
            Trotineta trotineta2 = new Trotineta(2,350,300, true);
            Trotineta trotineta3 = new Trotineta(3,250,300, true);
            Trotineta trotineta4 = new Trotineta(4,50,250, false);
            Trotineta trotineta5 = new Trotineta(5,150,500, true);

            this._Trotinetes.Add(trotineta1);
            this._Trotinetes.Add(trotineta2);
            this._Trotinetes.Add(trotineta3);
            this._Trotinetes.Add(trotineta4);
            this._Trotinetes.Add(trotineta5);
        }

        public void AfisareBooks()
        {
            foreach (Trotineta x in _Trotinetes)
            {
                Console.WriteLine(x.TrotinetaInfo());
            }
        }
    }
}
