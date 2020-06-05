﻿using grindward.database;
using grindward.database.registers;
using grindward.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace grindward.save_data
{
    public class RandomStatsData : ISaveToString
    {
        List<int> percents = new List<int>();

        public void Randomize(Equipment item)
        {
            Equipment def = (Equipment)Cached.GetDefaultItemPrefab(item);

            foreach(VanillaStat stat in VanillaStats.Instance.GetAllStatsOrderedByIndex())
            {
                float val = stat.GetStat(def);

                if (val != 0)
                {
                    percents.Add(RollPercent());
                }
            }

        }

        int RollPercent()
        {
            return UnityEngine.Random.Range(50, 100);
        }

        public void ApplyToItem(Equipment item)
        {
            Equipment def = (Equipment)Cached.GetDefaultItemPrefab(item);

            int index = 0;

            var stats = VanillaStats.Instance.GetAllStatsItemHasOrderedByIndex(item);

            while( percents.Count < stats.Count)
            {
                percents.Add(RollPercent());
            }

            foreach (VanillaStat stat in stats)
            {           
                float defaultVal = stat.GetStat(def);

                if (defaultVal != 0)
                {
                    float currentVal = stat.GetStat(item);

                    float shouldBe = percents[index] * defaultVal / 100F ;

                    int diff = (int)(shouldBe - defaultVal); // we want pretty numbers

                    stat.SetStat(item, currentVal + diff);
                }

                index++;
            }
        }

        public string GetSaveString()
        {
            return String.Join("#", percents);
        }

        public void LoadFromString(string str)
        {
           foreach ( String s in str.Split('#'))
            {
                int perc = int.Parse(s);
                percents.Add(perc);
            }
        }
    }
}