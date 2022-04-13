using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Subject
    {
        public string SubjectName { get; set; }

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
        }
    }
}
