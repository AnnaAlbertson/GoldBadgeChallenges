﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_Repository
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }
        public string BadgeName { get; set; }

        Badge() { }
        Badge(int badgeID, List<string> doorNames)
        {

        }
        Badge(int badgeID, List<string> doorNames, string badgeName)
        {

        }
    }
}
