using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Whale : Animal
    {
        // Constructors
        public Whale(string name, string species, int age, string color, string habitat, string diet, double weight)
            :base(name, species, age, color, habitat, diet, weight)
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
        protected override string SoundMade {
            get { return "OOOOOOOOOOOO"; } 
        }
    }
}
