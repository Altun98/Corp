using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Library
{
    public class kredit:Sobe
    {
        public int Sobe_ID;
        public string Sobe_Name;
        public int Crdt_Count;
        public kredit()
        {
            Crdt_Count = 10;
        }
        public kredit(int _Sobe_ID,string _Sobe_Name)
        {
            Sobe_ID = _Sobe_ID;
            Sobe_Name = _Sobe_Name;
        }
        public override double Maas(double maas)
        {
            return maas + maas * Crdt_Count * 0.003;
        }

        public override double Mukafat(double mukafat)
        {
            return mukafat * 0.001 * Crdt_Count;
        }

        public override int Mezuniyyet_Elave(int mezuniyyet)
        {
            return Crdt_Count / 100;
        }
        public override string[] Elave()
        {
            return new string[] { "10 azn sigorta", $"{Crdt_Count/10} yemek pulu" };
        }

        public void Print() 
        { 
            Console.WriteLine("Kredit mutexessizi");
        }
    }
}
