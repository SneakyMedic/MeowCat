using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
namespace MeowCatAPI
{
    public class Management
    {
        public static List<Note> readList(string fileName,string dirName)
        {
            string valueFromLine = "Mello Wowld!"; int line = 1;var returnList = new List<Note>();
            while (!((valueFromLine = IO.ReadLine(fileName, line, dirName)) == null))
            {
                returnList.Add(new Note() { id=line,value=valueFromLine});
                line++;
            }
            return returnList;
        }
        public static void checkExistence(string file, string dir)
        {
            if(!(Directory.Exists(dir)))
            {
                IO.DirectoryCreate(dir);
            }
            if(!(File.Exists(dir+"/"+file)))
            {
                IO.Write(" ", file, dir, false, true);
            }
        }
        public static void updateList(string file,string dir,List<Note> newlist)
        {
            IO.ClearFile(file,dir);
            foreach(var v in newlist)
            {
                IO.Write(v.value,file,dir,true,true);
            }
        }
    }
}
