﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2WooxTravel_New.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}