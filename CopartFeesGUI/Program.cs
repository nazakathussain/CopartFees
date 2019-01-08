using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopartFeesGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static double BuyingFees(double bid)
        {
            if (bid <= 87.99) { return 25; }
            else if ((88 > 0) && (bid < 175.99)) { return 47; }
            else if ((176 > 0) && (bid < 263.99)) { return 51; }
            else if ((264 > 0) && (bid < 351.99)) { return 53; }
            else if ((352 > 0) && (bid < 439.99)) { return 57; }
            else if ((440 > 0) && (bid < 615.99)) { return 65; }
            else if ((616 > 0) && (bid < 791.99)) { return 71; }
            else if ((792 > 0) && (bid < 967.99)) { return 78; }
            else if ((968 > 0) && (bid < 1143.99)) { return 91; }
            else if ((1144 > 0) && (bid < 1319.99)) { return 103; }
            else if ((1320 > 0) && (bid < 1495.99)) { return 115; }
            else if ((1496 > 0) && (bid < 1759.99)) { return 139; }
            else if ((1760 > 0) && (bid < 2219.99)) { return 173; }
            else if ((2200 > 0) && (bid < 2639.99)) { return 199; }
            else if ((2640 > 0) && (bid < 3219.99)) { return 247; }
            else if ((3220 > 0) && (bid < 3759.99)) { return 308; }
            else if ((3760 > 0) && (bid < 4399.99)) { return 322; }
            else if ((4400 > 0) && (bid < 5239.99)) { return 388; }
            else if ((5240 > 0) && (bid < 5239.99)) { return 459; }
            else if ((6080 > 0) && (bid < 9491.99)) { return 488; }
            else if ((9492 > 0) && (bid < 11999.99)) { return 507; }
            else
            {
                double largebid = bid * 0.05;
                if (largebid > 1500) { return 1500; }
                else { return largebid; }
            }
        }
        public static double transportcost(string location)
        {

            if (location == "Belfast") { return 450; }
            else if (location == "Bristol") { return 130; }
            else if (location == "Chester") { return 130; }
            else if (location == "Colchester") { return 200; }
            else if (location == "Newbury") { return 140; }
            else if (location == "Peterlee") { return 220; }
            else if (location == "Rochford") { return 190; }
            else if (location == "Sandtoft") { return 130; }
            else if (location == "Sandwich") { return 295; }
            else if (location == "Sandy") { return 132; }
            else if (location == "Westbury") { return 183; }
            else if (location == "Whitburn") { return 447; }
            else if (location == "Wisbech") { return 156; }
            else if (location == "Wolverhampton") { return 50; }
            else if (location == "York") { return 198; }
            else if (location == "Castledermot") { return 500; }
            else { return 99999; }
        }
    }
}

