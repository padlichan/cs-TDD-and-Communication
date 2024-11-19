namespace cs_TDD_and_Communication
{
    public class ASCIISumify()
    {
        public static int Sum(string input)
        {

            if(input == null) throw new ArgumentNullException("input cannot be null");
            char[] inputCharArray = input.ToCharArray();
            int result = 0;
            for (int i = 0; i < inputCharArray.Length; i++)
            {
                result += inputCharArray[i] + 0;
            }

            return result;
        }
    }
}
