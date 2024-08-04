// This program will start from the guided project.
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata;


//Culture information.
CultureInfo.CurrentCulture = new CultureInfo("en-US");
// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];


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
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation)) // returns true if there's a number.
    {
        decimalDonation = 45.00m;
    }
    ourAnimals[i, 6] = $"Suggested donation: {decimalDonation:C2}"; //C2 refers to money notation. C = local money; 2 = decimal positions used.
}

// display the top-level menu options
do
{
    //Console.Clear();

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
                        for (int j = 0; j < 7; j++)
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

                string anotherPet = "y";
                int petCount = 0;
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        petCount += 1;
                    }
                }

                if(petCount < maxPets)
                {
                    Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
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
                
                //Animal age.
                // get the pet's age. Can be ? at initial  entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the per's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                            validEntry = int.TryParse(animalAge, out petAge);
                        else
                            validEntry = true;
                    }
                } while (validEntry == false);

                // Animal description.
                // get a description of the per's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken).");
                    readResult =  Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                            animalPhysicalDescription = "tbd";
                    }
                } while(animalPhysicalDescription == "");

                // Animal personality.
                // get a description of the pet's personality - animaPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level).");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // Animal nickname 
                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet:");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // Now all the input data will be loaded in the first layer of the array.
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

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

                break;

            case "3":
                // Ensure animal ages and physical descriptions are complete.
                for (int i = 0; i < ourAnimals.GetLength(0); i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {

                        if (ourAnimals[i, 2] == "Age: " || ourAnimals[i, 2] == "Age: ?")
                        {
                            Console.Clear();
                            bool validAgeEntry = false;
                            do
                            {
                                
                                Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                                readResult = Console.ReadLine();
                                if (readResult != null) //Compruebo que el valor ingresado no sea un valor nulo.
                                {
                                    // Asigno la variable a la matriz correspondiente.
                                    //ourAnimals[i, 2] = "Age: " + petAge;
                                    validAgeEntry = int.TryParse(readResult, out int petAge); // Si no es un string que pueda pasar a un número entero valido devuelve "false".
                                }

                            } while (validAgeEntry == false);
                        }
                        if (ourAnimals[i, 4] == "Physical description: " || ourAnimals[i, 4] == "Physical description: tbd")
                        {
                            Console.Clear();
                            bool validPhysicalEntry = false;    
                            do
                            {
                                Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)");
                                readResult = Console.ReadLine();
                                if (readResult != null && readResult != "")
                                {   
                                    // Asigno el valor de la varable al lugar de la matris correspondiente.
                                    //ourAnimals[i, 4] = "Physical description: " + readResult;
                                    validPhysicalEntry = true;
                                 }
                            } while (validPhysicalEntry == false);
                        }
                    }
                }
                //Console.WriteLine($"The pet wiht {ourAnimals[i, 0]} have age and physical description to be completed. ");
                // Console.WriteLine("Challenge Project - please check back soon to see progress.");
                Console.Clear();
                Console.WriteLine("Age and physical description fields are complete for all of our friends.");
                Console.WriteLine("Press the Enter key to continue.");
                Console.ReadLine();
                break;
            
            case "4":
                // Ensure animal nicknames and personality descriptions are complete.
                for (int i = 0; i < ourAnimals.GetLength(0); i++)
                {
                    if (ourAnimals[i, 0] != "ID #: ")
                    {
                        // Busco el comparador de igualdad para saber si es que los valores de las matriz deben cambiarse.
                        if (ourAnimals[i, 3] == "Nickname: " || ourAnimals[i, 3] == "Nickname: tbd")
                        {
                            Console.Clear();
                            bool validNicknameEntry = false;
                            do
                            {
                                Console.WriteLine($"Enter a nickname for {ourAnimals[i,0]}");
                                readResult = Console.ReadLine();
                                if (readResult != null && readResult != "")
                                {
                                    // Asignación de la lectura a la variable correspondiente de la matriz.
                                    //animalNickname = readResult;
                                    //ourAnimals[i, 3] = "Nickname: " + animalNickname;
                                    validNicknameEntry = true;

                                }
                            } while (validNicknameEntry == false);
                        }

                        if (ourAnimals[i, 5] == "Personality: " || ourAnimals[i, 5] == "Personality: tbd")
                        {
                            Console.Clear();
                            bool validPersonalityEntry = false;
                            do
                            {
                                Console.WriteLine($"Enter a personality description for {ourAnimals[i, 5]} (likes, dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();
                                if (readResult != null && readResult != "")
                                {
                                    // Asignación de la lectura a la variable correspondiente de la matriz.
                                    //readResult = animalPersonalityDescription;
                                    //ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                                    validPersonalityEntry = true;
                                }
                            } while (validPersonalityEntry == false);
                        }

                    }
                }
                Console.Clear();
                Console.WriteLine("Nicknames and personality description fields are complete for all of our friends.");
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
                //Console.WriteLine("UNDER CONSTRUCTION - please check back the next month to see progress.");
                //Console.WriteLine("Press the Enter key to continue.");
                //Console.ReadLine();
                Console.Clear();
                string dogCharacteristic = "";
                bool noMatchesDog = true;

                //First read the input for the user search characteristic.
                while (dogCharacteristic == "")
                {
                    Console.WriteLine($"Enter one desire dog characteristic to search for");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        dogCharacteristic = readResult.ToLower().Trim();
                    }
                }
                for (int i = 0; i < ourAnimals.GetLength(0); i++)
                {
                    if (ourAnimals[i, 1].Contains("dog"))
                    {
                        string dogDescription = "";
                        dogDescription = ourAnimals[i,4] + "\n" + ourAnimals[i, 5];

                        if (dogDescription.Contains(dogCharacteristic))
                        {
                            Console.WriteLine($"\nOur dog {ourAnimals[i,3]} is a match!");
                            Console.WriteLine(dogDescription);
                            noMatchesDog = false;
                        }
                    }
                }
                if (noMatchesDog)
                {
                    Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
                }

                Console.WriteLine("\nPress the Enter key to continue.");
                readResult = Console.ReadLine();
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