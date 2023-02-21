using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace CaravanCooler;

[StaticConstructorOnStartup]
public class CaravanCooler
{
    static CaravanCooler()
    {
        var harmony = new Harmony("com.github.toywalrus.caravancooler");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    public static bool WillFoodRot(List<TransferableOneWay> items)
    {
        return !HasCoolerInTransferableItems(items);
    }

    public static bool HasCoolerInTransferableItems(List<TransferableOneWay> items)
    {
        foreach (var transferableOneWay in items)
        {
            if (transferableOneWay.CountToTransfer > 0 &&
                transferableOneWay.ThingDef == CaravanCoolerDefOf.CaravanCooler)
            {
                return true;
            }
        }

        return false;
    }

    public static bool HasCoolerInListOfThings(List<Thing> items)
    {
        foreach (var thing in items)
        {
            if (thing.def == CaravanCoolerDefOf.CaravanCooler)
            {
                return true;
            }
        }

        return false;
    }
}