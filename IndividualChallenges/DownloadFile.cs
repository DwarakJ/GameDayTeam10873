public void DownloadFile(string url)
{
    using (var client = new WebClient())
    {
        client.DownloadFile("http://example.com/file.txt", "file.txt");
    }
    Console.WriteLine("File downloaded from: " + url);
}
