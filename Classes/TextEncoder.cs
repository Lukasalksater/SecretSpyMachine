namespace TextDecoderEncoder.Classes
{
    public class TextEncoder
    {
        // Attributes

        public string EncodedText  { get; set; }


        // Methods

        public string EncodeText(string textToEncode)
        {
            foreach (Char letter in textToEncode.ToUpper()) // this for loop goes through each letter of a string
            {
                switch (letter) // this switch case checks for the different letters and adds them to 
                {
                    // Varje case kollar om karaktären finns och sedan omvandlar den till rätt karaktär
                    // Detta görs i en ny tom sträng för att göra det lättast, därför är det +=.
                    case 'A':
                        EncodedText += '@';
                        break;

                    case 'E':
                        EncodedText += '3';
                        break;

                    case 'S':
                        EncodedText += '$';
                        break;

                    case 'I':
                        EncodedText += '!';
                        break;

                    case 'O':
                        EncodedText += '0';
                        break;

                    default:
                        EncodedText += letter; // Här läggs det till den bokstav som redans fanns, eftersom alla bokstäver inte hade ett kod symbol
                        break;

                }
            }
            return EncodedText;
            
        }

       

    }
}
