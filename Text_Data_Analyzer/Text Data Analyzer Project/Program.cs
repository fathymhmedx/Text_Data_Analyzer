namespace Text_Data_Analyzer_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to file analyzer");
            Console.WriteLine("Please enter folder path to analyzer");

            string inputFolder = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);

            if (directoryInfo.Exists == false )
            {
                Console.WriteLine("Folder dosnt exist");
                return;
            }
            var fileNames = directoryInfo.GetFiles();

            IFileAnalysis fileAnalysis = null;
            foreach (var file in fileNames)
            {
                if (file.IsTextFile())
                {
                    fileAnalysis = new TXTFileAnalyzer();

                    fileAnalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalysis).GetResults();

                    Console.WriteLine($"File name :{file.Name} ");
                    Console.WriteLine($"Word count :{results.WordCount} ");
                    Console.WriteLine($"Charachter count :{results.CharachterCount} ");
                    Console.WriteLine($"Line count :{results.LineCount} ");
                } 
                else if(file.IsCsvFile())
                {

                    fileAnalysis = new CSVFileAnalyzer();

                    fileAnalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalysis).GetResults();

                    Console.WriteLine($"File name :{file.Name} ");
                    Console.WriteLine($"Field count :{results.FieldCount} ");
                   
                }

                
            }
        }
    }
}
