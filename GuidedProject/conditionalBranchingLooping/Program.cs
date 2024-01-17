﻿// the ourAnimals array will store the following: 
using System.Globalization;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        switch (menuSelection)
        {
            //The difference between both Switch-Case instructions is that the type of the variable.
            case "1":
                // list al of our current pet information.
                /*
                In a multidimensional array (2D - bidimensional array) the property "GetLenght()"
                will return an integer that's inidicate the lenght of the array. If there's added
                a 0 in the property (".GetLenght(0)") the integer returned identificates how many
                ROWS are in the array. If the same property presents a 1 instead a 0 the the returned
                integer will represent thew COLUMNS of the array. 

                To get all the items inside a multidimensional array is necessary loop within all 
                the dimensions of itself. In this case i will use two For Loops to iterate in rows
                and columns.
                */
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.WriteLine(ourAnimals[i,j]);
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;

            case "2":
                // Add new animal friend to the our Animal array.
<<<<<<< HEAD
                string anotherPet = "y";
                int petCount = 0;
=======

                string anotherPet = "y";
                int petCount = 0;

>>>>>>> dd8a3eeb3b9a5760cb5b766e2766e2cbeffbfc9e
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        petCount += 1;
<<<<<<< HEAD
                        
                    }
                }
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
=======
                    }
                }

                if(petCount < maxPets)
                {
                    Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more-");
                }
               
                bool validEntry = false;
                // Animal species entry.
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies == "dog" || animalSpecies == "cat")
                            validEntry = true;
                    }
                } while (validEntry == false);
                
                //Animal ID
                animalID = animalSpecies.Substring(0,1) + (petCount +1).ToString();
                
                while (anotherPet == "y" && petCount < maxPets)
                {
                    petCount = petCount +1;
                    if (petCount < maxPets)
                    {
                        //another pet?
                        Console.WriteLine("Do you want to enter info for another pet (y/n)");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                anotherPet = readResult.ToLower();
                            }
                        } while (anotherPet != "y" && anotherPet != "n");
                    }
                }

                if (petCount >= maxPets)
                {
                    Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();
                }

>>>>>>> dd8a3eeb3b9a5760cb5b766e2766e2cbeffbfc9e
                break;

            case "3":
                // Ensure animal ages and physical descriptions are complete.
                Console.WriteLine("Challenge Project - please check back soon to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;

            case "4":
                // Ensure animal nicknames and personality descriptions are complete.
                Console.WriteLine("Challenge Project - please check back soon to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;

            case "5":
                // Edit an animal’s age.
                Console.WriteLine("UNDER CONSTRUCTION - please check back the next month to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;

            case "6":
                // Edit an animal’s personality description.
                Console.WriteLine("UNDER CONSTRUCTION - please check back the next month to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;

            case "7":
                // Display all cats with a specified characteristic
                Console.WriteLine("UNDER CONSTRUCTION - please check back the next month to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;

            case "8":
                // Display all dogs with a specified characteristic.
                Console.WriteLine("UNDER CONSTRUCTION - please check back the next month to see progress.");
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;

            case "exit":
                menuSelection = "exit";
                continue;

            default:
                menuSelection = "No option selected.";
                break;
        }
    }
/*
    Console.WriteLine($"You selected menu option: {menuSelection}");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine();
*/
} while (menuSelection != "exit");