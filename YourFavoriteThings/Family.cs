using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class Family
    {
        public string Name { get; set; }
        public int FamilySize { get; set; }

        public Family(string name, int familySize)
        {
            Name = name;
            FamilySize = familySize;
        }

        public void Laugh()
        {
            Console.WriteLine($"My last name is {Name} and I have {FamilySize} members within my immediate family. We love to laugh together.");
        }

        public void Love()
        {
            Console.WriteLine($"The {Name} family has been blessed with another addition, which will make {FamilySize} total.");
        }
    }
}
