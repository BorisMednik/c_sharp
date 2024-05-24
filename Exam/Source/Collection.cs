using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam.Source
{
    public class Collection: Server
    {
        public List<Computer> collection = new List<Computer>();

        public Collection() 
        {             }

        public int Length { get { return collection.Count; } }
        
        

        //Add
        public void AddComputer (Computer computer) { collection.Add(computer); Notify(/*collection*/); }
        public void AddName(int Index, string name) { collection[Index].AddName(name); Notify(/*collection*/); }
        public void AddMemory(int Index, string mem) { collection[Index].AddMemory(mem); Notify(/*collection*/); }
        public void AddRam(int Index, string ram) { collection[Index].AddRam(ram); Notify(/*collection*/); }
        public void AddProcessor(int Index, string proc) { collection[Index].AddProcessor(proc); Notify(/*collection*/); }
        //Get
        public string GetName(int Index) { return collection[Index].Name; }
        public string GetProcessor(int Index) { return collection[Index].Processor; }
        public string GetRam(int Index) { return collection[Index].Ram; }
        public string GetMemory(int Index) { return collection[Index].Memory; }
        public Computer GetComputer(int Index) { return collection[Index]; }

        // Delete
        public void DeleteItem (int Index) { collection.Remove(collection[Index]); Notify(); }




    }
}
