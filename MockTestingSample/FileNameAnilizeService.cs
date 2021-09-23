namespace MockTestingSample
{
    public class FileNameAnilizeService : IFileNameAnilizeService
    {
        private LogWriter logger = new LogWriter();
        public bool Anilize1(string fileName)
        {
            if (fileName.EndsWith("tion"))
            {
                //logger.LogWrite("File name ends with tion");
                return true;
            }
            return false;
        }

        public bool Anilize2(string fileName)
        {
            if (fileName.StartsWith("Win"))
            {
                logger.LogWrite("File name starts with Win");
                return true;
            }
            return false;
        }
    }
}
