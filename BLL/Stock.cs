using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Stock
    {
        public string ReferenceArticle { get; set; }
        public int NumeroDepot { get; set; }
        public DateTime DateHeureMouvement { get; set; }
        public string Type { get; set; }
        public int Quantite { get; set; }

        public Stock(string referenceArticle, int numeroDepot, DateTime dateHeureMouvement, string type, int quantite)
        {
            ReferenceArticle = referenceArticle;
            NumeroDepot = numeroDepot;
            DateHeureMouvement = dateHeureMouvement;
            Type = type;
            Quantite = quantite;
        }
    }
}
