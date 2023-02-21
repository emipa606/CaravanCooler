using System.Linq;
using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace CaravanCooler;

[HarmonyPatch(typeof(Caravan))]
[HarmonyPatch("Tick")]
public static class WorldCaravanTick
{
    [HarmonyPostfix]
    private static void SetRotValuesToZero(Caravan __instance)
    {
        if (!CaravanCooler.HasCoolerInListOfThings(__instance.AllThings.ToList()))
        {
            return;
        }

        var list = __instance.AllThings.ToList();
        foreach (var thing in list)
        {
            var compRottable = thing.TryGetComp<CompRottable>();
            if (compRottable != null)
            {
                compRottable.RotProgress = 0f;
            }
        }
    }
}