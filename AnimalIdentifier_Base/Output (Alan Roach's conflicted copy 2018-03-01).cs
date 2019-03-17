using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    //I know why this doesn't work, but I don't know how to change it.
    //The class Animal contains a string "animalName" but it doesn't have a value. Because this Output function only inherits from
    //Animal, it doesn't ever get any of the overrides from the child classes.
    //I don't see a way to have this output class inherit from all 3 of them, which would be the simplest solution, because
    //C# doesn't support multiple inheritance without interfaces, which would require a lot of rewriting to implement, and I don't think
    //that that is what you were aiming for.
    //I could fix it by changing the way it checks the tags, but that would mean eliminating our polymorphic variable.

    class Output : Animal
    {
        public override void doesContain(List<Tag> tagList)
        {
            foreach (Tag tag in tagList)
                {
                    if (tag.name == animalName)
                    {
                        Console.WriteLine("This contains a " + animalName);
                    }
                }
        }
    }
}
