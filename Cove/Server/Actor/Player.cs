﻿using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cove.GodotFormat;

namespace Cove.Server.Actor
{
    public class WFPlayer : WFActor
    {
        public SteamId SteamId { get; set; }
        public string FisherID { get; set; }
        public string FisherName { get; set; }

        public WFPlayer(SteamId id, string fisherName) : base(0, "player", Vector3.zero)
        {
            SteamId = id;
            string randomID = new string(Enumerable.Range(0, 3).Select(_ => "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"[new Random().Next(36)]).ToArray());
            FisherID = randomID;
            FisherName = fisherName;

            pos = new Vector3(0, 0, 0);
        }
    };
}