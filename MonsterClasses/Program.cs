using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 34,
                Name = "Jeff",
                Age = 421, 
                HasGills =true,
                HomeSea = "The Dead Sea"
            };
        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 43, 
                Name = "Steve",
                Galaxy ="Andromeda",
                Age = 1325
            };
        }

        static DesertMonster InitializeDesertMonster()
        {
            return new DesertMonster()
            {
                Id = 447,
                Name = "Tim",
                Age = 48,
                Limbs = 8,
                ColdBlood=true,
                HomeDesert="Sahara"
            };
        }

        private static void DisplayMenu()
        {
            bool exitMenu = false;
            int menuSelection;
            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;
            DesertMonster myDesertMonster;

            mySeaMonster = InitializeSeaMonster();
            mySpaceMonster = InitializeSpaceMonster();
            myDesertMonster = InitializeDesertMonster();
            

            do
            {
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Edit A Monster");
                Console.WriteLine("3) Exit");
                Console.WriteLine("Enter Selection:");
                menuSelection = int.Parse(Console.ReadLine());

                switch (menuSelection)
                {
                    case 1:
                        DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster, myDesertMonster);
                        break;
                    case 3:
                        exitMenu = true;
                        break;
                    case 2:
                        DisplayEditMonster(mySeaMonster, mySpaceMonster, myDesertMonster);
                        break;
                    default:
                        Console.WriteLine("Please Enter a Proper Selection");
                        Console.ReadKey();
                        break;
                }

            } while (!exitMenu);
        }

        private static void DisplayEditMonster(SeaMonster mySeaMonster, SpaceMonster mySpaceMonster, DesertMonster myDesertMonster)
        {
            string menuSelection;
            bool exitMenu = false;

            do
            {
                DisplayHeader("Edit your Monster");

                Console.WriteLine("Please Select A Monster to edit");
                Console.WriteLine($"A) {mySeaMonster.Name}");
                Console.WriteLine($"B) {mySpaceMonster.Name}");
                Console.WriteLine($"C) {myDesertMonster.Name}");
                Console.WriteLine("D) Return to Main Menu");
                menuSelection = Console.ReadLine().ToUpper();
                switch (menuSelection)
                {
                    case "A":
                        EditSeaMonster(mySeaMonster);
                        break;
                    case "B":
                        EditSpaceMonster(mySpaceMonster);
                        break;
                    case "C":
                        EditDesertMonster(myDesertMonster);
                        break;
                    case "D":
                        exitMenu = true;
                        break;
                    default:
                        break;
                }
            } while (!exitMenu);
        }

        private static void EditDesertMonster(DesertMonster myDesertMonster)
        {
            DisplayHeader("Edit Your Desert Monster");

            Console.WriteLine("What would you like to change the desert monster's name to?");
            myDesertMonster.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the new ID for the Desert Monster?");
            myDesertMonster.Id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is their new age?");
            myDesertMonster.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How many limbs does this monster now have?");
            myDesertMonster.Limbs = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is its new home desert?");
            myDesertMonster.HomeDesert = Console.ReadLine();
        }

        private static void EditSpaceMonster(SpaceMonster mySpaceMonster)
        {
            DisplayHeader("Edit Your Space Monster");

            Console.WriteLine("What name would you like to change your space monster to?");
            mySpaceMonster.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the new ID for this Monster?");
            mySpaceMonster.Id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is their new age?");
            mySpaceMonster.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is their new home galaxy?");
            mySpaceMonster.Galaxy = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Press any Key to return to the previous menu.");
            Console.ReadKey();
        }

        private static void EditSeaMonster(SeaMonster mySeaMonster)
        {
            DisplayHeader("Edit your Sea Monster");

            Console.WriteLine("What name would you like to change the Sea Monster to?");
            mySeaMonster.Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What is the ID number for this Monster?");
            mySeaMonster.Id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is their new age?");
            mySeaMonster.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is their new home sea?");
            mySeaMonster.HomeSea = Console.ReadLine();

            Console.WriteLine("Press any Key to return to the previous menu.");
            Console.ReadKey();
        }

        private static void DisplayMonsterInfoScreen(SeaMonster seasMonster, SpaceMonster spaceMonster, DesertMonster myDesertMonster)
        {
            DisplayHeader("Monster Info");

            Console.WriteLine("Sea Monster");
            DisplaySeaMonsterInfo(seasMonster);

            Console.WriteLine();
            Console.WriteLine("Space Monster");
            DisplaySpaceMonster(spaceMonster);

            Console.WriteLine();
            Console.WriteLine("Desert Monster");
            DisplayDesertMonster(myDesertMonster);

            Console.ReadKey();
        }

        private static void DisplayDesertMonster(DesertMonster myDesertMonster)
        {
            Console.WriteLine($"Id: {myDesertMonster.Id}");
            Console.WriteLine($"Name: {myDesertMonster.Name}");
            Console.WriteLine($"Age: {myDesertMonster.Age}");
            Console.WriteLine($"Limbs: {myDesertMonster.Limbs}");
            Console.WriteLine($"Cold Blooded: {myDesertMonster.ColdBlood}");
            Console.WriteLine($"Home Desert: {myDesertMonster.HomeDesert}");
            Console.WriteLine($"You Attacked {myDesertMonster.Name} and they {myDesertMonster.MonsterBattleResponse()} in response");
        }

        private static void DisplaySpaceMonster(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Is Happy: {spaceMonster.IsHappy()}");

            Console.WriteLine($"You Attacked {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()} in response");

        }

        private static void DisplaySeaMonsterInfo(SeaMonster seasMonster)
        {
            Console.WriteLine($"Id: {seasMonster.Id}");
            Console.WriteLine($"Name: {seasMonster.Name}");
            Console.WriteLine($"Age: {seasMonster.Age}");
            Console.WriteLine($"Gills: {seasMonster.HasGills}");
            Console.WriteLine($"Home Sea: {seasMonster.HomeSea}");
            Console.WriteLine($"Is Happy: {seasMonster.IsHappy()}");
            Console.WriteLine($"You Attacked {seasMonster.Name} and they {seasMonster.MonsterBattleResponse()} in response");


        }
        #region HELPER METHODS
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my app");
            Console.ReadKey();
        }
        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"App: {headerText}");
            Console.WriteLine();
        }
        static void DisplayWelcomeScreen()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tWelcome!");
            Console.ReadKey();




            DisplayContinuePrompt();

        }
        static void DisplayContinuePrompt()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        #endregion
    }
}
