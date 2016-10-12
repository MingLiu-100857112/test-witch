using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class StudentList
    {
        private List<Student> _students;

        public StudentList()
        {
            
        }
        public string StudentsInfo
        {
            get
            {
                string s = "";
                foreach (Student i in _students)
                    s = s + i.Status();
                return s;
            }
        }

        public List<Student> Students
        {
            get
            {
                if (_students == null)
                {
                    _students = new List<Student>();
                }
                return _students;
            }
        }

        public void Put(Student itm)
        {
            Students.Add(itm);
        }

        public Student Fetch(string id)
        {
            foreach (Student i in _students)
            {
                if (i.AreYou(id))
                {
                    return i;
                }
            }
            return null;
        }

        public Student StudentRandomAssigned(int i)
        {
            if (_students.ElementAt(i) != null)
                return _students.ElementAt(i);
            return null;
        }
    }
}
