using System;

using System.Collections.Generic;

using System.Linq;

class Project
{
    static void Main()
    {
        // Create a dictionary to store keys and values
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
        
        // Boolean flag to control loop for users interactions
        bool continueProgram = true;

        // Loop used to run prompt continuously until user quits
        while (continueProgram)
        {
            // Display menu options to the user
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Populate the Dictionary");
            Console.WriteLine("2. Display Dictionary Contents");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add a New Key and Value");
            Console.WriteLine("5. Add a Value to an Existing Key");
            Console.WriteLine("6. Sort the Keys");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            // Read the user's input
            string choice = Console.ReadLine();

            // Switch statement to handle the user's choice
            switch (choice)
            {
                case "1":
                    // Call to populate the Dictionary with some user's input
                    PopulateDictionary(dictionary);
                    break;

                case "2":
                    // Call to display the contents of the Dictionary
                    DisplayDictionaryContents(dictionary);
                    break;

                case "3":
                    // Call to remove a specified key from the Dictionary
                    RemoveKey(dictionary);
                    break;

                case "4":
                    // Call to add a new key-value pair to the Dictionary
                    AddNewKeyValue(dictionary);
                    break;

                case "5":
                    // Call to add a value to an existing key
                    AddValueToExistingKey(dictionary);
                    break;

                case "6":
                    // Call to sort the keys in the Dictionary and display them
                    SortKeys(dictionary);
                    break;

                case "7":
                    // Call to exit the program
                    continueProgram = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void PopulateDictionary(Dictionary<string, List<string>> dictionary)
    {
        // Data used to populate the dictionary
        dictionary["Fruits"] = new List<string> { "Apple", "Banana", "Orange" };
        dictionary["Vegetables"] = new List<string> { "Broccoli", "Carrot", "Lettuce" };
        Console.WriteLine("Dictionary populated with sample data.");
    }

    static void DisplayDictionaryContents(Dictionary<string, List<string>> dictionary)
    {
        // Check if the dictionary is empty
        if (dictionary.Count == 0)
        {
            Console.WriteLine("The dictionary is empty.");
            return;
        }

        // Display each key and its corresponding values
        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
        }
    }

    static void RemoveKey(Dictionary<string, List<string>> dictionary)
    {
        Console.Write("Enter the key to remove: ");
        string key = Console.ReadLine();

        // Checking if the key exists and removing it if necessary
        if (dictionary.Remove(key))
        {
            Console.WriteLine($"Key '{key}' removed successfully.");
        }
        else
        {
            Console.WriteLine($"Key '{key}' not found.");
        }
    }

    static void AddNewKeyValue(Dictionary<string, List<string>> dictionary)
    {
        Console.Write("Enter the new key: ");
        string key = Console.ReadLine();

        Console.Write("Enter the value (seperate with commas if multiple): ");
        string input = Console.ReadLine();
        List<string> values = input.Split(',').Select(v => v.Trim()).ToList();

        // Add the new key-value pair to the dictionary
        dictionary[key] = values;
        Console.WriteLine($"New key '{key}' added with values: {string.Join(", ", values)}");
    }

    static void AddValueToExistingKey(Dictionary<string, List<string>> dictionary)
    {
        Console.Write("Enter the existing key: ");
        string key = Console.ReadLine();

        if (dictionary.ContainsKey(key))
        {
            Console.Write("Enter the value to add: ");
            string value = Console.ReadLine();
            
            // Add the new value to the existing key
            dictionary[key].Add(value); 
            Console.WriteLine($"Value '{value}' added to key '{key}'.");
        }
        else
        {
            Console.WriteLine($"Key '{key}' not found.");
        }
    }

    static void SortKeys(Dictionary<string, List<string>> dictionary)
    {
        // Sort the keys and display them
        var sortedKeys = dictionary.Keys.OrderBy(k => k).ToList();
        Console.WriteLine("Sorted keys:");
        foreach (var key in sortedKeys)
        {
            Console.WriteLine(key);
        }
    }
}
