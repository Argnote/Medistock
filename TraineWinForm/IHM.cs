using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineWinForm
{
    public class IHM
    {
        Metier metier;

        public IHM()
        {
            metier = new Metier();
        }
        public Metier get_metier()
        {
            return metier;
        }
    }
}
