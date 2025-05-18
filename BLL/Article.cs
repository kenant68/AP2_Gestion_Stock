using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Article
    {
        public string ReferenceArticle { get; set; }
        public string Libelle { get; set; }




        public Article(string ReferenceArticle, string Libelle)
        {
            this.ReferenceArticle = ReferenceArticle;
            this.Libelle = Libelle;
            
        }

        //getters
        public string getRef() { return ReferenceArticle; }
        public string getLibelle() {  return Libelle; }

        //setters
        public void setId(string ReferenceArticle) { this.ReferenceArticle = ReferenceArticle; }
        public void setLibelle(string Libelle) { this.Libelle = Libelle; }
    }

    
}
