using HarmonyLib;
using RimWorld;

namespace CaravanCooler;

[HarmonyPatch(typeof(Dialog_FormCaravan), nameof(Dialog_FormCaravan.DoWindowContents))]
public static class FormCaravan_EachFrame
{
    public static void Postfix(Dialog_FormCaravan __instance)
    {
        CaravanInfo.transferables = [..__instance.transferables];
    }
}