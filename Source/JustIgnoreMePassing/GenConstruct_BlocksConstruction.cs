using HarmonyLib;
using RimWorld;
using Verse;

namespace JustIgnoreMePassing;

[HarmonyPatch(typeof(GenConstruct), nameof(GenConstruct.BlocksConstruction))]
internal static class GenConstruct_BlocksConstruction
{
    public static bool Prefix(ref bool __result, Thing t)
    {
        if (t is not Pawn)
        {
            return true;
        }

        __result = false;
        return false;
    }
}