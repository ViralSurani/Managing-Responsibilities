using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyMemeber dad = new FamilyMemeber(new Bearded("Dad", new Emotional("Dad", "hoho")));
            FamilyMemeber mom = new FamilyMemeber(new Hairy("Mom", new Emotional("Mom", "hihi")));
            FamilyMemeber boy = new FamilyMemeber(new Emotional("Boy", "haha"));
            FamilyMemeber dog = new FamilyMemeber(new Emotional("Dog", "tail waiving"));
            FamilyMemeber uncle = new FamilyMemeber(new Bearded("Uncle", new Hairy("Uncle")));
            FamilyMemeber granddad = new FamilyMemeber(new Bearded("Granddad", new Hairy("Granddad", new Emotional("Granddad", "oyoyo"))));

            Family family = new Family(new FamilyMemeber[] { dad, mom, boy, dog, uncle, granddad });
            family.WinterBegins();
            family.SummerComes();
            Console.ReadKey();
        }
    }
}
