using Corp.Library;

namespace Corp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kredit k1 = new kredit(125, "Kredit_mutexesisi_1");
            k1.Crdt_Count = 345;
            IshciKredit i1 = new IshciKredit("Hesen", "Abbasov", 785, k1);
            i1.Print();          
            Console.WriteLine("----------------------------------------");
            HR h1= new HR(132,"Insan resuslari-1");
            h1.HR_Count = 33;
            IsciHR ih1 = new IsciHR("Abbas", "hesenov", 876, 120, h1);
            ih1.Print();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            IT infT1 = new IT();
            infT1.TaskCount = 12;
            IsciIT infEmp1 = new IsciIT("Cavid", "Camalzade", 1140, 3, infT1, 98);
            infEmp1.Print();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Maliye M1= new Maliye();
            M1.HesabatCount = 3;
            IsciMaliyye empMal1 = new IsciMaliyye("Rza", "Eliyev", 870.34, M1, 100, 3, 456000);
            empMal1.Print();
            Console.ReadKey();
        }
    }
}
