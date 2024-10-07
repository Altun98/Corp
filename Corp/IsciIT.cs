using Corp.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp
{
    public class IsciIT
    {
        public string Name;
        public string SureName;
        public double Maas;
        public double Mukafat = 100;//default deyer verib
        public int Ezamiyyet;
        public int ElaveIsSaati;
        public IT iT;
        public IsciIT() { }
        public IsciIT(string _name, string _surname, double _maas, int _ezam,
            IT _iT, int _elaveSaat = 0, double _mukafat = 100)
        {
            Name = _name;
            SureName = _surname;
            Maas = _maas;
            Ezamiyyet = _ezam;
            iT = _iT;
            ElaveIsSaati = _elaveSaat;
            Mukafat = _mukafat;
        }
        public double GunlukMaas()
        {
            return Maas / 30;
        }
        public double GetElaveSaatGelir()
        {
            return GunlukMaas() * (ElaveIsSaati / 24) * 2;
        }
        public double GetGelir()
        {
            return (iT.Maas(Maas) + iT.Mukafat(Mukafat) + GetElaveSaatGelir()) * 1.1;
        }
        public double GetEzamiyyet(double _ezamiyyet)
        {
            return GunlukMaas() * _ezamiyyet;
        }
        public double GetMezuniyyetGelir()
        {
            return (double)((iT.Mezuniyyet_Elave(iT.TaskCount) * GunlukMaas())*1.1);
        }
        public void Print()
        {
            Console.WriteLine($"Ishci Ad ={Name} Soyad ={SureName} Maas = {Maas} Gelir={GetGelir():0.00} " +
              $"Elave mezuniyyet = {iT.Mezuniyyet_Elave(iT.TaskCount)} gunu istirahet ede biler ve ya\n" +
              $"{GetMezuniyyetGelir():0.00} AZN odeniz ala biler");
            iT.Print();
            string[] ItE = iT.Elave();
            for (int i = 0; i < ItE.Length; i++)
            {
                Console.Write(ItE[i] + ", ");
            }
        }
    }
}
