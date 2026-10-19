using System.Collections.Generic;
using HarmonyLib;
using RimWorld.Planet;
using Verse;

namespace CaravanCooler;

[HarmonyPatch(typeof(DaysUntilRotCalculator), nameof(DaysUntilRotCalculator.ApproxDaysUntilRot), typeof(List<Thing>),
    typeof(PlanetTile), typeof(WorldPath), typeof(float), typeof(int))]
public static class DaysUntilRotCalculator_ApproxDaysUntilRot
{
    public static void Postfix(List<Thing> potentiallyFood, ref float __result)
    {
        if (CaravanCooler.HasCoolerInListOfThings(potentiallyFood))
        {
            __result = float.PositiveInfinity;
        }
    }
}