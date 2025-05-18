using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Fabricant { 

        public string IdFabricant { get; set; }
        public string NomEntreprise { get; set; }

        public string Marque { get; set; }
    
        public Fabricant(string IdFabricant, string NomEntreprise,string Marque) {
            this.IdFabricant = IdFabricant;
            this.NomEntreprise = NomEntreprise;
            this.Marque = Marque;
        }


        //getters
        
        public string GetIdFabricant()
        {
            return IdFabricant;
        }

        public string GetNomEntreprise()
        {
            return NomEntreprise;
        }

        public string GetMarque()
        {
            return Marque;
        }

        //setters

        public string SetIdFabricant()
        {
            return this.IdFabricant = IdFabricant;
        }

        public string SetNomEntreprise()
        {
            return this.NomEntreprise = NomEntreprise;
        }

        public string SetMarque()
        {
            return this.Marque = Marque;
        }

        public override string ToString()
        {
            return NomEntreprise;
        }
    }
}
