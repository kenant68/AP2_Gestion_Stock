using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Depot
    {
        public int NumeroDepot {  get; set; }
        public string Nom {  get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public Depot (int numeroDepot, string nom, string ville, string pays, float latitude, float longitude)
        {
            NumeroDepot = numeroDepot;
            Nom = nom;
            Ville = ville;
            Pays = pays;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
