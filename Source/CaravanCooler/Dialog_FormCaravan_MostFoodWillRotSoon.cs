using HarmonyLib;
using RimWorld;

namespace CaravanCooler;

[HarmonyPatch(typeof(Dialog_FormCaravan), "MostFoodWillRotSoon", MethodType.Getter)]
public static class Dialog_FormCaravan_MostFoodWillRotSoon
{
    public static void Postfix(Dialog_FormCaravan __instance, ref bool __result)
    {
        if (CaravanCooler.HasCoolerInTransferableItems(__instance.transferables))
        {
            __result = false;
        }
    }
}