using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4

{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Countryside
    {
        Village Alst;
        Village Maeland;
        Village Schenig;

        public void InitializeMap()
        {
            Alst = new Village();
            Alst.VillageName = "Alst"; 
            Maeland = new Village();
            Maeland.VillageName = " Maeland";
            Maeland.isAstrildeHere = true;
            Schenig = new Village();
            Schenig.VillageName = "Schenig";

            Alst.NextVillage = Maeland;
            Maeland.NextVillage = Schenig;
            Schenig.NextVillage = Alst;
        }

        public void WalkAround()
        {
            Village InitialVillage = this.Maeland;
           
            Village CurrentVillage = this.Maeland;
            if {
                Console.WriteLine("Hogi found Astrilde!!! Celebrations! XOXO")
            }
            Village NextVillage;
            NextVillage = CurrentVillage.NextVillage;


        }
    }

    class Village
    {
        public Village PreviousVillage;
        public Village NextVillage;
        public String VillageName;
        public bool isAstrildeHere = false;
        public Village() { }
    }
}