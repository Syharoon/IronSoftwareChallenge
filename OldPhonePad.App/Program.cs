using System;
using OldPhonePad.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Old Phone Keypad Simulator");
            Console.WriteLine("--------------------------------------------------\n");
            Console.WriteLine("Keypad Mapping:");
            Console.WriteLine("1: & ' (");
            Console.WriteLine("2: a b c");
            Console.WriteLine("3: d e f");
            Console.WriteLine("4: g h i");
            Console.WriteLine("5: j k l");
            Console.WriteLine("6: m n o");
            Console.WriteLine("7: p q r s");
            Console.WriteLine("8: t u v");
            Console.WriteLine("9: w x y z");
            Console.WriteLine("0: (space)");
            Console.WriteLine("*: Backspace");
            Console.WriteLine("#: Send Message\n");
            Console.WriteLine("Instructions:");
            Console.WriteLine("1. Press the keys corresponding to the letters you want to type.");
            Console.WriteLine("2. Use '*' to delete the last character (backspace).");
            Console.WriteLine("3. Use '#' to send the message and end input.\n");

            // Get user input
            Console.Write("Please enter the sequence of key presses):");
            string keyPresses = Console.ReadLine();
            
            // Process the input message to get the resulting text
            string message = OldPhonePad.Core.OldPhonePad.PressedKeys(keyPresses);

            // Display the result
            Console.WriteLine($"\nThe message is \" {message} \"");

        }
        
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        
   }
}