using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelP.Helpers.Queries
{
    public class QueriesHelper
    {

        public static string LoadFilesToList(string fileName)
        {
            List<string> content = new List<string>();

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Queries\{fileName}");
            var files = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(files))
            {
                return "TextFile is empty";
            }

           return files = files.Replace(";", ";" + Environment.NewLine);
        }

        public static void SaveToFile(string directoryPath, string fileName, string content)
            {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(fileName, directoryPath), content);
          }


        public static List<string> GetAllTextFiles()
        {
            List<string> content = new List<string>();
            DirectoryInfo di = new DirectoryInfo(@"Queries\");
            foreach (var fi in di.GetFiles())
            {
                content.Add(fi.ToString());
            }

            return content;
        }
    }
}
