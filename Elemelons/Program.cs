//var Game = new MainMenu();
//Game.Show();
using System.Text;
using System.Threading;
using Spectre.Console;



Chest treasureChest = new Chest { MaxValue = 300 };
EquipmentFactory.FillChestWithEquipment("D:\\Repos\\Elemelons\\Elemelons\\GameData\\Equipment.json", treasureChest);
treasureChest.PrintContent();

var table = new Table()
    .AddColumn("Testing")
    .AddColumn("Testing 2")
    .AddRow("baz","maz")
    .AddRow("spaz","jaazz")
    .Title("Elemelons");


table.Columns[1].Centered();

AnsiConsole.Write(table);



// var testMelon = new FireMelon("Bames Jond");
// var testing = new Equipment("Helmet", 0, 0, 2, 2, "Dragon knights Visage", 5, 50);
// var testing2 = new Equipment("Chestplate", 0, 0, 4, 4, "Dragon knights Chestplate", 15, 200);
// Console.WriteLine(testing.ToString());
// Console.WriteLine(testing2.ToString());

// testMelon.Inventory.AddItem(testing);
// testMelon.Inventory.AddItem(testing2);


// testMelon.Inventory.AddEquipment(testing);
// testMelon.Inventory.AddEquipment(testing2);
// Console.WriteLine($"{testMelon.Inventory.ArmorValue()}");
// Thread.Sleep(10000);