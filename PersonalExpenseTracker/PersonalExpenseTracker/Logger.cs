using System;
using System.IO;

namespace PersonalExpenseTracker
{
    public static class Logger
    {
        public static void LogError(Exception ex, string additionalMessage = "")
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            string logFile = Path.Combine(logPath, "error_log.txt");
            using (StreamWriter sw = File.AppendText(logFile))
            {
                sw.WriteLine($"Date: {DateTime.Now}");
                sw.WriteLine($"Error: {ex.Message}");
                sw.WriteLine($"Stack Trace: {ex.StackTrace}");
                sw.WriteLine($"Additional Message: {additionalMessage}");
                sw.WriteLine("--------------------------------------------------");
            }
        }
    }
}