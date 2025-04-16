// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;


class Transfer
{
    public int treshold { get; set; }
    public int low_free { get; set; }
    public int high_fee { get; set; }
   

    class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
        
    }
}
class BahasaConfig
{

    public string lang { get; set; }

    public Transfer Transfer { get; set; }
    public string[] method { get; set; } 
    public confirmation Confirmation { get; set; }   


    public static BahasaConfig LoadConfig(string filePath)
    {
        try
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<BahasaConfig>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading config: {ex.Message}");
            return null;
        }

        Public void saveTofile(string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving config: {ex.Message}");
            }
        }

        class Program { 
        
        String configPath = "bank_transfer_config.json";
        BahasaConfig config = new BahasaConfig.loadFromFile(conFilegPath);
    }

    }



