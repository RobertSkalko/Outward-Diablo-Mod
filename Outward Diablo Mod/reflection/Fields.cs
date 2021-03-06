﻿using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace grindward
{
    class Fields
    {
        public static Fields INSTANCE = null;

        public SafeField<ItemDetailsDisplay, List<ItemDetailRowDisplay>> TOOLTIP = new SafeField<ItemDetailsDisplay, List<ItemDetailRowDisplay>>("m_detailRows");
        public SafeField<ItemManager, DictionaryExt<string, Item>> ItemManager_WorldItems = new SafeField<ItemManager, DictionaryExt<string, Item>>("m_worldItems");
        public SafeField<CharacterManager, DictionaryExt<string, string>> CharacterManager_Playerchars = new SafeField<CharacterManager, DictionaryExt<string, string>>("m_playerCharacters");
        public SafeField<CharacterManager, DictionaryExt<string, Character>> CharacterManager_chars = new SafeField<CharacterManager, DictionaryExt<string, Character>>("m_characters");
        public SafeField<CampingEvent,AISquad> CampingEvent_squadtospawn = new SafeField<CampingEvent, AISquad>("m_squadToSpawn");


        public SafeField<CharacterStats, float[]> CharStats_DmgResistance = new SafeField<CharacterStats, float[]>("m_totalDamageResistance");
        public SafeField<CharacterStats, Stat> CharStats_ManaUse = new SafeField<CharacterStats, Stat>("m_manaUseModifiers");

        public SafeField<LootableOnDeath, bool> LootableOnDeath_WasAlive = new SafeField<LootableOnDeath, bool>("m_wasAlive");
        public SafeField<LootableOnDeath, Dropable[]> LootableOnDeath_lootDroppers = new SafeField<LootableOnDeath, Dropable[]>("m_lootDroppers");

        public SafeField<Dropable, List<DropTable>> Dropable_lootables = new SafeField<Dropable, List<DropTable>>("m_mainDropTables");
        public SafeField<Dropable, List<GuaranteedDrop>> Dropable_guaranteedDrops = new SafeField<Dropable, List<GuaranteedDrop>>("m_allGuaranteedDrops");

        public SafeField<Item, Sprite> Item_Icon = new SafeField<Item, Sprite>("m_itemIcon");

        public SafeField<EquipmentStats, float[]> EquipmentStats_m_damageProtection = new SafeField<EquipmentStats, float[]>("m_damageProtection");
        public SafeField<EquipmentStats, float[]> EquipmentStats_m_damageResistance = new SafeField<EquipmentStats, float[]>("m_damageResistance");
                
        public SafeField<EquipmentStats, float[]> EquipmentStats_m_damageAttack = new SafeField<EquipmentStats, float[]>("m_damageAttack");
       
        public SafeField<EquipmentStats, float> EquipmentStats_m_impactResistance = new SafeField<EquipmentStats, float>("m_impactResistance");
        
        public SafeField<EquipmentStats, float> EquipmentStats_m_heatProtection = new SafeField<EquipmentStats, float>("m_heatProtection");
        public SafeField<EquipmentStats, float> EquipmentStats_m_coldProtection = new SafeField<EquipmentStats, float>("m_coldProtection");
        public SafeField<EquipmentStats, float> EquipmentStats_m_corruptionProtection = new SafeField<EquipmentStats, float>("m_corruptionProtection");
      
        public SafeField<EquipmentStats, float> EquipmentStats_m_movementPenalty = new SafeField<EquipmentStats, float>("m_movementPenalty");
        
     
        public SafeField<EquipmentStats, float> EquipmentStats_m_manaUsePenalty = new SafeField<EquipmentStats, float>("m_manaUseModifier");
        public SafeField<EquipmentStats, float> EquipmentStats_m_staminaUsePenalty = new SafeField<EquipmentStats, float>("m_staminaUsePenalty");

        public SafeField<EquipmentStats, float> EquipmentStats_m_maxHealthBonus = new SafeField<EquipmentStats, float>("m_maxHealthBonus"); 

        public SafeField<EquipmentStats, float> EquipmentStats_m_pouchCapacityBonus = new SafeField<EquipmentStats, float>("m_pouchCapacityBonus");
      

    }
}
