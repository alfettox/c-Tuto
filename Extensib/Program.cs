using System;
using System.IO;

namespace Extensib
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\logC.txt"));
            dbMigrator.Migrate();
        }
    }

    public interface ILogger
    {
        void LogError(string msg);
        void LogInfo(string msg);
    }

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string msg)
        {
            Log(msg, "ERROR");
        }

        public void LogInfo(string msg)
        {
            Log(msg, "INFO");
        }

        private void Log(string msg, string msgType)
        {
            try
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine(msgType + " " + msg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to log file: " + ex.Message);
            }
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: " + msg);
            Console.ResetColor();
        }

        public void LogInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("INFO: " + msg);
            Console.ResetColor();
        }
    }

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            // Database migration logic here
            _logger.LogInfo("Migration completed successfully.");
        }
    }
}
