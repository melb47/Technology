using System;
using System.Collections.Generic;
using System.Text;

namespace TechnologyNS
{
    public abstract class AbstractEntity
    {
        public static int nextObjectId = 1;
        public int objectId { get; set; }
        public void AssignId()
        {
            objectId = nextObjectId;
            nextObjectId++;
        }
    }
}
