using System;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using CustomNameSpells.Config;

namespace CustomNameSpells;

[BepInPlugin("com.infernumvii.customnamespells", "CustomNameSpells", "1.0.2")]
[BepInProcess("MageArena.exe")]
[BepInDependency("com.magearena.modsync", BepInDependency.DependencyFlags.HardDependency)]
public class CustomNameSpells : BaseUnityPlugin
{
    public static string modsync = "all";
    private readonly Harmony harmony = new Harmony("com.infernumvii.customnamespells");
    internal static new ManualLogSource Logger;

    private void Awake()
    {
        Logger = base.Logger;
        VoiceCommandConfig.Init(Config);
        harmony.PatchAll();
        Logger.LogInfo("CustomNameSpells loaded!");
    }
    
    

}
