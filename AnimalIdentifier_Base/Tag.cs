namespace AnimalIdentifier_Base
{
    public class Tag
    {
        public Tag(string name, double confidence, string hint)
        {
            this.name = name;
            this.confidence = confidence;
            this.hint = hint;
        }

        public string name { get; set; }
        public double confidence { get; set; }
        public string hint { get; set; }
    }
}
