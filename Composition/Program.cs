namespace Componsition
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TEST");



            DbMigrator dbMig = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);


            dbMig.Migrate();

            installer.Install();
        }
    }

    
}