using System;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoopSession1 = new Basketball("Ballers", "Downtown Y");
            hoopSession1.Hoop(4);
            hoopSession1.Losing(2);

            var hoopSession2 = new Basketball("Killers", "Green Hills Y");
            hoopSession2.Hoop(8);
            hoopSession2.Losing(1);

            var family1 = new Family("Tate", 4);
            family1.Laugh();
            family1.Love();

            var family2 = new Family("Tibbs", 2);
            family2.Laugh();
            family2.Love();

            var classSession = new School("JavaScript", "CSharp");
            classSession.NightClass();
        }
    }
}
