using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pays
    {
        public string IdPays { get; set; }
        public float taux { get; set; }


        public Pays(string id, float taux)
        {
            IdPays = id;
            this.taux = taux;
        }



        //getters

        public string GetIdPays()
        {
            return IdPays;
        }

        public float GetTaux()
        {
            return taux;
        }

        
        //setters

        public string SetIdPays()
        {
            return this.IdPays = IdPays;
        }

        public float SetTaux()
        {
            return this.taux = taux;
        }


    }
}
