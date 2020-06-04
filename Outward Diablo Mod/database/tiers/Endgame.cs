﻿using grindward.database.registers;
using grindward.database.tiers.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grindward.database.tiers
{
    class Endgame : Tier
    {
        public override string GetId()
        {
            return "endgame";
        }

        public override List<Weighted<Tier>> GetItemTierDropChances()
        {
            return new List<Weighted<Tier>>() {
                new Weighted<Tier>(this, 50),
                new Weighted<Tier>(Tiers.Instance.HighEnd, 20),
                new Weighted<Tier>(Tiers.Instance.HighEnd, 10)
            };
        }

        public override int GetTierNumber()
        {
            return 3;
        }

        public override float GetItemTierReq()
        {
            return 0.7F;
        }
        public override float GetMobTierReq()
        {
            return 3.5F;
        }
    }
}

