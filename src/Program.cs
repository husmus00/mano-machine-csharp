using System;
using System.IO;
using Interface;


// Serves as a shared interface for seperate implementation between
// the desktop and web versions of the emulator
namespace Interface
{
    class Console
    {
        public Console() { }

        public static void WriteLine()
        {
            System.Console.WriteLine();
        }

        public static void WriteLine(string output)
        {
            System.Console.WriteLine(output);
        }

        public static void Write(string output)
        {
            System.Console.Write(output);
        }

        public static void Clear()
        {
            System.Console.Clear();
        }

        public static void ReadKey()
        {
            System.Console.ReadKey();
        }

        public static string ReadLine()
        {
            string? val = System.Console.ReadLine();

            if (val == null) {
                return "";
            }

            return val;
        }
    }
}

namespace ManoMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Computer c = new Computer();
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Logger.End();
        }

        // Interface.Console.WriteLine();
    }
}
