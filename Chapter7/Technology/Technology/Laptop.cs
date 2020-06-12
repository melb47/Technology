using System;
using System.Collections.Generic;
using System.Text;

namespace TechnologyNS
{
    public class Laptop : Computer
    {
        public readonly bool HasDiscDrive;

        public Laptop(string user, bool hasDiscDrive) : base(user)
        {
            HasDiscDrive = hasDiscDrive;
            AssignId();
        }
        public override string PlayMovie()
        {
            if (HasDiscDrive)
            {
                return base.PlayMovie();
            }
            else
            {
                return "You don't have a disc drive to play a movie";
            }
        }
        public void ShutLid()
        {
            PowerOn = true;
            InternetConnected = false;
        }
    }
}
