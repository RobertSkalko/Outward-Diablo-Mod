﻿using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grindward
{
    public class Configs
    {
        static String BALANCE_ENABLE_CATEGORY = Main.MODID + ".balance";

        public static Configs Instance = null;

        public ConfigEntry<bool> EnableDeathPenalties = newBool(BALANCE_ENABLE_CATEGORY, "Enable Additional Death Penalties", "Every death will be painful, you'll either lose money, gems etc.");
        public ConfigEntry<bool> EnableMerchantPrices = newBool(BALANCE_ENABLE_CATEGORY, "Enable Merchant price changes", "Makes it harder to earn money and increases shop prices, this also removes or heavily nerfs all money making methods that depend on buying ingredients like alchemy.");
        public ConfigEntry<bool> EnableExpensiveSkillCosts = newBool(BALANCE_ENABLE_CATEGORY, "Enable expensive skill costs");
        public ConfigEntry<bool> EnableNoRegenInHomeBed = newBool(BALANCE_ENABLE_CATEGORY, "Enable No Regen in Home/Inn Bed", "Stops hunger and food regen when resting in home or inn. Intention is to punish using the sleep system to wait for area respawns.");
        public ConfigEntry<bool> EnableStopTownDeployables = newBool(BALANCE_ENABLE_CATEGORY, "Enable Stop Town Deployables", "Stops you from putting tents, cooking pots etc in the middle of towns. Use your home instead. No more hobo camps!");
        public ConfigEntry<bool> EnableStatCaps = newBool(BALANCE_ENABLE_CATEGORY, "Enable Stat caps", "Caps stats like resistances and mana reduction, So you can't have 100% resistance for example.");
        public ConfigEntry<bool> EnableChanceToNotUseSigilStones = newBool(BALANCE_ENABLE_CATEGORY, "Enable Chance to not use Sigil stones", "Casting sigils has chance to not use them.");
        //public ConfigEntry<bool> EnableAmbushPenalties = newBool(BALANCE_ENABLE_CATEGORY, "Enable Ambush Penalties", "Ambushes pick a random penalty, like adding bleed to your character, or poison etc. This is to prevent ambushes being a good way to farm mobs.");

        private static ConfigEntry<bool> newBool(String category, String name, String desc="")
        {           
            return Main.Instance.Config.Bind<bool>(category, name, true, desc);
        }
      

        

    }
}
