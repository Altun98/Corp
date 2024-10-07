using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Library
{
    public abstract class Sobe
    {
        public abstract double Maas(double maas);
        public abstract double Mukafat(double mukafat);
        public abstract int Mezuniyyet_Elave(int mezuniyyet);
        public virtual string[] Elave()
        {
            return new string[] { "10 azn sigorta" };
        }
    }
}
