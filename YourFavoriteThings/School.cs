using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings
{
    class School
    {
        public string JavaScript { get; set; }
        public string CSharp { get; set; }
        public bool isChallenging { get; set; }

        public School(string javaScript, string cSharp)
        {
            JavaScript = javaScript;
            CSharp = cSharp;
        }

        public void NightClass()
        {
            Console.WriteLine($"We learn {JavaScript} and {CSharp} during the time during the course of the program.");
        }
    }
}
