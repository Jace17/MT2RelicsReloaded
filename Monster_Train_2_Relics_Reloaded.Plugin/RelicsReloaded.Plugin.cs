using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using TrainworksReloaded.Core;
using TrainworksReloaded.Core.Extensions;

namespace Monster_Train_2_Relics_Reloaded.Plugin
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<bool>? addAdvancedPrototype;
        public static ConfigEntry<bool>? addBoonoftheBlacksmith;
        public static ConfigEntry<bool>? addCheatersHand;
        public static ConfigEntry<bool>? addConcussiveCoals;
        public static ConfigEntry<bool>? addConscriptionNotice;
        public static ConfigEntry<bool>? addFaultyLoader;
        public static ConfigEntry<bool>? addForeverFlame;
        public static ConfigEntry<bool>? addGoldenVault;
        public static ConfigEntry<bool>? addHammeredChestplates;
        public static ConfigEntry<bool>? addHellsBanners;
        public static ConfigEntry<bool>? addImprovedFirebox;
        public static ConfigEntry<bool>? addInfusedMallet;
        public static ConfigEntry<bool>? addIronDropcage;
        public static ConfigEntry<bool>? addLightsGift;
        public static ConfigEntry<bool>? addMarkofaChampion;
        public static ConfigEntry<bool>? addMarkofanExile;
        public static ConfigEntry<bool>? addPreciousPlating;
        public static ConfigEntry<bool>? addPyrewall;
        public static ConfigEntry<bool>? addRationingScales;
        public static ConfigEntry<bool>? addRefractingLenses;
        public static ConfigEntry<bool>? addTemperedTalisman;
        public static ConfigEntry<bool>? addTheFirstHellpact;
        public static ConfigEntry<bool>? addVaporFunnel;
        public static ConfigEntry<bool>? addWingedIndulgence;
        public static ConfigEntry<bool>? addWornGrindstone;

        public static ConfigEntry<bool>? addAbandonedStave;
        public static ConfigEntry<bool>? addBloodforBlood;
        public static ConfigEntry<bool>? addCrackedHelmet;
        public static ConfigEntry<bool>? addDantesCloak;
        public static ConfigEntry<bool>? addEmberStasis;
        public static ConfigEntry<bool>? addFrozenNostalgia;
        public static ConfigEntry<bool>? addHeavensGold;
        public static ConfigEntry<bool>? addHistoryoftheWorld;
        public static ConfigEntry<bool>? addImmortalityPotion;
        public static ConfigEntry<bool>? addPenitentRemains;
        public static ConfigEntry<bool>? addPetrifiedHeart;
        public static ConfigEntry<bool>? addRailforgersHammer;
        public static ConfigEntry<bool>? addShardofDivinity;
        public static ConfigEntry<bool>? addVialofTears;
        public static ConfigEntry<bool>? addWeatheredColdstones;

        internal static new ManualLogSource Logger = new(MyPluginInfo.PLUGIN_GUID);
        public void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;

            addAdvancedPrototype = Config.Bind("General", "AdvancedPrototype", true, "Add Advanced Prototype. (Steward units cards get +5Attack, +5Health, Damage Shield 2 and Multistrike 1.)");
            addBoonoftheBlacksmith = Config.Bind("General", "BoonoftheBlacksmith", true, "Add Boon of the Blacksmith. (Your Pyre gets +15Attack.)");
            addCheatersHand = Config.Bind("General", "CheatersHand", true, "Add Cheater's Hand. (Draw +1 each turn, then return 1 card to the top of your draw pile.)");
            addConcussiveCoals = Config.Bind("General", "ConcussiveCoals", true, "Add Concussive Coals. (50% chance to apply Dazed when an enemy unit enters your train.)");
            addConscriptionNotice = Config.Bind("General", "ConscriptionNotice", true, "Add Conscription Notice. (When you first summon your Champion, gain a random unit card with +10Attack, +10Health, -1Ember, and -1Capacity.)");
            addFaultyLoader = Config.Bind("General", "FaultyLoader", true, "Add Faulty Loader. (Apply Dazed 3 and Melee Weakness 1 to enemy units on the bottom floor in the first wave of combat.)");
            addForeverFlame = Config.Bind("General", "ForeverFlame", true, "Add Forever Flame. (Units cost -2Ember.)");
            addGoldenVault = Config.Bind("General", "GoldenVault", true, "Add Golden Vault. (As long as you have at least 25Gold, lose 25Gold when you take Pyre damage in combat instead of taking damage.)");
            addHammeredChestplates = Config.Bind("General", "HammeredChestplates", true, "Add Hammered Chestplates. (Friendly units get +5Health.)");
            addHellsBanners = Config.Bind("General", "HellsBanners", true, "Add Hell's Banners. (When you summon the second unit during a turn, gain 3Ember.)");
            addImprovedFirebox = Config.Bind("General", "ImprovedFirebox", true, "Add Improved Firebox. (Gain 7Ember on the first turn of battle.)");
            addInfusedMallet = Config.Bind("General", "InfusedMallet", true, "Add Infused Mallet. (25% chance to deal 5 damage when an enemy unit enters your train.)");
            addIronDropcage = Config.Bind("General", "IronDropcage", true, "Add Iron Dropcage. (Whenever you play a spell that would Ascend or Descend an enemy unit, also apply Dazed 2.)");
            addLightsGift = Config.Bind("General", "LightsGift", true, "Add Light's Gift. (Apply Dazed to enemy units when they enter the floor below the Pyre Room.)");
            addMarkofaChampion = Config.Bind("General", "MarkofaChampion", true, "Add Mark of a Champion. (When played, your Champion gains +50% attack.)");
            addMarkofanExile = Config.Bind("General", "MarkofanExile", true, "Add Mark of an Exile. (When played, your Champion gains +50% max health.)");
            addPreciousPlating = Config.Bind("General", "PreciousPlating", true, "Add Precious Plating. (Your Pyre gets +40Pyre Health.)");
            addPyrewall = Config.Bind("General", "Pyrewall", true, "Add Pyrewall. (Your Pyre starts each battle with Armor 15.)");
            addRationingScales = Config.Bind("General", "RationingScales", true, "Add Rationing Scales. (Before each battle, set Pyre health to 50. If this reduces Pyre health, gain 3Gold for each health lost.)");
            addRefractingLenses = Config.Bind("General", "RefractingLenses", true, "Add Refracting Lenses. (When a card with Consume is played, restore 5 Pyre health.)");
            addTemperedTalisman = Config.Bind("General", "TemperedTalisman", true, "Add Tempered Talisman. (+3 Magic Power.)");
            addTheFirstHellpact = Config.Bind("General", "TheFirstHellpact", true, "Add The First Hellpact. (X Cost cards get +3 to their X value when played.)");
            addVaporFunnel = Config.Bind("General", "VaporFunnel", true, "Add Vapor Funnel. (Apply Dazed to enemy units when they enter the Pyre Room. Your Pyre gets -5Attack.)");
            addWingedIndulgence = Config.Bind("General", "WingedIndulgence", true, "Add Winged Indulgence. (Enemies get -1Attack.)");
            addWornGrindstone = Config.Bind("General", "WornGrindstone", true, "Add Worn Grindstone. (Friendly units get +5Attack.)");

            addAbandonedStave = Config.Bind("General", "AbandonedStave", true, "Add Abandoned Stave. (+1Ember per turn for every 2 Blight cards in your deck.)");
            addBloodforBlood = Config.Bind("General", "BloodforBlood", true, "Add Blood for Blood. (When your Pyre kills a unit, restore 5 Pyre health.)");
            addCrackedHelmet = Config.Bind("General", "CrackedHelmet", true, "Add Cracked Helmet. (Damage spells get Piercing.)");
            addDantesCloak = Config.Bind("General", "DantesCloak", true, "Add Dante's Cloak. (+2 Magic Power' for every Blight card in your deck.)");
            addEmberStasis = Config.Bind("General", "EmberStasis", true, "Add Ember Stasis. (Playing a Blight card deals 120 damage to the front enemy unit.)");
            addFrozenNostalgia = Config.Bind("General", "FrozenNostalgia", true, "Add Frozen Nostalgia. (-1Capacity on each floor. +15 Magic Power.)");
            addHeavensGold = Config.Bind("General", "HeavensGold", true, "Add Heaven's Gold. (Your Pyre gets +1Attack for every 10Gold you have.)");
            addHistoryoftheWorld = Config.Bind("General", "HistoryoftheWorld", true, "Add History of the World. (+3Capacity on a random floor.)");
            addImmortalityPotion = Config.Bind("General", "ImmortalityPotion", true, "Add Immortality Potion. (Friendly non-Morsel units get Endless.)");
            addPenitentRemains = Config.Bind("General", "PenitentRemains", true, "Add Penitent Remains. (When summoned friendly units get +2Attack for every Blight card in your deck.)");
            addPetrifiedHeart = Config.Bind("General", "PetrifiedHeart", true, "Add Petrified Heart. (Friendly units get +10Health and Heartless.)");
            addRailforgersHammer = Config.Bind("General", "RailforgersHammer", true, "Add Railforger's Hammer. (+1Capacity on each floor.)");
            addShardofDivinity = Config.Bind("General", "ShardofDivinity", true, "Add Shard of Divinity. (Your Pyre starts each battle with Armor 100.)");
            addVialofTears = Config.Bind("General", "VialofTears", true, "Add Vial of Tears. (At end of turn, restore 5 health to friendly units.)");
            addWeatheredColdstones = Config.Bind("General", "WeatheredColdstones", true, "Add Weathered Coldstones. (When you play a Blight card, restore 5 Pyre health.)");

            List<String> paths = new List<string>
            {
                "json/plugin.json",
                "json/global.json",
            };

            // Clanless Artifacts 
            if (addAdvancedPrototype.Value) paths.Add("json/relics/advanced_prototype.json");
            if (addBoonoftheBlacksmith.Value) paths.Add("json/relics/boon_of_the_blacksmith.json");
            if (addCheatersHand.Value) paths.Add("json/relics/cheaters_hand.json");
            if (addConcussiveCoals.Value) paths.Add("json/relics/concussive_coals.json");
            if (addConscriptionNotice.Value) paths.Add("json/relics/conscription_notice.json");
            if (addFaultyLoader.Value) paths.Add("json/relics/faulty_loader.json");
            if (addForeverFlame.Value) paths.Add("json/relics/forever_flame.json");
            if (addGoldenVault.Value) paths.Add("json/relics/golden_vault.json");
            if (addHammeredChestplates.Value) paths.Add("json/relics/hammered_chestplates.json");
            if (addHellsBanners.Value) paths.Add("json/relics/hells_banners.json");
            if (addImprovedFirebox.Value) paths.Add("json/relics/improved_firebox.json");
            if (addInfusedMallet.Value) paths.Add("json/relics/infused_mallet.json");
            if (addIronDropcage.Value) paths.Add("json/relics/iron_dropcage.json");
            if (addLightsGift.Value) paths.Add("json/relics/lights_gift.json");
            if (addMarkofaChampion.Value) paths.Add("json/relics/mark_of_a_champion.json");
            if (addMarkofanExile.Value) paths.Add("json/relics/mark_of_an_exile.json");
            if (addPreciousPlating.Value) paths.Add("json/relics/precious_plating.json");
            if (addPyrewall.Value) paths.Add("json/relics/pyrewall.json");
            if (addRationingScales.Value) paths.Add("json/relics/rationing_scales.json");
            if (addRefractingLenses.Value) paths.Add("json/relics/refracting_lenses.json");
            if (addTemperedTalisman.Value) paths.Add("json/relics/tempered_talisman.json");
            if (addTheFirstHellpact.Value) paths.Add("json/relics/the_first_hellpact.json");
            if (addVaporFunnel.Value) paths.Add("json/relics/vapor_funnel.json");
            if (addWingedIndulgence.Value) paths.Add("json/relics/winged_indulgence.json");
            if (addWornGrindstone.Value) paths.Add("json/relics/worn_grindstone.json");

            // Event Artifacts
            if (addAbandonedStave.Value) paths.Add("json/relics/abandoned_stave.json");
            if (addBloodforBlood.Value) paths.Add("json/relics/blood_for_blood.json");
            if (addCrackedHelmet.Value) paths.Add("json/relics/cracked_helmet.json");
            if (addDantesCloak.Value) paths.Add("json/relics/dantes_cloak.json");
            if (addEmberStasis.Value) paths.Add("json/relics/ember_stasis.json");
            if (addFrozenNostalgia.Value) paths.Add("json/relics/frozen_nostalgia.json");
            if (addHeavensGold.Value) paths.Add("json/relics/heavens_gold.json");
            if (addHistoryoftheWorld.Value) paths.Add("json/relics/history_of_the_world.json");
            if (addImmortalityPotion.Value) paths.Add("json/relics/immortality_potion.json");
            if (addPenitentRemains.Value) paths.Add("json/relics/penitent_remains.json");
            if (addPetrifiedHeart.Value) paths.Add("json/relics/petrified_heart.json");
            if (addRailforgersHammer.Value) paths.Add("json/relics/railforgers_hammer.json");
            if (addShardofDivinity.Value) paths.Add("json/relics/shard_of_divinity.json");
            if (addVialofTears.Value) paths.Add("json/relics/vial_of_tears.json");
            if (addWeatheredColdstones.Value) paths.Add("json/relics/weathered_coldstones.json");

            var builder = Railhead.GetBuilder();
            builder.Configure(
                MyPluginInfo.PLUGIN_GUID,
                c =>
                {
                    // Be sure to include all of your json files if you add more.
                    // Be sure to update the project configuration if you include more folders
                    //   the project only copies json files in the json folder and not in subdirectories.
                    c.AddMergedJsonFile(paths);
                }
            );

            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

            // Uncomment if you need harmony patches, if you are writing your own custom effects.
            //var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            //harmony.PatchAll();
        }
    }
}
