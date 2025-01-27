//var Game = new MainMenu();
//Game.Show();
using System.Threading;


var testMelon = new FireMelon("Bames Jond");
var testing = new Equipment("Helmet", 2,2,0,0,"Dragon knights Visage");
Console.WriteLine(testing.ToString());

testMelon.Inventory.AddItem(testing);

testMelon.Inventory.AddEquipment(testing);
Console.WriteLine($"{testMelon.Inventory.ArmorValue()}");
Thread.Sleep(10000);