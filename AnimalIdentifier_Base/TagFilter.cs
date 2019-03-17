using System;
using System.Collections.Generic;

namespace AnimalIdentifier_Base
{
    public class TagFilter : Animal
    {
        public List<Tag> Filter(List<Tag> tags)
        {
            List<Tag> filteredList = new List<Tag>();

            foreach (Tag tag in tags)
            {
                if (tag.confidence >= .8)
                {
                    List<Animal> animalNames = new List<Animal>() { new Cat(), new Dog(), new Bird() };
                    foreach (var type in animalNames)
                    {
                        if (tag.name == animalName)
                        {
                            filteredList.Add(tag);
                        }
                    }

                    Console.WriteLine(tags);
                }
            }
            return filteredList;
        }
    }
}
