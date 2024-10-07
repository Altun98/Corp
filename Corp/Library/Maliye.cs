using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Corp.Library
{
    public class Maliye : Sobe
    {
        public int Sode_ID;
        public string Sobe_Name;
        public int HesabatCount;
        public Maliye()
        {
            HesabatCount = 1;
        }
        public Maliye(int _id, string _name)
        {
            Sode_ID = _id;
            Sobe_Name = _name;
        }
        public override double Maas(double maas)
        {
            if (HesabatCount > 5 && HesabatCount < 10)
            {
                return maas + maas * 0.25;
            }
            if (HesabatCount > 10)
            {
                return maas + maas * 0.5;
            }
            else
            {
                return maas + maas * 0.05;
            }
        }

        public override int Mezuniyyet_Elave(int mezuniyyet)
        {
            return HesabatCount / 2 * mezuniyyet;
        }

        public override double Mukafat(double mukafat = 0)
        {
            if (HesabatCount > 5)
            {
                return mukafat + HesabatCount * mukafat * 0.3;
            }
            else
            {
                return 0;
            }
        }
        public void Print()
        {
            Console.WriteLine("Maliyye uzre mutexessis");
        }
        public override string[] Elave()
        {
            return new string[] {$"{HesabatCount*10} AZN Siqorta pulu",$"{30*(HesabatCount/2)} AZN Yemek Pulu"};
        }
    }
}
