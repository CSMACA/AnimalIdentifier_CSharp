using System.Collections.Generic;

namespace AnimalIdentifier_Base
{

    public class TagData
    {
        public TagData(List<Tag> tags, string requestId)
        {
            this.tags = tags;
            this.RequestId = requestId;
        }

        public List<Tag> tags { get; set; }
        public string RequestId { get; set; }
    }
}
