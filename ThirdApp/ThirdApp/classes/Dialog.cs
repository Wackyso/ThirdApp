using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdApp
{
    public class Dialog
    {
        public string login { get; set; }
        public int dialog_id { get; set; }
        public string interlocutor { get; set; }

        public Dialog(string Name, int ID, string interlocutor)
        {
            this.login = Name;
            this.dialog_id = ID;
            this.interlocutor = interlocutor;
        }
    }
}
