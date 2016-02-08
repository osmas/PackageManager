using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace DependencyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<args.Length;i++)
            {
               // Console.WriteLine(Convert.ToString(args[i]));
            }
             string datafile = Convert.ToString(args[0]);
             
             
            // Read the file as one string.
            string filePath = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\" + datafile);
            //string text = System.IO.File.ReadAllText(@""+ filePath);
            
            

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"" + filePath);

            // Display the file contents by using a foreach loop.
           /* System.Console.WriteLine("Contents of Packages = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            */

            for (int i = 1; i < args.Length; i++)
            {
                
                string package = Convert.ToString(args[i]);
                Console.Write(Convert.ToString(args[i])  + "-->");
                findDependecies(lines, package);
                ListData.SortData();
                ListData.Display();
                ListData.ClearAll();
                Console.WriteLine();

            }


            

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }


        static void findDependecies(string[] lines, string package)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] s = lines[i].Split(' ');

                if (package.Equals(s[0]))
                {
                    for(int j=2;j<s.Length;j++)
                    {
                        list.Add(s[j]);
                        ListData.Record(s[j]);
                    }

                    /*foreach (string dependency in list) // Loop through List with foreach.
                    {
                        Console.Write(dependency + " ");
                    }*/

                    
                    string[] dependenciesArray = list.ToArray();
                    for (int k = 0; k < dependenciesArray.Length; k++)
                    {
                        string nextpackage = dependenciesArray[k];
                        findDependecies(lines, nextpackage);
                    }

                }

                


                



                    

            }


        }

    }
}
