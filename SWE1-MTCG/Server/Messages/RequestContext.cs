﻿using Cards;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SWE1_MTCG
{
    public class RequestContext
    {
        public string message;

        public Dictionary<string, string> keyValues = new Dictionary<string, string>();
   
        public List<BaseCards> cardDeck = new List<BaseCards>();
        public List<BaseCards> cardCollection = new List<BaseCards>();

        public NetworkStream stream = null;

        public string GetUsernameFromDict()
        {
            foreach (KeyValuePair<string, string> entry in keyValues)
            {
                if (entry.Key == "UserName")
                    return entry.Value;
            }
            return "not Found";
        }
        public string GetPwdFromDict()
        {
            foreach (KeyValuePair<string, string> entry in keyValues)
            {
                if (entry.Key == "Password")
                    return entry.Value;
            }
            return "not Found";
        }
        public string GetEmailFromDict()
        {
            foreach (KeyValuePair<string, string> entry in keyValues)
            {
                if (entry.Key == "Email")
                    return entry.Value;
            }
            return "not Found";
        }
    }
    /*
        POST /messages HTTP/1.1
        Content-Type: text/plain; charset=utf-8
        Content-Lenght: 14
        Host: 127.0.0.1:6543
        UserName: riob
        Password: asdfa

        StartTheBattle
    */

}