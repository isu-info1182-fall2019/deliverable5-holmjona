using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
    /// <summary>
    /// Jon Holmes
    /// INFO 1182
    /// 12 September 2019
    /// Prof. Holmes
    /// Description: This is a person that can exist
    /// </summary>
    abstract class  Person {
        #region Private Variables / Attributes / Class-Level Variables / Fields
        private string _FirstName = "";
        private string _MiddleName = "";
        private string _LastName = "Smith";
        private DateTime _DateOfBirth = new DateTime(1950,1,1);
        #endregion

        #region Contructors
        public Person() {
            // Default constructor

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fName">Person's first Name</param>
        /// <param name="lName">Person's last name</param>
        public Person(string fName, string lName) {
            // Overloaded Constructor
            FirstName = fName;
            LastName = lName;
        }
        #endregion

        #region Properties
        public string FirstName {
            get { return _FirstName; }
            set {
                //string newFirst = value[0].ToString();
                //string restFirst = value.Substring(1, value.Length - 1);
                //_FirstName = newFirst.ToLower() + restFirst.ToUpper();
                _FirstName = value;
            }
        }
        public string LastName {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string MiddleName {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }

        public DateTime DateOfBirth {
            get { return _DateOfBirth; }
            set {
                if (value > DateTime.Now) {
                    // do nothing
                    // or
                    _DateOfBirth = DateTime.Now;
                } else {
                    _DateOfBirth = value;
                }
            }
        }


        #endregion

        #region Member Methods
        public abstract string SayYourName();
        //    {
        //    return String.Format("My name is {0}.",FirstName);
        //}
        public string SaySomething() {
            return "Something";
        }

        public override string ToString() {
            return "I am a Person named " + this.FirstName;
        }

        #endregion
    }
}
