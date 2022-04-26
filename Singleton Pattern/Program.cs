
using Singleton_Pattern;

var c1 = CustomerManager.CreateAsSingleton();
var c2 = CustomerManager.CreateAsSingleton();

Console.WriteLine(c1.deneme);
c1.deneme++;
Console.WriteLine(c2.deneme);

