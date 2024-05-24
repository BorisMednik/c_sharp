using Exam.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Run
    {
        //    static Run() { }
        //    private Run() { }

        //    private static readonly Run source = new Run();
        //    public static Run Source
        //    {
        //        get
        //        {
        //            return source;
        //        }
        //    }
        //}
        private static readonly Lazy<Run> lazy =
            new Lazy<Run>(() => new Run());

        public static Run Instance { get { return lazy.Value; } }

        private Run()
        {
            
        }
       public Collection spisok = new Collection();
    }
}
