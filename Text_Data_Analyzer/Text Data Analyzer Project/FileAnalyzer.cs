using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    //Base Class
    public class FileAnalyzer
    {
        private AnalysisResults _results;
        public AnalysisResults GetResults()
        {
            return _results;
        }
        public void setResults(AnalysisResults results)
        {
            //Checking or validation
            _results = results;
        }
    }
}
