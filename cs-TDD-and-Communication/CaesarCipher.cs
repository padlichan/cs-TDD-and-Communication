using System.Text;

namespace cs_TDD_and_Communication
{
    public class CaesarCipher
    {
        public static string EncodeCipher(string inputString)
        {
            //Numbers should pass unchanged
            //

            //A -> 65, check if it's in the range of capital letters

            // A B C D E F G H I J K L M N O P Q R S T U V W X Y Z %  = ) /
            // 65                      77                        90 -65 +13 38
            //if it is: -65+13 => -52
            //Take %26 +65 65+11

            //string builder saves memory!
            StringBuilder output = new StringBuilder();
            foreach (char c in inputString)
            {
                char letterToAdd = c;
                //Is it a capital letter?
                if(c >= 65 && c <= 90)
                {
                    letterToAdd = Convert.ToChar(((c - 65 + 13) % 26) + 65);
                }
                //Is it a lowecase letter?
                else if (c >= 97 && c <= 122)
                {
                    letterToAdd = Convert.ToChar(((c - 97 + 13) % 26) + 97);
                }
                output.Append(letterToAdd);

            }
            return output.ToString();
        }
    }
}
