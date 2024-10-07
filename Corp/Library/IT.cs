using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Library
{
    public class IT : Sobe
    {
        public int Sode_ID;
        public string Sobe_Name;
        public int TaskCount;
        public IT() { TaskCount = 1; }
        public IT(int _id, string _name)
        {
            Sode_ID = _id;
            Sobe_Name = _name;
        }

        public override double Maas(double maas)
        {
            if (TaskCount>0 && TaskCount < 2) { return maas + maas * 0.05; }
            if (TaskCount > 2 && TaskCount < 5) { return maas + maas * 0.5; }
            if (TaskCount > 5 && TaskCount < 10) { return maas + maas * 1.2; }
            if (TaskCount > 10) { return maas + maas * 2; }
            else{return maas;}
        }

        public override int Mezuniyyet_Elave(int mezuniyyet)
        {
            return TaskCount / 3 * mezuniyyet+5; // bes gunde umumi elavesi var.
        }

        public override double Mukafat(double mukafat)
        {
            return TaskCount * mukafat; //her taska gore mukafati var
        }
        public void Print()
        {
            Console.WriteLine("Informasiya Texnologiyalari uzre mutexessis");
        }
        public override string[] Elave()
        {
            return new string[] {$"{TaskCount*30}  AZN sigorta pulu",$"{30*3*2.50} AZN Yemek pulu", $"{30*1.20} AZN Yol pulu",$"{12*120} AZN Tekmillesdirme pulu"};
        }
    }
}
