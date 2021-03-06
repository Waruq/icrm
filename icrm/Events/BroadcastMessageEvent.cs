﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using icrm.Models;

namespace icrm.Events
{
    public class BroadcastMessageEventArgs : EventArgs
    {
        public BroadcastMessage BroadcastMessage { get; set; }
       // public List<String> Recievers { get; set; }
    }

    public class BroadcastMessageEvent
    {
        public  event EventHandler<BroadcastMessageEventArgs> MessageBroadcasted;

        public void broadcast(BroadcastMessage broadcastMessage)
        {
            Debug.Print("----firing event--------");
             OnMessageBroadcasted(broadcastMessage);
        }

        protected virtual void OnMessageBroadcasted(BroadcastMessage broadcastMessage)
        {
            Debug.Print("----firing event-----again---"+MessageBroadcasted);
            if (MessageBroadcasted != null)
                MessageBroadcasted(this, new BroadcastMessageEventArgs() { BroadcastMessage = broadcastMessage});
        }
    }
}