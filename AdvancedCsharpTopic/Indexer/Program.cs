namespace Indexer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                HttpCookie cookie = new HttpCookie();
                cookie["name"] = "Habibor Rahaman";
                Console.WriteLine(cookie["name"]);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("{0} or emty string or white space...", ex.Message);
            }
        }
    }
}
