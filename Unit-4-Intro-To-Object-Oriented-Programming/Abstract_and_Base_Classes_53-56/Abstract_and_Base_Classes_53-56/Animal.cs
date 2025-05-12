using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal abstract class Animal
    {
        // Fields
        protected string _name;
        protected string _species;
        protected int _age;
        protected string _color;
        protected string _habitat;
        protected string _diet;
        protected double _weightInPounds;
        // Constructors
        protected Animal(string name, string species, int age, string color, string habitat, string diet, double weight)
        {
            this._name = name;
            this._species = species;
            this._age = age;
            this._color = color;
            this._habitat = habitat;
            this._diet = diet;
            this._weightInPounds = weight;
        }

        // Properties
        protected abstract string SoundMade{ get;}
        // Methods
        public override string ToString()
        {
            return $"The animal name is {this._name}. It's specie type is {this._species}. Its age is {this._age}. Its color is {this._color}. The habitat for a {this._species} is the {this._habitat}. Its diet is primarily {this._diet}. It weighs {this._weightInPounds} pounds. The sound it makes is {this.SoundMade}.";
        }
    }
}
