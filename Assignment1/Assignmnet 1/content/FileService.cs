namespace Assignment1.content
{
    public class FileService
    {


        private string FileName { get; set; }


        public FileService(string fileName)
        {
            FileName = fileName;
        }


        public void FileRead()
        {
            try
            {
                using (StreamReader SR = new StreamReader(FileName))
                {
                    Console.WriteLine(FileName);
                    string line;
                    while ((line = SR.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Read Error: " + FileName + " " + e);
            }
        }


        public void FileWrite(string line)
        {
            try
            {
                using (StreamWriter Out = new StreamWriter(FileName, append: true))
                {
                    Out.Write(line + "\n");
                    Out.Flush();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + FileName + " " + e);
            }
        }


    }
}