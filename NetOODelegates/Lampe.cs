using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOODelegates
{
    public class Lampe
    {

        public Lampe(string name)
        {
            Name = name;
        }

        public Lampe(string name, Interrupteur interrupteur, Modes mode) : this(name)
        {

            interrupteur.Ajouter(this, mode);

        }

        public string Name { get; set; }

        public void Allumer()
        {
            Console.WriteLine($"{Name} est allumée.");
        }

        public void Eteindre()
        {
            Console.WriteLine($"{Name} est eteinte.");
        }

        public void Clignotte()
        {
            Console.WriteLine($"{Name} Clignotte.");
        }

    }
}
