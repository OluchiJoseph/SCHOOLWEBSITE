using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOLWEBSITE
{
    // Concept of abstraction
    public abstract class Individuals
    {
        //encapsulation concept demonstrated.
        //The Age variable is private to the Individuals class.
        //To set the Age Variable, use getters and setters
        private int Age; 
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public abstract string ValidateStatus();
        public abstract void Register();

    }

    // Concept of inheritance
    public class Students: Individuals
    {
        public override void Register()
        {
            throw new NotImplementedException();
        }

        public void ValidateResults()
        {

        }

        public override string ValidateStatus()
        {
            throw new NotImplementedException();
        }
    }

    public class Lecturers: Individuals // Concept of inheritance
    {
        
        // Concept of polymorphism. A lecturer is also an individual.
        // In this example, the lecturer is registering as an individual
        public override void Register()
        {
            throw new NotImplementedException();
        }

        public override string ValidateStatus()
        {
            throw new NotImplementedException();
        }
        public void GenerateResult() { }

    }
}
