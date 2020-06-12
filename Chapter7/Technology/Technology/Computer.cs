using System;
using System.Collections.Generic;
using System.Text;

namespace TechnologyNS
{
    public class Computer : AbstractEntity
    {
        public string User { get; set; }
        public bool PowerOn { get; set; } = false;
        public bool InternetConnected { get; set; } = false;


        public Computer(string user)
        {
            User = user;
            AssignId();

        }
        public void TurnOn()
        {
            PowerOn = true;
            InternetConnected = true;
        }
        public virtual string PlayMovie()
        {
            if(PowerOn && InternetConnected)
            {
                return "Insert Disc";
            }
            else
            {
                return "You gotta turn it on first";
            }
        }       
    }
}
