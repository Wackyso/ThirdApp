using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ThirdApp
{
    public class request_objs
    {
        public string login;
        public string password;
        public int dialog_id;
        public string message;

        public request_objs (string login, string password) //аутентификация
        {
            this.login = login;
            this.password = password;
        }

        public request_objs( request_objs req_log, int dialog_id) //вход в диалог, создание диалога
        {
            this.login = req_log.login;
            this.password = req_log.password;
            this.dialog_id = dialog_id;
        }

        public request_objs(request_objs req_dialog, string message)// отправка сообщения 
        {
            this.login = req_dialog.login;
            this.password = req_dialog.password;
            this.dialog_id = req_dialog.dialog_id;
            this.message = message;
        }
    }

    

    public class request_cra // create acc +
    {
        public string login;
        public string password;
    }

    

    public class request_crd // create dialog +
    {
        public string login;
        public string password;
        public string interlocutor;
    }

    public class request_mes // new message +
    {
        public string login;
        public string password;
        public int dialog_id;
        public string text;
        public DateTime send_time { get; set; }
    }
}
