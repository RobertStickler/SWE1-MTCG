﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SWE1_MTCG
{
    public class MessageHandler
    {
        //###################################################################################
        public static RequestContext GetRequest(string data)
        {
            //Console.WriteLine(data);
            RequestContext request = new RequestContext();
            
            //die daten aus dem HTTP-Request extrahieren
            string[] line = data.Split("\n"); //Bei einem Enter trennen
            int tempcount = 1;
            /*
            try
            { */
                //zuerst die erste zeile einlesen
                string[] tempfirstline = line[0].Split(" "); //die erste Zeile an den Leerzeichen trennen
                request.keyValues.Add("method", tempfirstline[0]);
                request.keyValues.Add("path", tempfirstline[1]);
                request.keyValues.Add("version", tempfirstline[2]);

                foreach (string oneLine in line)
                {
                    if (tempcount == 1)
                    {
                        tempcount = 2;
                        continue;
                    }
                    if (oneLine == "")
                    {
                        tempcount = 3;
                        continue;
                    }

                    if (tempcount == 2)
                    {
                        string[] temp = oneLine.Split(":");
                        request.keyValues.Add(temp[0], temp[1].Trim(' '));
                    }
                    if (tempcount == 3)
                    {
                        request.message += oneLine;
                        request.message = request.message.Trim('\n', '\0');
                        request.message += "\n";
                    }    
            } 
            return request;
        }       
    }
}