using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreWebApp
{
    public static class Logger
    {      
        
            static string logFile = @"C:\Users\arya.vinodkumar\Documents\CSharp\MVC\Individual Project\BookStoreWebApp\sampleLogFile.log";

            public static void WriteToLog(string whatToWrite)
            {
                // Set up the streamwriter as appendable so we don't overwrite anything already there
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(logFile, true);
                streamWriter.WriteLine(whatToWrite);
                streamWriter.Close();
            }
        


    }
}