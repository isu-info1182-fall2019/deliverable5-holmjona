using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    class Room : ISayTeacher
    {
        private int _Number;
        private Teacher _Teacher;
        private Student[] _Students = new Student[6];

        public int Number {
            get { return _Number; }
            set { _Number = value; }
        }

        public Teacher Teacher {
            get {
                return _Teacher;
            }
            set {
                _Teacher = value;
            }
        }

        public Student[] Students {
            get {
                return _Students;
            }
            set {
                _Students = value;
            }
        }


        public string SayTeacher()
        {
            return "Boo";
        }

    }



}
