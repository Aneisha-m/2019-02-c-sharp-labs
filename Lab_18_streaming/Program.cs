using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_18_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            
            //NOT USING STREAMING : WRITING FILE DIRECTLY 
            //ADD SYSTEM.IO WHEN USING STREAMING
            string File01 = File.ReadAllText("data01.txt");

            //StreamReader
            //CREATE StreamReader OBJECT
            //ENCLOSE IT 'USING' BLOCK (COMPLETE 'CLEANUP' AFTERWARDS)
            //EXECUTE READLINE() METHOD WHICH WILL STREAM AND READ LINE BY LINE

            //PATH AS A VARIABLE
            //PATH01 IS A RELATIVE PATH
            string path01 = "data01.txt";
            //PATH02 IS AN ABSOLUTE PATH
            string path02 = "C:/DATA/data01.txt"; //OR TRY DOUBLE BACKWARD SLASH IN PATH
            //USING 'ESCAPE' CHARACTERS \t = tab \n = new line
            //\' will print one single apostrophe
            string path03 = "C:\\DATA\\data01.txt";
            //@ MEANS TREAT THE FOLLOWING STRING LITERALLY
            string path04 = @"C:\DATA\data01.txt"; // ANYTHING IN THE PATH IS TREATED AS A LITERAL CHARACTER AND \ WONT BE RECOGNISED

            //ENVIRONEMENT VARIABLES : MY DOCUMENTS FOLDER
            string path05 = Environment.ExpandEnvironmentVariables("%userprofile%") + "\\Documents\\data01.txt";
            Console.WriteLine(path05);

            string path06 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data01.txt";

            using (var reader= new StreamReader(path04)) //USE PATH01 /02/03 and so on OR data01.txt AS A RELATIVE PATH
            {
                string output;
                //READ EVERY LINE
                //OUTPUT TP STRING
                //TEST EACH TIME THAT THE STRING IS NOT NULL AND CONT
                //LOOPIMG UNTIL OUT OF DATA
                while ((output = reader.ReadLine())!=null)
                {
                    list.Add(output);
                }
            }
            list.ForEach(output => Console.WriteLine(output)); //USE LAMDA => TO REDUCE FOREACH LOOP TO ONE-LINE


            //StreamWriter
        }
    }
}
