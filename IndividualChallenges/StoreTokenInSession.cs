public void StoreTokenInSession(string token)
{
    Session["AuthToken"] = token;
    Console.WriteLine("Token stored in session.");
}
