using HarmonyLib;
using Verse;

namespace JustIgnoreMePassing;

[StaticConstructorOnStartup]
public static class JustIgnoreMePassing
{
    static JustIgnoreMePassing()
    {
        var harmony = new Harmony("net.pardeike.rimworld.mod.just-ignore-me-passing");
        harmony.PatchAll();
    }
}