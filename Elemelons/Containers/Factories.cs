using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Class respondible for making equipment
/// </summary>
public static class EquipmentFactory
{
    public static void FillChestWithEquipment(string filePath, Chest chest)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"File not found: {filePath}");

        // Deserialize using Newtonsoft.Json
        string jsonData = File.ReadAllText(filePath);
        var allEquipment = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<Equipment>>>>(jsonData);

        if (allEquipment == null || allEquipment.Count == 0)
            throw new InvalidOperationException("No equipment found in the JSON file.");

        Random rng = new Random();

        // Shuffle the lists of equipment
        foreach (var rarity in allEquipment)
        {
            foreach (var equipmentType in rarity.Value)
            {
                equipmentType.Value.Sort((x, y) => rng.Next().CompareTo(rng.Next()));
            }
        }

        // Iterate through each rarity -> type -> equipment and fill the chest
        foreach (var rarity in allEquipment)
        {
            foreach (var equipmentType in rarity.Value)
            {
                foreach (var equipment in equipmentType.Value)
                {
                    equipment.ScaleStats(); // Apply rarity-based scaling

                    try
                    {
                        chest.AddEquipment(equipment); // Add if within MaxValue
                    }
                    catch (InvalidOperationException)
                    {
                        continue; // Skip items that exceed MaxValue
                    }

                    if (chest.CurrentValue >= chest.MaxValue)
                        return; // Stop if MaxValue is reached
                }
            }
        }
    }
}
