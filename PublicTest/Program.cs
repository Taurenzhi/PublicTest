// See https://aka.ms/new-console-template for more information

using System.Collections;

foreach (var se in args)
{
    Console.WriteLine(se);
}

Console.WriteLine("GetEnvironmentVariables: ");
foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
    Console.WriteLine("  {0} = {1}", de.Key, de.Value);

if (Environment.GetEnvironmentVariable("AlexTestSecretText") == "AlexTestSecretText")
{
    Console.WriteLine("AlexTestSecretText is correct");
}
else
{
    Console.WriteLine("AlexTestSecretText is incorrect");
}