using HarmonyLib;
using RimWorld;

namespace CaravanCooler;

[HarmonyPatch(typeof(Dialog_FormCaravan))]
[HarmonyPatch("PostClose")]
public static class FormCaravan_PostClose
{
    public static void Postfix()
    {
        CaravanInfo.transferables.Clear();
    }
}