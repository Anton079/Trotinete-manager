using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trotinete_manager
{
    public class Inchiriere
    {
        private int _id;
        private int _idUser;
        private int _idTrotienta;

        public Inchiriere(int id, int idUser, int idTrotineta)
        {
            Id = id;
            IdUser = idUser;
            IdTrotineta = idTrotineta;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public int IdTrotineta
        {
            get { return _idTrotienta; }
            set { _idTrotienta = value; }
        }

        public string InchiriereInfo()
        {
            string text = " ";
            text += "Idul" + Id + "\n";
            text += "Idul User " + IdUser + "\n";
            text += "Id Trotineta" + IdTrotineta + "\n";
            return text;
        }

    }
}
