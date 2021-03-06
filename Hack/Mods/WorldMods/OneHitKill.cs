﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPForestTrn.Hack.Managers;
using UnityEngine;

namespace PPForestTrn.Hack.Mods.WorldMods
{
    class OneHitKill : Module
    {
        public OneHitKill() : base("One Hit Kills", KeyCode.K, Categories.mWorld, GuiNames.Toggle)
        {
        }

        public static bool shouldOneHitKill = false;

        public override void onEnable()
        {
            shouldOneHitKill = true;
        }

        public override void onDisable()
        {
            shouldOneHitKill = false;
        }
    }
}
