using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ArticleAffichage
    {
        public string ReferenceArticle { get; set; }
        public string Libelle { get; set; }
        public string Categorie { get; set; }
        public string Fabricant { get; set; }
        public string Unite { get; set; }

        public string Depot { get; set; }








        public ArticleAffichage(string referenceArticle, string libelle, string categorie, string fabricant, string unite)//,string depot)
        {
            ReferenceArticle = referenceArticle;
            Libelle = libelle;
            Categorie = categorie;
            Fabricant = fabricant;
            Unite = unite;


            //Depot = depot;
        }
    }

}
