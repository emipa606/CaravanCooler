using System.Linq;
using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace CaravanCooler;

[HarmonyPatch(typeof(Caravan), "TickInterval")]
public static class Caravan_TickInterval
{
    private static void Postfix(Caravan __instance)
    {
        if (!CaravanCooler.HasCoolerInListOfThings(__instance.AllThings.ToList()))
        {
            return;
        }

        var list = __instance.AllThings.ToList();
        foreach (var thing in list)
        {
            var compRottable = thing.TryGetComp<CompRottable>();
            compRottable?.RotProgress = 0f;
        }
    }
}