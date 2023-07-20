using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cables;

public class Cable  
{
    string Type;
    public Cable (string type)
    {
        Type = type;
    }
    public void Print()
    {
        Console.WriteLine($"Jest to kabel typu: {Type}");
    }
}