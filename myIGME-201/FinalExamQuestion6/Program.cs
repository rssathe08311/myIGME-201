using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FinalExamQuestion6
{
    internal class Program
    {
        public class PlayerSettings
        {
            //instance of the PlayerSettings singleton
            private static PlayerSettings instance = new PlayerSettings();

            // Properties representing the player settings 
            public string PlayerName { get; set; }
            public int Level { get; set; }
            public int HP { get; set; }
            public List<string> Inventory { get; set; }
            public string license_key { get; set; }

            //to prevent instaiation from classes outside of this one
            private PlayerSettings()
            {
                Inventory = new List<string>();
            }

            //playerSettings instance getter
            public static PlayerSettings GetInstance()
            {
                return instance;
            }

            //destructures the json file so that the information can be accessed by the program
            public void LoadSettings(string jsonString)
            {
                try
                {
                    if (!string.IsNullOrEmpty(jsonString))
                    {
                        // Deserialize the JSON string into a temporary instance
                        PlayerSettings temp = JsonConvert.DeserializeObject<PlayerSettings>(jsonString);

                        // Copy the values from the temporary instance to the singleton instance
                        instance.PlayerName = temp.PlayerName;
                        instance.Level = temp.Level;
                        instance.HP = temp.HP;
                        //checks if the inventory is null or not and will define it accordingly
                        if (temp.Inventory != null)
                        {
                            instance.Inventory = temp.Inventory;
                        }
                        else
                        {
                            instance.Inventory = new List<string>();
                        }
                        instance.license_key = temp.license_key;

                        Console.WriteLine("Settings loaded successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Empty JSON string");
                    }
                }
                //throws exception in case there is an issue loading the json file
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading settings: {ex.Message}");
                }
            }

            //method that saves the changed settings into a file on the user's harddrive 
            public void SaveSettings(string filePath)
            {
                //writes the updated settings into a new file
                try
                {
                    string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
                    File.WriteAllText(filePath, json);
                    Console.WriteLine($"Settings saved to file: {filePath}");
                }
                //throws exception in case there is an issue loading the json file
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving settings: {ex.Message}");
                }
            }

        }
        static void Main(string[] args)
        {
            //string representation of the json file 
            string json = @"{
                ""player_name"": ""dschuh"",
                ""level"": 4,
                ""hp"": 99,
                ""inventory"": [
                    ""spear"", ""water bottle"", ""hammer"", ""sonic screwdriver"", ""cannonball"",
                    ""wood"", ""Scooby snack"", ""Hydra"", ""poisonous potato"", ""dead bush"", ""repair powder""
                ],
                ""license_key"": ""DFGU99-1454""
            }";

            //retrieves the only retreviable instance of the singleton
            PlayerSettings playerSettings = PlayerSettings.GetInstance();

            // Load settings from the json string
            playerSettings.LoadSettings(json);

            // Displays the current settings
            Console.WriteLine("Current Settings:");
            Console.WriteLine($"Player Name: {playerSettings.PlayerName}");
            Console.WriteLine($"Level: {playerSettings.Level}");
            Console.WriteLine($"HP: {playerSettings.HP}");
            Console.WriteLine("Inventory:");
            //foreach loop that displays all the items in the inventory
            foreach (string item in playerSettings.Inventory)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"License Key: {playerSettings.license_key}");

            // Save settings (for example purposes)
            playerSettings.SaveSettings("player_settings.json");
        }
        
    }
}
