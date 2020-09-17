using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = string.Empty;

            int NumOfLines=0, NumOfWords=0, NumOfChars=0, NumOfLetters=0, NumOfDigits=0, NumOfSpecChars=0, NumOfWhiteChars=0, NumOfConsonants=0, NumOfVowels=0, NumOfUppCase=0, NumOfDownCase=0;

            Console.WriteLine("Enter the path to the file:");
            path = @Console.ReadLine();

            Console.WriteLine();

            if (File.Exists(path))
            {

                string[] InputText = File.ReadAllLines(@path);

                for (int i = 0; i < InputText.Length; i++)
                {
                    for (int j = 0; j < InputText[i].Length; j++)
                    {

                        if (InputText[i][j] == ' ' && InputText[i][j - 1] >= '!' && InputText[i][j - 1] <= '~' || InputText[i][j] >= '!' && InputText[i][j] <= '~' && j == InputText[i].Length - 1)
                        {
                            NumOfWords++;
                        }

                        if (InputText[i][j] >= 'A' && InputText[i][j] <= 'z')
                        {
                            NumOfLetters++;

                            if(InputText[i][j] >= 'A' && InputText[i][j] <= 'Z')
                            {
                                NumOfUppCase++;
                            }
                            else
                            {
                                NumOfDownCase++;
                            }

                            if(InputText[i][j] == 'A' || InputText[i][j] == 'E' || InputText[i][j] == 'I' || InputText[i][j] == 'O' || InputText[i][j] == 'U' || InputText[i][j] == 'a' || InputText[i][j] == 'e' || InputText[i][j] == 'i' || InputText[i][j] == 'o' || InputText[i][j] == 'u')
                            {
                                NumOfVowels++;
                            }
                            else
                            {
                                NumOfConsonants++;
                            }
                        }
                        else if (InputText[i][j] >= '0' && InputText[i][j] <= '9')
                        {
                            NumOfDigits++;
                        }
                        else if (InputText[i][j] < '!')
                        {
                            NumOfWhiteChars++;
                        }
                        else
                        {
                            NumOfSpecChars++;
                        }

                        NumOfChars++;
                    }
                    NumOfLines++;
                }

                Console.WriteLine("lines: {0}", NumOfLines);
                Console.WriteLine("words: {0}", NumOfWords);
                Console.WriteLine("characters: {0}", NumOfChars);
                Console.WriteLine("letters: {0}", NumOfLetters);
                Console.WriteLine("numbers: {0}", NumOfDigits);
                Console.WriteLine("special signs: {0}", NumOfSpecChars);
                Console.WriteLine("white signs: {0}", NumOfWhiteChars);
                Console.WriteLine("vowels: {0}", NumOfVowels);
                Console.WriteLine("consonants: {0}", NumOfConsonants);
                Console.WriteLine("uppercase: {0}", NumOfUppCase);
                Console.WriteLine("lowercase: {0}", NumOfDownCase);

            }
            else 
            {
                Console.WriteLine("The path {0} does not exist", @path);
            }

            Console.WriteLine();
            Console.WriteLine("Hit escape to finish...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
