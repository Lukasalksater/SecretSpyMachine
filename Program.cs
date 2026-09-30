using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using TextDecoderEncoder.Classes;
namespace TextDecoderEncoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Description
            // You are building a Secret Message Machine for spies.
            // The user can either encode a message into a coded format
            // or decode a coded message back into readable text.

            // Requirments
            //  Classes and Objects
            //MessageEncoder → Encodes messages.
            //MessageDecoder → Decodes messages.
            //InputHelper(static) → Handles user input(like reading a string or choice).
            //Menu with switch-case
            //Show a menu:
            // Encode message
            //Decode message
            //Exit
            //Use a switch to handle the choice.
            //Use while loop
            //Keep showing the menu until the user chooses Exit.

            bool isSpying = true;
            Console.WriteLine("Welcome to the secret spy machine");
            Console.WriteLine("1. Encode Message");
            Console.WriteLine("2. Decode Message");
            Console.WriteLine("3. Exit");
            TextEncoder textEncoder = new TextEncoder();
            TextDecoder textDecoder = new TextDecoder();
         
            while (isSpying)
            {
                InputHelper.setChoiceInput();
                var choice = InputHelper.getChoiceInput().ToUpper();
                Console.ForegroundColor = ConsoleColor.Green;
                switch(choice) // This switch case checks for 1 2 and exit to either encode, decode or exit the program, otherwise it just sends and error message
                {
                    case "1":
                        // Här krypteras texten
                        textEncoder.EncodedText = "";
                        Console.WriteLine($"Choose {choice}");
                        InputHelper.setTextInput();
                        var textToEncode = InputHelper.getTextInput();
                        Console.WriteLine($"Enter your message: {textToEncode} ");
                        textEncoder.EncodeText(textToEncode);
                        Console.WriteLine($"Encoded: {textEncoder.EncodedText}");
                        break;

                    case "2":
                        // Här dekrypteras texten
                        textDecoder.DecodedText = "";
                        Console.WriteLine($"Choose {choice}");
                        var textToDecode = textEncoder.EncodedText;
                        Console.WriteLine($"Message to decode: {textToDecode} ");
                        textDecoder.DecodeText(textToDecode);
                        Console.WriteLine($"Decoded: {textDecoder.DecodedText}");
                        break;

                    case "EXIT":
                        // Här avslutas applikationen
                        Console.WriteLine("You exited the secret message machine");
                        isSpying = false;
                        break;

                    default:
                        // Här skickas ett meddalande att fel input var skickat
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("ERROR: Secret message machine only accepts 1 2 or exit");
                        break;




                }
            }
        }
    }
}
