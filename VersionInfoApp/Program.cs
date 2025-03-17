using System;
using System.Reflection;


namespace VersionInfoApp
{
    public class Program
    {
        static void Main()
        {

            Console.WriteLine($"アプリケーションバージョン: {new VersionHelperLibrary().GetVersion()}");
        }

    }

}