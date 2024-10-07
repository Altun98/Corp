using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Library
{
    public class HR : Sobe
    {
        public int Sobe_ID;
        public string Sobe_Name;
        public int HR_Count;
        public HR()
        {
            // ise qebul ucun namizedlerle gorusun sayi=1
            HR_Count = 1;
        }
        public HR(int _sobeID, string _sobeName)
        {
            Sobe_ID = _sobeID;
            Sobe_Name = _sobeName;
        }
        public override double Maas(double maas)
        {
            if (HR_Count < 10) { return maas; }
            if (HR_Count > 10 && HR_Count <= 30) { return maas + maas * HR_Count * 0.003; };
            if (HR_Count > 30) { return maas + maas * HR_Count * 0.03; }
            else
            {
                return 0;
            };

        }

        public override int Mezuniyyet_Elave(int mezuniyyet)
        {
            return HR_Count / 5;
        }

        public override double Mukafat(double mukafat)
        {
            if (HR_Count > 30)
            {
                return mukafat * HR_Count * 0.05;
            }
            else
            {
                return mukafat * HR_Count * 0.005;
            }
        }
        public override string[] Elave()
        {
            return new string[] { $"{HR_Count * 0.6} azn sigorta", $"{HR_Count / 3 * 30} AZN yemek pulu", $"{(HR_Count * 30) / 2} AZN Yol pulu" };
        }
        public void Print()
        {
            Console.WriteLine("Insan resuslari uzre mutexesis");
        }
    }
}
