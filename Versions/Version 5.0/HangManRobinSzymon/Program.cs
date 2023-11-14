using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace HangManRobinSzymon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //start
            Console.ReadLine();
            //variablen
            string userInput = "0";
            string validLetters = "AÄBCDEFGHIJKLMNOÖPQRSTUÜVWXYZ";
            char userInputChar;
            char checkLetter; 
            bool validInput1 = false;
            bool validInput2 = false;
            int trys = 0;
            bool wordcompletion = false;
            char[] charunterstriche;
            string stringunterstriche = null;

            //word-array
            string[] wordlibrary;
            wordlibrary = new string[20];
            wordlibrary[0] = "MINECRAFT";
            wordlibrary[1] = "COMPUTER";
            wordlibrary[2] = "NINTENDO";
            wordlibrary[3] = "TASTATUR";
            wordlibrary[4] = "KOPFHÖRER";
            wordlibrary[5] = "PLAYSTATION";
            wordlibrary[6] = "XBOX";
            wordlibrary[7] = "PLAYER";
            wordlibrary[8] = "MAUS";
            wordlibrary[9] = "SUPER";
            wordlibrary[10] = "MARIO";
            wordlibrary[11] = "PIKMIN";
            wordlibrary[12] = "YOSHI";
            wordlibrary[13] = "KART";
            wordlibrary[14] = "FLASCHE";
            wordlibrary[15] = "RAYMAN";
            wordlibrary[16] = "FORTNITE";
            wordlibrary[17] = "VISUAL";
            wordlibrary[18] = "STUDIO";
            wordlibrary[19] = "BATTLEPASS";
            
            //wählt ein Wort aus Array
            int wordnumber = NumberGenerator(0, 19);
            Console.WriteLine(wordnumber);

            string word = wordlibrary[wordnumber];
            Console.WriteLine(word);
            
            //Hier wird ein CHAR array erstellt, der gleiche Länge wie "word" hat und ist mit unterstrichen gefüllt
            charunterstriche = new char[word.Length];

            for(int i = 0; i < word.Length; i++)
            {
                charunterstriche[i] = '_';
            }
            Console.WriteLine(charunterstriche);

            //EINGABE PRÜFEN OB ES EINE GÜLTIGE BUCHSTABE IST
            while (wordcompletion == false)
            {
                do
                {
                    try
                    {
                        Console.Write("Letter: ");
                        userInput = Console.ReadLine();

                        char[] chars = userInput.ToCharArray();
                        userInput = null;
                        userInput += chars[0]; 

                        Console.Clear();
                        Thread.Sleep(10);
                        Console.WriteLine("Your corrected input: "+userInput);
                        

                        for (int i = 0; i < userInput.Length; i++)
                        {
                            checkLetter = userInput[i];
                            if (validLetters.IndexOf(checkLetter) < 0)
                            {
                                throw new Exception();
                            }
                        }
                        validInput1 = true;
                        
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Input has to be a capitalized letter");
                    }

                    userInputChar = Convert.ToChar(userInput);

                } while (validInput1 == false);

                //EINGABE BUCHSTABE MIT WORD VERGLEICHEN, SCHAUEN OB DA DIESE BUCHSTABE GIBT
                for (int i = 0; i < word.Length; i++)
                {
                    checkLetter = word[i];
                    if (userInputChar == checkLetter)
                    {
                        validInput2 = true;
                        charunterstriche[i] = userInputChar;
                    }
                }
                //Gewinnüberprüfung
                for (int o = 0; o < charunterstriche.Length; o++)
                {
                    stringunterstriche += charunterstriche[o];
                }
                if (stringunterstriche == word)
                {
                    Console.WriteLine("Du hast gewonnen!");
                    Thread.Sleep(10000);
                    Environment.Exit(0);
                }
                for (int m = 0; m <= stringunterstriche.Length; m++)
                {
                    charunterstriche[m] += stringunterstriche[m]; //////////////////////////////FEWHLER HIERT
                }

                if (validInput2 == false)
                {
                    Console.WriteLine("Nah fam");
                    //counting the number of wrong inputs
                    trys++;
                    Console.WriteLine(trys);

                    //Anzeige bei Fehler
                    if (trys == 1)
                    {
                        BoardGenerator(1);
                        Console.WriteLine(charunterstriche);
                    }
                    if(trys == 2)
                    {
                        BoardGenerator(2);
                        Console.WriteLine(charunterstriche);
                    }
                    if(trys == 3)
                    {
                        BoardGenerator(3);
                        Console.WriteLine(charunterstriche);
                    }
                    if (trys == 4)
                    {
                        BoardGenerator(4);
                        Console.WriteLine(charunterstriche);
                    }
                    if (trys == 5)
                    {
                        BoardGenerator(5);
                        Console.WriteLine(charunterstriche);
                    }
                    if (trys == 6)
                    {
                        BoardGenerator(6);
                        Console.WriteLine(charunterstriche);
                    }
                    if (trys == 7)
                    {
                        BoardGenerator(7);
                        Console.WriteLine(charunterstriche);
                    }
                    if (trys == 8)
                    {
                        BoardGenerator(8);
                        Console.WriteLine(charunterstriche);
                    }
                    //Game-Over
                    if(trys == 9)
                    {
                        BoardGenerator(9);
                        Console.WriteLine("HangMan was hanged. GAME OVER!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Hoorayyyyy!!!!");
                    //checking that all correct letters have been guessed
                    
                    if (wordcompletion == true)
                    {
                        Console.WriteLine("You've figured out the word!");
                        break;
                    }
                }
                validInput2 = false;
            }
        }





        static int NumberGenerator(int von, int bis)
        {
            Random cube = new Random();
            int number = cube.Next(0, bis);
            return number;
        }
        static void BoardGenerator(int layer)
        {
            if (layer == 0)
            {
                Console.WriteLine(@"         ");
                Console.WriteLine(@"         ");
                Console.WriteLine(@"         ");
                Console.WriteLine(@"         ");
                Console.WriteLine(@"         ");
                Console.WriteLine(@"         ");
                return;
            }
            if (layer == 1)
            {
                Console.WriteLine(@"         ");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 2)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 3)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 4)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"   o    |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 5)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"   o    |");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 6)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"   o    |");
                Console.WriteLine(@"  /|    |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 7)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"   o    |");
                Console.WriteLine(@"  /|\   |");
                Console.WriteLine(@"        |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 8)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"   o    |");
                Console.WriteLine(@"  /|\   |");
                Console.WriteLine(@"  /     |");
                Console.WriteLine(@"        |");
                return;
            }
            if (layer == 9)
            {
                Console.WriteLine(@"   ------");
                Console.WriteLine(@"   |    |");
                Console.WriteLine(@"   o    |");
                Console.WriteLine(@"  /|\   |");
                Console.WriteLine(@"  / \   |");
                Console.WriteLine(@"        |");
                return;
            }
        }
    }
}