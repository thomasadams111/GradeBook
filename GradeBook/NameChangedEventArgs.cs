using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class NameChangedEventArgs : EventArgs
    {
        public string exisitingName { get; set; }
        public string newName { get; set; }
    }
}
