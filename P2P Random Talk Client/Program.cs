using System;

namespace P2PRandomTalkClient
{
    public static class ConsoleHandler
    {
        public static void SetTitle(string val)
        {
            Console.Title = val;
        }
        public static string Read()
        {
            return Console.ReadLine() ?? "";
        }
        public static void Write(string val, bool newline = false)
        {
            Console.Write(val + (newline ? Environment.NewLine : ""));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHandler.SetTitle("P2P Random Talk Client");

        }
    }
}