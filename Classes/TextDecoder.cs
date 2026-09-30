namespace TextDecoderEncoder.Classes
{
    public class TextDecoder
    {

        // Attributes
        public string DecodedText { get; set; }



        // Methods

        public string DecodeText(string textToDecode)
        {
            foreach (Char letter in textToDecode.ToUpper()) // this for loop goes through each letter of a string
            {
                switch (letter) // this switch case checks for the different letters and adds them to a new string to send out the decoded text
                {
                    // Varje case kollar om karaktären finns och sedan omvandlar den till rätt karaktär
                    // Detta görs i en ny tom sträng för att göra det lättast, därför är det +=.
                    case '@':
                        DecodedText +=  'A';
                        break;

                    case '3':
                        DecodedText += 'E';
                        break;

                    case '$':
                        DecodedText += 'S';
                        break;

                    case '!':
                        DecodedText += 'I';
                        break;

                    case '0':
                        DecodedText += 'O';
                        break;
                        
                    default:
                        DecodedText += letter; // Här läggs det till den bokstav som redans fanns, eftersom alla bokstäver inte hade ett kod symbol
                        break;

                }
            }
            return DecodedText;
        }



    }
}
