using System;
using System.Collections.Generic;
using System.Text;

namespace TechnologyNS
{
    public class SmartPhone : Computer
    {
        public bool IsLocked { get; set; } = true;

        public SmartPhone(string user) : base(user)
        {
            AssignId();
        }
        public override string PlayMovie()
        {
            return "You cannot watch a movie from a disc";
        }
        public void Unlock()
        {
            IsLocked = false;
        }
    }
}
