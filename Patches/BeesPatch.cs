﻿using HarmonyLib;

namespace iiMenu.Patches
{
    [HarmonyPatch(typeof(AngryBeeSwarm), "RiseGrabbedLocalPlayer")]
    public class BeesPatch
    {
        public static bool enabled = false;

        public static bool Prefix() =>
            !enabled;
    }
}
