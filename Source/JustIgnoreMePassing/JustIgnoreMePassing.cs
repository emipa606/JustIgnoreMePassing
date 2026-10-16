using System.Reflection;
using HarmonyLib;
using Verse;

namespace JustIgnoreMePassing;

[StaticConstructorOnStartup]
public static class JustIgnoreMePassing
{
    static JustIgnoreMePassing()
    {
        new Harmony("net.pardeike.rimworld.mod.just-ignore-me-passing").PatchAll(Assembly.GetExecutingAssembly());
    }
}