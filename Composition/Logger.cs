namespace Componsition
{
    class Logger
    {
        public void Log(string message)     //Reusable COMPOSITION method loose coupled
        {
            Console.WriteLine(message);
        }
    }
}

/* Favorite composition over inheritance */