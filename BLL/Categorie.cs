using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Categorie
    {
        public string CodeCategorie { get; set; }
        public string Libelle { get; set; }

        public Categorie(string code, string libelle)
        {
            CodeCategorie = code;
            Libelle = libelle;
        }
    }
}
