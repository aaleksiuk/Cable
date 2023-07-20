// See https://aka.ms/new-console-template for more information
using Cables;

Cable cable1 = new("USB A");
Cable cable2 = new("USB B");
Cable cable3 = new("USB 3.0");
Cable cable4 = new("USB mini");
Cable cable5 = new("USB micro");

List<Cable> cables = new ();
cables.Add(cable1);
cables.Add(cable2);
cables.Add(cable3);
cables.Add(cable4);
cables.Add(cable5);

foreach (var cable in cables)
{ 
    cable.Print();
}

Console.WriteLine($"============\nLista zawiera: {cables.Count} elementów");