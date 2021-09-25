using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;
namespace Business
{
    public class BPersona
    {
      public  List<Persona> GetPersonas(Persona persona)
        {
            DPersona dPersona = new DPersona();
            return dPersona.GetPersonas(persona);
        }

        public void InsPersona (Persona persona)
        {
            DPersona dPersona = new DPersona();
            dPersona.InsPersona(persona);

        }


    }
}
