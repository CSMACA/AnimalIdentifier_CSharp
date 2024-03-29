﻿using System;
using System.Collections.Generic;
namespace AnimalIdentifier_Base
{
    static internal class ProgramText
    {

        static void Main()
        {
            List<Tag> tags = Input.input();
            
            Console.WriteLine("These are the tags generated by the image, with a confidence of greater than 80%: ");
            if (tags != null) //Exception handling
            {

                foreach (Tag tag in tags)
                {
                    if (tag.confidence >= .80)
                    {
                        Console.WriteLine(tag.name + " with a confidence = " + (Math.Round(tag.confidence*100,3) + "%"));
                    }
                }
                Console.WriteLine();

                foreach (var animal in new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Bird()

            })
                {
                    animal.doesContain(animal.confidenceCheck(tags));
                };
            }
            else
            {
                Console.WriteLine("We're sorry, but the image did not return any tags. The program will now terminate.");
                
            }
            
            Console.WriteLine("Press Any Key to Continue.");
            Console.ReadLine();
        }
    }
}
