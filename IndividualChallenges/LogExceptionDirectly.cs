public void LogExceptionDirectly()
{
    try
    {
        int result = 10 / 0; 
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}
