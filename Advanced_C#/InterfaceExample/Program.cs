using System;

namespace InterfaceExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../logs/log.txt";
            DbMigrator dbMigrator = new DbMigrator(new FileLogger(path));
            dbMigrator.Migrate();
        }
    }
}
