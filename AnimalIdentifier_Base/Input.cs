using System.Collections.Generic;

namespace AnimalIdentifier_Base
{
    class C_Input
    {
        public static List<Tag> Input(string inputPath)
        {
            //Create new Image Tagger, then make a list of tags for the file.
            ImageTagger animalImageTagger = new ImageTagger();
            List<Tag> tags = animalImageTagger.GetTagsForImage(inputPath);
            return tags;
        }
    }
}
