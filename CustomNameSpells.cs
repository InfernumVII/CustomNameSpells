using System;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using CustomNameSpells.Config;

namespace CustomNameSpells;

[BepInPlugin("com.infernumvii.customnamespells", "CustomNameSpells", "1.0.0")]
public class CustomNameSpells : BaseUnityPlugin
{
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
