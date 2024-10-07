using Corp.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp
{
    public class IsciMaliyye
    {
        public string Name;
        public string SureName;
        public double Maas;
        public double Mukafat = 0;
        public int Ezamiyyet;
        public double HesabatSum;
        public Maliye MaliyeEmp;
        public IsciMaliyye()
        {

        }
        public IsciMaliyye(string _name, string _surname, double _maas, Maliye _maliye, double _mukafat = 0, int _ezam = 0, double _hesabatSum = 0)
        {
            Name = _name;
            SureName = _surname;
            Maas = _maas;
            MaliyeEmp = _maliye;
            Mukafat = _mukafat;
            Ezamiyyet = _ezam;
            HesabatSum = _hesabatSum;
        }
        public double GetGelir()
        {
            #region Gelirin hesabatin hecmine gore hesablanmasi
            if (HesabatSum > 120000 && HesabatSum < 500000)
            {
                return MaliyeEmp.Maas(Maas) + MaliyeEmp.Mukafat(Mukafat)+100;
            }
            if (HesabatSum >500000 && HesabatSum < 1000000)
            {
                return MaliyeEmp.Maas(Maas) + MaliyeEmp.Mukafat(Mukafat) + 200;
            }
            if(HesabatSum >1000000 && HesabatSum < 10000000)
            {
                return MaliyeEmp.Maas(Maas) + MaliyeEmp.Mukafat(Mukafat) + 300;
            }
            if (HesabatSum > 10000000)
            {
                return MaliyeEmp.Maas(Maas) + MaliyeEmp.Mukafat(Mukafat) + 500;
            }
            else
            {
                return MaliyeEmp.Maas(Maas) + MaliyeEmp.Mukafat(Mukafat) * 0.02;
            }
            #endregion
        }
        public double GunlukMaas()
        {
            return Maas / 30;
        }
        public double GetEzamiyyet(double _ezamiyyet)
        {
            return GunlukMaas() * _ezamiyyet *0.5;
        }
        public double GetMezuniyyetGelir()
        {
            return (double)(MaliyeEmp.Mezuniyyet_Elave(MaliyeEmp.HesabatCount) * GunlukMaas());

        }

        public void Print()
        {
            Console.WriteLine($"Ishci Ad ={Name} Soyad ={SureName} Maas = {Maas} Gelir={GetGelir():0.00} " +
                $"Elave mezuniyyet = {MaliyeEmp.Mezuniyyet_Elave(MaliyeEmp.HesabatCount)} gunu istirahet ede biler ve ya\n" +
                $"{GetMezuniyyetGelir():0.00} AZN odeniz ala biler");

            MaliyeEmp.Print();
            string[] hrE = MaliyeEmp.Elave();
            for (int i = 0; i < hrE.Length; i++)
            {
                Console.Write(hrE[i] + ", ");
            }
        }
    }
}
