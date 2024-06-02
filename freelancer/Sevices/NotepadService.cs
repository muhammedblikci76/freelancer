using freelancer.Abstract;
using freelancer.Constans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancer.Sevices
{
    public class NotepadService
    {
        public void SaveToNotepad(ICsvConvertible data)
        {

            string Path =$"{FileLocations.ProjectFolder}\\Database";
            string type=data.GetType().ToString().Split(".").LastOrDefault();

          
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            string filePath = $"{Path}\\{type}.txt";

            File.AppendAllText(filePath, $"{data.GetValuesCSV()}\n" ) ;

        }

        public string GetOnNotepad(string Path) 
        {
            if (File.Exists(Path))
            {
                return File.ReadAllText(Path);
            }
            throw new Exception("file doesn't exist");
        }
    }
}
