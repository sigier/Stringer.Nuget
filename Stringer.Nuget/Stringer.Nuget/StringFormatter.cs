namespace Stringer.Nuget
{
    public class StringFormatter
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            int length = input.Length;
            char[] charArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                charArray[i] = input[length - 1 - i];
            }

            return new string(charArray);
        }
    }
}
