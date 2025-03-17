using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        Console.WriteLine($"Version: {version}");
    }
}