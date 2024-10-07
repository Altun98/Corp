using Corp.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp
{
    public class IsciHR
    {
        public string Name;
        public string SureName;
        public double Maas;
        public double Mukafat = 0;
        public int Ezamiyyet;
        public HR hr;
        public IsciHR(){}
        public IsciHR(string _name, string _surname, double _maas, double _mukafat, HR _hr, int _ezam = 0)
        {
            Name = _name;
            SureName = _surname;
            Maas = _maas;
            Mukafat = _mukafat;
            hr = _hr;
            Ezamiyyet = _ezam;
        }
        public double GetGelir()
        {
            return hr.Maas(Maas) + hr.Mukafat(Mukafat);
        }
        public double GunlukMaas()
        {
            return Maas / 30;
        }
        public double GetEzamiyyet(double _ezamiyyet)
        {
            return GunlukMaas() * _ezamiyyet;
        }
        public double GetMezuniyyetGelir()
        {
            return (double)(hr.Mezuniyyet_Elave(hr.HR_Count) * GunlukMaas());

        }

        public void Print()
        {
            Console.WriteLine($"Ishci Ad ={Name} Soyad ={SureName} Maas = {Maas} Gelir={GetGelir():0.00} " +
                $"Elave mezuniyyet = {hr.Mezuniyyet_Elave(hr.HR_Count)} gunu istirahet ede biler ve ya\n" +
                $"{GetMezuniyyetGelir():0.00} AZN odeniz ala biler");

            hr.Print();
            string[] hrE = hr.Elave();
            for (int i = 0; i < hrE.Length; i++)
            {
                Console.Write(hrE[i] + ", ");
            }
        }
    }
}
