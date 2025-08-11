using System.Security.Policy;
using BepInEx.Configuration;

namespace CustomNameSpells.Config
{
    public static class VoiceCommandConfig
    {
        public static ConfigEntry<string> FireballCommand;
        public static ConfigEntry<string> FrostBoltCommand;
        public static ConfigEntry<string> WormCommand;
        public static ConfigEntry<string> HoleCommand;
        public static ConfigEntry<string> MagicMissileCommand;
        public static ConfigEntry<string> MirrorCommand;
        
        public static ConfigEntry<string> RockCommand;
        public static ConfigEntry<string> WispCommand;
        public static ConfigEntry<string> BlastCommand;
        public static ConfigEntry<string> DivineCommand;
        public static ConfigEntry<string> BlinkCommand;
        public static ConfigEntry<string> ThunderboltCommand;

        public static void Init(ConfigFile config)
        {
            FireballCommand = config.Bind("Commands", "Fireball", "fire ball fireball", 
                "Command for Fireball spell (all variants of the word can be separated by a space)");
                
            FrostBoltCommand = config.Bind("Commands", "FrostBolt", "freeze ease",
                "Command for Frost Bolt spell (all variants of the word can be separated by a space)");
                
            WormCommand = config.Bind("Commands", "Worm", "worm",
                "Command for Worm spell (all variants of the word can be separated by a space)");
                
            HoleCommand = config.Bind("Commands", "Hole", "hole",
                "Command for Hole spell (all variants of the word can be separated by a space)");
                
            MagicMissileCommand = config.Bind("Commands", "MagicMissile", "magic missile",
                "Command for Magic Missile spell (all variants of the word can be separated by a space)");
                
            MirrorCommand = config.Bind("Commands", "Mirror", "mirror",
                "Command for Mirror spell (all variants of the word can be separated by a space)");
                
            RockCommand = config.Bind("AdditionalCommands", "Rock", "rock",
                "Command for Rock spell (all variants of the word can be separated by a space)");
                
            WispCommand = config.Bind("AdditionalCommands", "Wisp", "wisp",
                "Command for Wisp spell (all variants of the word can be separated by a space)");
                
            BlastCommand = config.Bind("AdditionalCommands", "Blast", "dark blast",
                "Command for Blast spell (all variants of the word can be separated by a space)");
                
            DivineCommand = config.Bind("AdditionalCommands", "Divine", "divine light",
                "Command for Divine spell (all variants of the word can be separated by a space)");
                
            BlinkCommand = config.Bind("AdditionalCommands", "Blink", "blink",
                "Command for Blink spell (all variants of the word can be separated by a space)");
                
            ThunderboltCommand = config.Bind("AdditionalCommands", "Thunderbolt", "thunderbolt thunder bolt",
                "Command for Thunderbolt spell (all variants of the word can be separated by a space)");
        }
    }
}