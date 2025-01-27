//var Game = new MainMenu();
//Game.Show();
using System.Threading;


var testMelon = new FireMelon("Bames Jond");
var testing = new Equipment("Helmet", 0, 0, 2, 2, "Dragon knights Visage");
var testing2 = new Equipment("Chestplate", 0, 0, 4, 4, "Dragon knights Chestplate");
Console.WriteLine(testing.ToString());
Console.WriteLine(testing2.ToString());

testMelon.Inventory.AddItem(testing);
testMelon.Inventory.AddItem(testing2);


testMelon.Inventory.AddEquipment(testing);
testMelon.Inventory.AddEquipment(testing2);
Console.WriteLine($"{testMelon.Inventory.ArmorValue()}");
Thread.Sleep(10000);