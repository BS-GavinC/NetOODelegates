using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOODelegates
{
    public class Interrupteur
    {


        delegate void interrupt();

        interrupt on = null;

        interrupt off = null;

        public void Allumer()
        {
            on();
        }

        public void Eteindre()
        {
            off();
        }

        public void Ajouter(Lampe lampe, Modes mode)
        {
            switch (mode)
            {
                case Modes.fixe:

                    on += lampe.Allumer;

                    break;
                case Modes.clignotte:

                    on += lampe.Clignotte;

                    break;
            }

            off += lampe.Eteindre;
        }

       

    }
}
