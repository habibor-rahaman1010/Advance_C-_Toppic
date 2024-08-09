namespace Composition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbMigrator migrator = new DbMigrator(new Logger());
            Installer installer = new Installer(new Logger());

            migrator.Migrate();
            installer.Install();
        }
    }
}
