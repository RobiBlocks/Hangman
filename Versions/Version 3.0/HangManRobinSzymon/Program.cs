using System.Reflection.Metadata.Ecma335;

namespace HangManRobinSzymon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            //variablen
            string userInput = "0";
            string userInput2;
            string validLetters = "AÄBCDEFGHIJKLMNOÖPQRSTUÜVWXYZ";
            char userInputChar = '_';
            char checkLetter; 
            bool validInput1 = false;
            bool validInput2 = false;
            string TestWord = "TestWord";
            int trys = 0;
            bool wordcompletion = false;







            //Wörter-Array
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

            //code




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

                        //Console.Clear();
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
                        Console.WriteLine("correct1 - Input is a capitalized letter");
                        
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("error1 - Input is not a capitalized letter");
                    }

                    userInputChar = Convert.ToChar(userInput);

                } while (validInput1 == false);

                //EINGABE BUCHSTABE MIT WORD VERGLEICHEN, SCHAUEN OB DA DIESE BUCHSTABE GIBT
                //HIER IST DER FEHLER !!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //HIER IST DER FEHLER !!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //HIER IST DER FEHLER !!!!!!!!!!!!!!!!!!!!!!!!!!!!
                //HIER IST DER FEHLER !!!!!!!!!!!!!!!!!!!!!!!!!!!!

                


                for (int i = 0; i < word.Length; i++)
                {
                    checkLetter = word[i];
                    if (userInputChar == checkLetter)
                    {
                        validInput2 = true;
                    }

                }

                if (validInput2 == false)
                {
                    Console.WriteLine("error2 - Input is not in the word");
                    //counting the number of wrong inputs
                    trys++;
                    Console.WriteLine(trys);
                    //Anzeige bei Fehler
                    for (int u = 0;u<10;u++)
                    {
                        BoardGenerator(u);
                    }
                    //Game-Over
                    if(trys == 8)
                    {
                        Console.WriteLine("HangMan was hanged. GAME OVER!");
                        BoardGenerator(1);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("correct2 - Input is in the word");
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