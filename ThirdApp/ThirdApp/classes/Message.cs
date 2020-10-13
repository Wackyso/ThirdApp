using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdApp
{
    public class Message
    {

        public int login { get; set; }
        public string text { get; set; }
        

        public DateTime send_time { get; set; }

        /*public Message (int position, string text)
        {
            this.position = position;
            this.text = text;
        }*/
    }
}
