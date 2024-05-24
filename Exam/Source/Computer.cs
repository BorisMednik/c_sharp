using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Source
{
    public class Computer
    {
        public static int LastID { get; set; } = 0;
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public string Processor { get; set; } = "";
        public string Ram { get; set; } = "";
        public string Memory { get; set; } = "";

        public Computer() { this.ID = LastID; LastID++; }
        public Computer( string name) { this.ID = LastID; LastID++; this.Name = name; }
        public Computer(string name, string proc) { this.ID = LastID; LastID++; this.Name = name; this.Processor = proc; }
        public Computer(string name, string proc, string ram) { this.ID = LastID; LastID++; this.Name = name; this.Processor = proc;this.Ram = ram; }
        public Computer(string name, string proc, string ram, string mem) { this.ID = LastID; LastID++; this.Name = name; this.Processor = proc; this.Ram = ram; this.Memory = mem; }

        public void AddName(string name) { this.Name = name;}
        public void AddRam (string ram) { this.Ram = ram;}
        public void AddMemory(string mem) { this.Memory = mem; }
        public void AddProcessor(string proc) { this.Processor = proc; }
        public int GetID() { return this.ID; }
    }
}
