﻿namespace _2_Console_AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
        Console.WriteLine($"Computer named {Environment.MachineName} says \"No.\"");
    }
}
