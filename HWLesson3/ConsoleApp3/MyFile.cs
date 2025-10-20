using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class MyFile
    {
        public MyFile() { }

        public void openFile(string filename)
        {

            string FILENAME = "..\\..\\files\\" + filename; // השתמש בפרמטר filename
            if (!File.Exists(FILENAME))
                throw new FileNotFoundException("not found", FILENAME);
            using (StreamWriter streamWriter = new StreamWriter(FILENAME, true))

            {
                streamWriter.WriteLine("1, world war 2, y.k, 500, children, Bloomsbury, 12, 70");
                streamWriter.WriteLine("2, 1945, g.o, 328, Dystopian, yefey nof, 8, 85");
                streamWriter.WriteLine("3, small world, shalom cohen, 200, Drama, yefey nof, 10, 100");
            }
           


        }
        public void readFile(string filename) // הוסף פרמטר filename
        {
            string FILENAME = "..\\..\\files\\" + filename; // הגדרת משתנה FILENAME
            if (!File.Exists(FILENAME))
            {
                throw new FileNotFoundException("File not found", FILENAME);
            }

            using (StreamReader streamReader = new StreamReader(FILENAME))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line); // מדפיס את השורות לקונסול
                }
            }
        }
    }
    }
