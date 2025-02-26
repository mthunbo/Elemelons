using System.Text.Json;

/// <summary>
/// Class respondible for making equipment
/// </summary>
public static class EquipmentFactory
{
    public static void FillChestWithEquipment(string filePath, Chest chest)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"File not found: {filePath}");

        string jsonData = File.ReadAllText(filePath);
        List<Equipment> allEquipment = JsonSerializer.Deserialize<List<Equipment>>(jsonData);

        Random rng = new Random();
        allEquipment = allEquipment.OrderBy(_ => rng.Next()).ToList();

        foreach (var equipment in allEquipment)
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
                break; // Stop if MaxValue is reached
        }
    }
}