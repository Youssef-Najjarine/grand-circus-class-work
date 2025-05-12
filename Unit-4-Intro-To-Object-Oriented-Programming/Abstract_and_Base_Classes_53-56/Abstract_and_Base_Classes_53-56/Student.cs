using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Student
    {
        // Fields
        private string[] _name = new string[1];
        private string[] _hometown;
        private string[] _favoriteFood;

        // Constructors
        public Student(string name, string homeTown, string favoriteFood)
        {
            _name[0] = name;
            this._hometown = new string[_name.Length];
            this._hometown[0] = homeTown;
            this._favoriteFood = new string[_name.Length];
            this._favoriteFood[0] = favoriteFood;
        }

        //Properties 
        public string Name
        {
            get { return this._name[0]; }
        }
        public string HomeTown
        {
            get { return this._hometown[0]; }
        }
        public string FavoriteFood
        {
            get { return this._favoriteFood[0]; }
        }
    }
}
