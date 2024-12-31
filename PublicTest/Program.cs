// See https://aka.ms/new-console-template for more information

using System.Collections;

Console.WriteLine();
Console.WriteLine("GetEnvironmentVariables: ");
foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
    Console.WriteLine("  {0} = {1}", de.Key, de.Value);
