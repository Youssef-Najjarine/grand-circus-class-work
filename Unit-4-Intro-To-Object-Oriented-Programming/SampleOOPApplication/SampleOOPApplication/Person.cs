using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOPApplication
{
    internal class Person
    {
        // Attributes: Name, Height, Weight, Age, Gender, EyeColor, HairColor

        // Fields
        private string _Name;
        private int _HeightInInches;
        private double _WeightInPounds;
        private int _Age;
        private string _Gender;
        private string _EyeColor;
        private string _HairColor;

        // Properties
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int HeightInInches
        {
            get { return _HeightInInches; }
            set { _HeightInInches = value; }
        }
        public double WeightInPounds
        {
            get { return _WeightInPounds; }
            set { _WeightInPounds = value; }
        }
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        public string EyeColor
        {
            get { return _EyeColor; }
            set { _EyeColor = value; }
        }
        public string HairColor
        {
            get { return _HairColor; }
            set { _HairColor = value; }
        }

        // Constructors
        public Person(string name, int HeightInInches, double weightInPounds, int age, string gender, string eyeColor, string hairColor)
        {
            _Name = name;
            _HeightInInches = HeightInInches;
            _WeightInPounds = weightInPounds;
            _Age = age;
            _Gender = gender;
            _EyeColor = eyeColor;
            _HairColor = hairColor;
        }

        // Methods
        public override string ToString() {
            return $"{_Name} {_HeightInInches} inches {_Gender} {Age} years old.";
        }
        //public override bool Equals(object obj) { }
        //public override int GetHashCode() { }
    }
}
