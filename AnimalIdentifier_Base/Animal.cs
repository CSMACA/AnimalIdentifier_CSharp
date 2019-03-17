namespace AnimalIdentifier_Base
{
    public class Animal
    {

        //Constructors
        public Animal(string animalName) => this.animalName = animalName;
        
        //Default
        public Animal() {} 

        //Members
        public string animalName { get; set; }
    }
}
