﻿using grindward.database.gear_types;
using grindward.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grindward
{
    public abstract class BaseAffixData<A> : ISaveToString where A : Affix 
    {

        protected String id = "";

        int percent = 0;


        public abstract A GetAffix();
        public abstract List<A> GetAll();

        public void Randomize(Item item)
        {

            GearType type = ItemUtils.GetGearType(item);

            if (type == null)
            {
                UnityEngine.Debug.Log("Gear Type is null? Aborting suffix generation.");
                return;
            }

            List<A> possible = GetAll().Where(x=> x.CanBeOnGearType(type)).ToList();

            if (possible.Count > 0)
            {
                A affix = RandomUtils.WeightedRandom(possible);

                this.id = affix.GetId();
                this.percent = new System.Random().Next(25, 100);

                UnityEngine.Debug.Log("Affix generated succesfully");
            }

        }

        public void ApplyToItem(Equipment item)
        {
            Affix affix = GetAffix();

            if (affix != null)
            {
                affix.GetVanillaStatMods().ForEach(x => x.ApplyToItem(percent, item));

            }
        }

       

        public string GetSaveString()
        {

            if (id == "" || percent == 0)
            {
                return "";
            }

            return id + "#" + percent;

        }

        public void LoadFromString(string str)
        {

           try
                {
                    UnityEngine.Debug.Log(str);

                    String[] parts = str.Split('#');
                    if (parts.Length == 2)
                    {
                        this.id = parts[0];
                        this.percent = int.Parse(parts[1]);

                        UnityEngine.Debug.Log("Loaded Affix: " + id + " " + percent);

                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            
        }
    }
}