using HarmonyLib;
using RimWorld;

namespace CaravanCooler;

[HarmonyPatch(typeof(Dialog_FormCaravan), "MostFoodWillRotSoon", MethodType.Getter)]
public static class FormCaravanWarning
{
    [HarmonyPostfix]
    public static void WillFoodRot(Dialog_FormCaravan __instance, ref bool __result)
    {
        if (CaravanCooler.HasCoolerInTransferableItems(__instance.transferables))
        {
            __result = false;
        }
    }
}