public void OpenUrlWithUserInput(string userInput)
{
    Process.Start("http://example.com/resetpassword?email=" + userInput);
    Console.WriteLine("Opened URL: http://example.com/resetpassword?email=" + userInput);
}
