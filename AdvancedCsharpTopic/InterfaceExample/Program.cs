namespace InterfaceExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string path = @"D:\Advanced_C#\AdvancedCsharpTopic\InterfaceExample\log\log.txt";
            DbMigrator dbMigrator = new DbMigrator(new FileLogger(path));
            dbMigrator.Migrate();
        }
    }
}
