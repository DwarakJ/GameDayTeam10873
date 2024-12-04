public void ReadFileLines(string userInput)
{
    var lines = File.ReadAllLines(userInput);
    Console.WriteLine($"Read {lines.Length} lines from file: {userInput}");
}
