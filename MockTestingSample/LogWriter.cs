using System;
using System.IO;
using System.Reflection;

namespace MockTestingSample
{
    public class LogWriter
    {
        private string currentPath = string.Empty;
        public LogWriter()
        {

        }

        public void LogWrite(string logMessage)
        {
            currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter writer = File.AppendText(currentPath + "\\" + "log.txt"))
                {
                    Log(logMessage, writer);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
