using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Unite
    {
        public string CodeUnite { get; set; }
        public string Libelle { get; set; }


        public Unite(string codeUnite, string libelle)
        {
            CodeUnite = codeUnite;
            Libelle = libelle;
        }
    }
}