﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MMudObjects
{
    public class Room
    {
        int Map { get; set; }
        int RoomNumber { get; set; }
        String ShortDesc;
        String LongDesc;

        RoomLightEnum LightLevel;

        public List<RoomExit> RoomExits;
        public List<Item> VisibleItems;
        public List<Item> HiddenItems;
        public List<Entity> AlsoHere;

        public string Name { get; }

        public string Description { get; }

        Boolean IsSafe { get; set; }

        public Room()
        {
            this.RoomExits = new List<RoomExit>();
            this.VisibleItems = new List<Item>();
            this.HiddenItems = new List<Item>();
            this.AlsoHere = new List<Entity>();
        }

        public void Update(DataChangeItem dci)
        {
            switch (dci.TargetProperty)
            {
                case "Player.Room.ObviousExits":
                    string exits = dci.EndGroups[1].Value;
                    string[] tokens = exits.Split(new char[] { ',' });
                    this.RoomExits.Clear();
                    foreach (string t in tokens){
                        this.RoomExits.Add(new RoomExit(t));
                    }
                    break;
                case "Player.Room.ObviousItems":
                    string csv = dci.StartGroups[1].Value;
                    foreach (List<Group> lst in dci.Middle)
                    {
                        csv += lst[1].Value;
                    }
                    if(dci.EndPattern != null)
                    {
                        csv += dci.EndGroups[1].Value;
                    }
                    this.VisibleItems = Item.CreateListFromCsv(csv);
                    break;
                default:
                    break;
            }
        }

    }

    public enum RoomLightEnum
    {
        DARK,
        DIM,
        NORMAL,
        BRIGHT,
        BLINDING
    }

    public class Lair : Room
    {

    }

    public class Store: Room
    {
        List<StoreItemInfo> PossibleItems { get; set; }
        List<StoreItemInfo> CurrentItems { get; set; }
    }


}