using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    class Room: ISayTeacher
    {
        private int _Number;
        private Teacher _Teacher;

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


        public string SayTeacher()
        {
            return "Boo";
        }

    }



}
