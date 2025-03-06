﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer_Project
{
    public static class FileInfoExtensions
    {
        public static bool IsTextFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".txt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsCsvFile(this FileInfo fileInfo)
        {
            if (fileInfo.Extension == ".csv")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
