using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling my functions
            disemvoweler("Nickleback is my favorie band. Their songwriting can't be beat!");
            disemvoweler("How many bears could bar grylls grill if bear grylls could grill bears?");
            disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }

        static void disemvoweler(string input)
        {
            //setting my strings that will hold vowels and consonant
            string vowels = "";
            string other = "";
            //starting loop to go over the input string
            for (int i = 0; i < input.Length; i++)
            {
                //creating a string and putting the index of input into the new string
                string letter = input[i].ToString();
                //using if statement to check to see if there is a vowel
                if ("aeiou".Contains(letter.ToLower()))
                {
                    //found a vowel and adding it to the string 
                    vowels = vowels + letter;
                }
                    //Checking for spaces and then not doing anything when it finds one
                else if (letter == " ")
                {

                }
                else
                {
                    //found consonant and adding it to the other string
                    other += letter;
                }
                

            }
            //writing out everything that I found
            Console.WriteLine("original: " + input);
            //this is just writing a blank line so it's easier to read.
            Console.WriteLine(" ");
            Console.WriteLine("No vowels: " + other);
            Console.WriteLine(" ");
            Console.WriteLine("Vowels: " + vowels);
        }
    }
}
