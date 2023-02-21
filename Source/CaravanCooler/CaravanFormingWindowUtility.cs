using HarmonyLib;
using RimWorld.Planet;
using Verse;

namespace CaravanCooler;

[HarmonyPatch(typeof(CaravanUIUtility))]
[HarmonyPatch("GetDaysWorthOfFoodLabel")]
public static class CaravanFormingWindowUtility
{
    [HarmonyPostfix]
    public static void ReplaceFoodRotInfo(Pair<float, float> daysWorthOfFood, ref string __result)
    {
        if (daysWorthOfFood is { First: < 600f, Second: < 600f } &&
            daysWorthOfFood.Second < daysWorthOfFood.First &&
            CaravanCooler.HasCoolerInTransferableItems(CaravanInfo.transferables))
        {
            __result = daysWorthOfFood.First.ToString("0.#");
        }
    }
}