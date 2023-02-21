using System.Collections.Generic;
using HarmonyLib;
using RimWorld;

namespace CaravanCooler;

[HarmonyPatch(typeof(Dialog_FormCaravan))]
[HarmonyPatch("DoWindowContents")]
public static class FormCaravan_EachFrame
{
    public static void Postfix(Dialog_FormCaravan __instance)
    {
        CaravanInfo.transferables = new List<TransferableOneWay>(__instance.transferables);
    }
}