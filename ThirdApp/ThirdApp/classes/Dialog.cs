using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdApp
{
    public class Dialog
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Dialog(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
    }
}
