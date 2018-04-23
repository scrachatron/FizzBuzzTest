using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        enum numberstate
        {
            Fizz,
            Buzz,
            FizzBuzz,
            Na
        }                                                    //Deprecated enum



        static void Main(string[] args)
        {
                                                                                //declare variables
            string output = "";                                                 //The output string to be shown

            #region Deprecated Vairables

            //int FizzNumber = 3;                                                 // Number required to see Fizz
            //int BuzzNumber = 4;                                                 //Number required to see Buzz
            //numberstate state = numberstate.Na;                                 //State tracking

            #endregion


            int max = 100;                                                      //Maximum number to be tested

            List<Key> UpdateList =  new List<Key>();                            //Declare List and initalise
                                                                                //Populate list
            UpdateList.Add(new Key(3, "Fizz"));                                 //Populate list with the Fizz condition
            UpdateList.Add(new Key(4, "Buzz"));                                 //Populate list with the Buzz condition
           // UpdateList.Add(new Key(7, "Boom"));                                 //Populate list with the Boom condition
           // UpdateList.Add(new Key(9, "Crash"));                                //Populate list with the Crash condition

                                                                                //To maintain and update simply add to the vairable UpdateList

            for (int i = 1; i < max + 1; i++)                                   //Begin Main Loop
            {
                foreach (Key k in UpdateList)                                   //Begin secondary conditional loop
                    if (i % k.Number == 0)                                      //Check if current testing number is divisible by any conditions
                        output += k.String;                                     //If true add relivent ammendment string to output

                #region Aesthetic Display of information
                Console.Write(i);                                               //Output current number
                Console.CursorLeft = 6;                                         //Set cursor position to 6
                Console.Write(":");                                             //Output " : "
                Console.CursorLeft = 10;                                        //Set cursor position to 10
                Console.WriteLine(output);                                      //Finally output full string with above conditions
                #endregion

                output = "";                                                    //Reset Output to contain no text
            }

            Console.WriteLine();                                                //Skip a line
            Console.WriteLine("Press Enter to continue.");                      //Output instruction
            Console.ReadLine();                                                 //Wait for user to press enter

        }

        struct Key                                                              //Structure used for KeyTypes
        {
            public int Number                                                   //Public Read Only Accessor for main loop count to be tested against 
            { 
                get { return Keynumber; }                                       //Get accessor
            }
            public string String                                                //Public Read Only Accessor for the output text to be added too
            {
                get { return Outputstring; }                                    //Get accessor
            }                                            

            private int Keynumber;                                              //internal private holding for the test number to be saved
            private string Outputstring;                                        //internal private holding for the output text to be saved


            public Key(int keynumber, string outputstring)
            {
                Keynumber = keynumber;                                          //Setting of Keynumber
                Outputstring = outputstring;                                    //Setting of Output string
            }
        }                                                         


    }
}


#region Deprecated code;
// This was First draft example of switch states however, it felt messy and difficult to maintain
// and update, ultimitley I decided it was a better use of time to use a different kind of system 
// in order to ensure maintainability and readability



//for (int i = 1; i < max + 1; i++)                                         //begin main loop
//{
//    output = "";                                                          //Set Output to ""

//    if ((i % FizzNumber == 0) && i % BuzzNumber == 0)                     //Test to see if current loop count (i) is a multiple of FizzNumber and BuzzNumber
//        state = numberstate.FizzBuzz;                                     //if true set state to be fizzbuzz
//    else if (i % FizzNumber == 0)                                         //else Test to see if current loop count (i) is a multiple of FizzNumber
//        state = numberstate.Fizz;                                         //if true set state to be fizz
//    else if (i % BuzzNumber == 0)                                         //else Test to see if current loop count (i) is a multiple of BuzzNumber
//        state = numberstate.Buzz;                                         //if true set state to be buzz
//    else
//        state = numberstate.Na;                                           //Default set state to Na



//    switch (state)                                                        //Begin switch statement on current state 
//    {
//        case numberstate.Fizz:                                            //if current state is fizz
//            output += "Fizz ";                                            //amend output string with "Fizz"
//            break;
//        case numberstate.Buzz:                                            //if current state is buzz
//            output += "Buzz ";                                            //amend output string with "Buzz"
//            break;
//        case numberstate.FizzBuzz:                                        //if current state is fizzbuzz
//            output += "FizzBuzz ";                                        //amend output string with "FizzBuzz"
//            break;
//        case numberstate.Na:                                              //if current state is NA 
//            break;                                                        //Break out
//        default:                                                          //Default

//            break;                                                        //Break
//    }

#endregion


