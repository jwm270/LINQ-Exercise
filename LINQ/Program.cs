
 
var gameNames = new List<string>() { "Diablo", "TFT", "LOL", "Runeterra" };

var order  = gameNames.OrderBy(gameNames=> gameNames.Length).ToList();

foreach (var name in order)
{
    Console.WriteLine(name);
}


