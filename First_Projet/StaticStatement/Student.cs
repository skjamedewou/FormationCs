using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStatement
{
    internal class Student
    {
        public static int StudentNumber { get; set; }
        public static void getAddNote() 
        {
            MessageBox.Show("Static");
        }
    }
}
