using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class inheritance
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal(4, 2, "white", "Oscar");
            cat.speak("Meow");
            Console.WriteLine("{0} has {1} legs, {2} eyes, and {3} coat",cat.getName(cat),cat.getNumLegs(cat), cat.getNumEyes(cat), cat.getColor(cat));
            Animal dog = new Animal(4, 2, "Black", "George");
            dog.speak("Woof");
            Console.WriteLine("{0} has {1} legs, {2} eyes, and {3} coat", dog.getName(dog), dog.getNumLegs(dog), dog.getNumEyes(dog), dog.getColor(dog));
            Console.ReadLine();
        }
    }

    public class Animal
    {
        private int _numLegs;
        private int _numEyes;
        private string _color;
        private string _name;

        public Animal(int numLegs, int numEyes, string color, string name)
        {
            this._numLegs = numLegs;
            this._numEyes = numEyes;
            this._color = color;
            this._name = name; 
        }

        public void speak(string someNoiseThatTheAnimalMakes)
        {
            Console.WriteLine(someNoiseThatTheAnimalMakes);
        }

        public int getNumLegs(Animal animal)
        {
            return this._numLegs;
        }

        public int getNumEyes(Animal animal)
        {
            return this._numEyes;
        }

        public string getColor(Animal animal)
        {
            return this._color;
        }

        public string getName(Animal animal)
        {
            return this._name;
        }
    }
}
