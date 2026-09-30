namespace TextDecoderEncoder.Classes
{
    public static class InputHelper // InputHelper (static) → Handles user input (like reading a string or choice).

    {
        private static string choiceInput;
        private static string textInput;


        // Getters and Setters

        public static void setChoiceInput()
        {
            // läser användarens input
            choiceInput = Console.ReadLine();
        }

        public static string getChoiceInput()
        {
            // skickar till baka användarens val
            return choiceInput;
        }

        public static void setTextInput()
        {
            //läser in användarens text
            textInput = Console.ReadLine();
        }

        public static string getTextInput()
        {
            // skickar tillbaka användarens text
            return textInput;
        }


   

    }
}
