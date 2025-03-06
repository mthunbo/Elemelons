using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Class respondible for making equipment
/// </summary>
public static class EquipmentFactory
{
    private static Dictionary<string, Dictionary<string, List<Equipment>>> _equipmentData;

    public static void LoadEquipmentData(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"File not found: {filePath}");

        string jsonData = File.ReadAllText(filePath);
        _equipmentData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<Equipment>>>>(jsonData);
    }

    public static List<Equipment> GetAllEquipment()
    {
        List<Equipment> allEquipment = new List<Equipment>();

        foreach (var rarityEntry in _equipmentData)
        {
            string rarity = rarityEntry.Key;

            foreach (var typeEntry in rarityEntry.Value)
            {
                string type = typeEntry.Key;

                foreach (var equipment in typeEntry.Value)
                {
                    equipment.Type = type;
                    equipment.Rarity = rarity;
                    allEquipment.Add(equipment);
                }
            }
        }

        return allEquipment;
    }

    public static void FillChestWithEquipment(Chest chest)
    {
        if (_equipmentData == null)
            throw new InvalidOperationException("Equipment data not loaded. Call LoadEquipmentData() first.");

        List<Equipment> allEquipment = GetAllEquipment();

        Random rng = new Random();
        allEquipment = allEquipment.OrderBy(_ => rng.Next()).ToList(); // Shuffle the list

        foreach (var equipment in allEquipment)
        {
            equipment.ScaleStats(); // Apply rarity-based scaling

            try
            {
                chest.AddEquipment(equipment); // Add item if within MaxValue
            }
            catch (InvalidOperationException)
            {
                continue; // Skip items that exceed MaxValue
            }

            if (chest.CurrentValue >= chest.MaxValue)
                break; // Stop if MaxValue is reached
        }
    }
}
