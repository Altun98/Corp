using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Library;

namespace Corp
{
    public class IshciKredit
    {
        public string Name;
        public string SureName;
        public double Maas;
        public double Mukafat = 0;
        public kredit cred;

        public IshciKredit(){}
        public IshciKredit(string _name, string _surename, double _maas, kredit _cred)
        {
            Name = _name;
            SureName = _surename;
            Maas = _maas;
            cred = _cred;
        }
        public double GetGelir()
        {
            return cred.Maas(Maas) + cred.Mukafat(Mukafat);
        }

        public void Print()
        { 
            Console.WriteLine($"Ishci Ad ={Name} Soyad ={SureName} Maas = {Maas} Gelir={GetGelir():0.00} Elave mezuniyyet = {cred.Mezuniyyet_Elave(cred.Crdt_Count)}");
            cred.Print();
            string[] Elv = cred.Elave();
            for (int i = 0; i < Elv.Length; i++)
            {
                Console.WriteLine(Elv[i]+", "); 
            }
        }
    }
}
