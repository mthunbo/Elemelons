using System.Text;
using System.Threading;
using Spectre.Console;

string filePath = "D:\\Repos\\Elemelons\\Elemelons\\GameData\\Equipment.json";
EquipmentFactory.LoadEquipmentData(filePath);

Chest myChest = new Chest(500000);
EquipmentFactory.FillChestWithEquipment(myChest);

myChest.PrintContent();


var table = new Table()
    .AddColumn("Testing")
    .AddColumn("Testing 2")
    .AddRow("baz","maz")
    .AddRow("spaz","jaazz")
    .Title("Elemelons");


table.Columns[1].Centered();

AnsiConsole.Write(table);
