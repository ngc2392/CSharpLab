using System;

namespace Assignment2
{
    class OutputDirectoryInformation
    {
        static void Main(string[] args)
        {
           Console.Write("Please enter a file name for output file");

           string fileName = Console.ReadLine();

           Console.WriteLine("Writing output to " + fileName);

            //System.IO.DriveInfo di = new System.IO.DriveInfo("/");

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("/");

            System.IO.DirectoryInfo[] directories = di.GetDirectories();

            System.Collections.ArrayList folderInfoLines = new System.Collections.ArrayList();

            foreach(System.IO.DirectoryInfo directoryInfo in directories) 
            {
                // get the folder name
                string folderName = directoryInfo.Name;

                // last time the folder was accessed
                DateTime lastReadFrom = directoryInfo.LastAccessTime;

                // last time the folder was written to 
                DateTime lastWrittenTo = directoryInfo.LastWriteTime;

                // put the directory info into a string
                String line = folderName + " " + lastReadFrom + " " + lastWrittenTo;

                folderInfoLines.Add(line);

            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            {
                foreach (string line in folderInfoLines)
                {
                    file.WriteLine(line);
                }

            }

        }
    }
}
