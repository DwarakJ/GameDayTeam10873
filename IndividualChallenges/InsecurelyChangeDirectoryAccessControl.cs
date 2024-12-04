public void InsecurelyChangeDirectoryAccessControl()
{
    DirectorySecurity security = new DirectorySecurity();
    Directory.SetAccessControl("C:\\SecureFolder", security);
    Console.WriteLine("Changed access control for C:\\SecureFolder.");
}
