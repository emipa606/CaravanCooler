using System.Collections.Generic;
using HarmonyLib;
using RimWorld.Planet;
using Verse;

namespace CaravanCooler;

[HarmonyPatch(typeof(DaysUntilRotCalculator))]
[HarmonyPatch("ApproxDaysUntilRot", typeof(List<Thing>), typeof(int), typeof(WorldPath), typeof(float), typeof(int))]
public static class WorldCaravanInfo
{
    [HarmonyPostfix]
    public static void NoRotIfCoolerPresent(List<Thing> potentiallyFood, ref float __result)
    {
        if (CaravanCooler.HasCoolerInListOfThings(potentiallyFood))
        {
            __result = float.PositiveInfinity;
        }
    }
}