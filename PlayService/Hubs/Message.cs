﻿using PlayService.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayService.Hubs
{
    public class Message
    {
        public MessageType MessageType { get; set; }
        public object Data { get; set; }
        public Message(MessageType type, object data)
        {
            MessageType = type;
            Data = data;
        }
    }
}
