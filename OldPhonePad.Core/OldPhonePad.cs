using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace OldPhonePad.Core
{
    public class OldPhonePad
    {
        public static string PressedKeys(string message)
        {
            // Time Complexity: O(n) because we iterate through the input string once
            // Space Complexity: O(1) because we use a fixed amount of space for variables

            // Validate input
            foreach (char c in message)
            {
                if (!"0123456789*# ".Contains(c))
                {
                    throw new ArgumentException("Invalid character in input. Please use only digits 0-9, '*', '#', and spaces.");
                }
            }
            // Define the mapping of keypad numbers to letters
            Dictionary<int, List<string>> keypad = new Dictionary<int, List<string>>()
            {   
                {0, new List<string>() {" " } },
                {1, new List<string>() {"&", "\'", "("} },
                {2, new List<string>() {"a", "b", "c" } },
                {3, new List<string>() {"d", "e", "f" } },
                {4, new List<string>() {"g", "h", "i" } },
                {5, new List<string>() {"j", "k", "l" } },
                {6, new List<string>() {"m", "n", "o" } },
                {7, new List<string>() {"p", "q", "r", "s" } },
                {8, new List<string>() {"t", "u", "v" } },
                {9, new List<string>() {"w", "x", "y", "z" } },
            };

            string result = "";

            // loop through each character in the input message
            for (int i = 0; i < message.Length; i++)
            {
                // Skip spaces and handle special characters
                if (message[i] == ' ')
                {

                    continue;

                }
                else if(message[i] == '*')
                {
                    // Remove the last character from result if possible
                    if (result.Length > 0)
                    {

                        result = result.Remove(result.Length - 1, 1);

                    }
                    continue;

                }
                else if(message[i] == '#')
                {

                    // End of input
                    break;

                }

                
                int count = 1;
                // Count the same characters in sequence
                while (i + 1 < message.Length && message[i] == message[i + 1])
                {

                    count++;
                    i++;

                }

                // Get the letter from the keypad mapping
                int number = int.Parse(message[i].ToString());
                if (keypad.ContainsKey(number))
                {
                    // Get the letters for the current number
                    string[] letters = keypad[number].ToArray();
                    // Calculate the index for the letter
                    int index = count - 1;
                    // Add the letter to the result
                    result += letters[index];

                }
            }
            //return result in uppercase
            return result.ToUpper();

        }
    }
}