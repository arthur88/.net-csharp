namespace UdemyCSharpIntermediate3_associationBetweenClasses
{
    partial class Program
    {
        static void Main()
        {
            //Inheritance
            var text = new Text
            {
                Width = 100
            };

            text.Copy();

            //Composition - relationship between two classes that allows one to contai the other.
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();


        }
    }
}
