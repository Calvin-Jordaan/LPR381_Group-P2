using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LPR381_GroupProject_Group_P2_V1.DataLayer
{
    internal class DataHandler
    {
        public string ReadTextFile(string path)
        {
            // Read the file
            string content = File.ReadAllText(path, Encoding.UTF8);

            // Test if the file has information
            //Console.WriteLine(content);

            // Return the text
            return content;
        }
    }
}
