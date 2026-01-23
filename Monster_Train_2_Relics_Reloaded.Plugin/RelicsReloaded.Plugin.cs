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

            addAdvancedPrototype = Config.Bind("General", "AdvancedPrototype", true, "Enable Advanced Prototype. (Steward units cards get +5Attack, +5Health, Damage Shield 2 and Multistrike 1.)\n启用进阶原型（乘务员单位卡牌获得 +5 攻击力，+5 生命值，伤害护盾 2，多重攻击 1）。");
            addBoonoftheBlacksmith = Config.Bind("General", "BoonoftheBlacksmith", true, "Enable Boon of the Blacksmith. (Your Pyre gets +15Attack.)\n启用铁匠祝福（你的薪火 +15 攻击力）。");
            addCheatersHand = Config.Bind("General", "CheatersHand", true, "Enable Cheater's Hand. (Draw +1 each turn, then return 1 card to the top of your draw pile.)\n启用老千的手牌（每回合抽 +1 张牌，然后将一张牌放回你的抽牌堆顶部）。");
            addConcussiveCoals = Config.Bind("General", "ConcussiveCoals", true, "Enable Concussive Coals. (50% chance to apply Dazed 1 when an enemy unit enters your train.)\n启用震荡煤块（当敌方单位进入火车时，有 50% 的几率对其施加眩晕 1）。");
            addConscriptionNotice = Config.Bind("General", "ConscriptionNotice", true, "Enable Conscription Notice. (When you first summon your Champion, gain a random unit card with +10Attack, +10Health, -1Ember, and -1Capacity.)\n启用征兵启事（当你首次召唤勇者时，随机获得一张单位牌，且该单位拥有 +10 攻击力， +10 生命值，-1 余烬费用，-1 容量费用）。");
            addFaultyLoader = Config.Bind("General", "FaultyLoader", true, "Enable Faulty Loader. (Apply Dazed 3 and Melee Weakness 1 to enemy units on the bottom floor in the first wave of combat.)\n启用心的装货工（对战斗中来袭的第一波位于底层的敌方单位施加眩晕 3，近战易伤 1）。");
            addForeverFlame = Config.Bind("General", "ForeverFlame", true, "Enable Forever Flame. (Units cost -2Ember.)\n启用永恒之火（所有单位费用 -2 余烬）。");
            addGoldenVault = Config.Bind("General", "GoldenVault", true, "Enable Golden Vault. (As long as you have at least 25Gold, lose 25Gold when you take Pyre damage in combat instead of taking damage.)\n启用金色宝库（只要你拥有至少 25 金币，当你的薪火在战斗中受到伤害时，不会损失生命值，改为损失 25 金币）。");
            addHammeredChestplates = Config.Bind("General", "HammeredChestplates", true, "Enable Hammered Chestplates. (Friendly units get +5Health.)\n启用锻造板甲（友方单位获得 +5 生命值）。");
            addHellsBanners = Config.Bind("General", "HellsBanners", true, "Enable Hell's Banners. (When you summon the second unit during a turn, gain 3Ember.)\n启用地狱战旗（当你在同一回合内召唤第二个单位时，获得 3 余烬）。");
            addImprovedFirebox = Config.Bind("General", "ImprovedFirebox", true, "Enable Improved Firebox. (Gain 7Ember on the first turn of battle.)\n启用强化炉膛（在部署阶段之后的回合，获得 7 余烬）。");
            addInfusedMallet = Config.Bind("General", "InfusedMallet", true, "Enable Infused Mallet. (50% chance to deal 5 damage when an enemy unit enters your train.)\n启用能量锻锤（当敌方单位进入火车时，有 50% 的几率对其造成 5 点伤害）。");
            addIronDropcage = Config.Bind("General", "IronDropcage", true, "Enable Iron Dropcage. (Whenever you play a spell that would Ascend or Descend an enemy unit, also apply Dazed 2.)\n启用铁质吊笼（当你用法术令敌方单位上升或下降时，对其施加眩晕 2）。");
            addLightsGift = Config.Bind("General", "LightsGift", true, "Enable Light's Gift. (Apply Dazed 2 to enemy units when they enter the floor below the Pyre Room.)\n启用圣光之礼（当敌方单位进入薪火室下方的楼层时，对其施加眩晕 2）。");
            addMarkofaChampion = Config.Bind("General", "MarkofaChampion", true, "Enable Mark of a Champion. (When played, your Champion gains +50% attack.)\n启用勇者的印记（当你召唤勇者时，使其获得 +50% 攻击力）。");
            addMarkofanExile = Config.Bind("General", "MarkofanExile", true, "Enable Mark of an Exile. (When played, your Champion gains +50% max health.)\n启用流亡者的印记（当你召唤勇者时，使其获得 +50% 最大生命值）。");
            addPreciousPlating = Config.Bind("General", "PreciousPlating", true, "Enable Precious Plating. (Your Pyre gets +40Pyre Health.)\n启用贵重金属（你的薪火 +40 薪火生命值）。");
            addPyrewall = Config.Bind("General", "Pyrewall", true, "Enable Pyrewall. (Your Pyre starts each battle with Armor 15.)\n启用薪火护墙（战斗开始时，你的薪火获得护甲 15）。");
            addRationingScales = Config.Bind("General", "RationingScales", true, "Enable Rationing Scales. (Before each battle, set Pyre health to 50. If this reduces Pyre health, gain 3Gold for each health lost.)\n启用定量配给（每次战斗开始前，将薪火生命值设为 50 点。如果这导致薪火失去生命值，则每失去 1 点生命值，获得 3 金币）。");
            addRefractingLenses = Config.Bind("General", "RefractingLenses", true, "Enable Refracting Lenses. (When a card with Consume is played, restore 5 Pyre health.)\n启用折射透镜（每当打出具有消耗的卡牌时，薪火恢复 5 点生命值）。");
            addTemperedTalisman = Config.Bind("General", "TemperedTalisman", true, "Enable Tempered Talisman. (+10 Magic Power.)\n启用淬炼护符（+10 魔法强度）。");
            addTheFirstHellpact = Config.Bind("General", "TheFirstHellpact", true, "Enable The First Hellpact. (X Cost cards get +3 to their X value when played.)\n启用最初的地狱契约（当打出费用为 X 的卡牌时，X 的值 +3）。");
            addVaporFunnel = Config.Bind("General", "VaporFunnel", true, "Enable Vapor Funnel. (Apply Dazed 1 to enemy units when they enter the Pyre Room. Your Pyre gets -5Attack.)\n启用蒸汽漏斗（当敌方单位进入薪火室时，对其施加眩晕 1，你的薪火获得 -5 攻击力）。");
            addWingedIndulgence = Config.Bind("General", "WingedIndulgence", true, "Enable Winged Indulgence. (Enemies get -1Attack.)\n启用骄奢淫翼（使所有敌方单位获得 -1 攻击力）。");
            addWornGrindstone = Config.Bind("General", "WornGrindstone", true, "Enable Worn Grindstone. (Friendly units get +5Attack.)\n启用磨损砂轮（使所有友方单位获得 +5 攻击力）。");

            addAbandonedStave = Config.Bind("General", "AbandonedStave", true, "Enable Abandoned Stave. (+1Ember per turn for every 2 Blight cards in your deck.)\n启用遗弃锤棍（卡组里每有 2 张祸患卡牌，每回合获得 +1 余烬）。");
            addBloodforBlood = Config.Bind("General", "BloodforBlood", true, "Enable Blood for Blood. (When your Pyre kills a unit, restore 5 Pyre health.)\n启用以血还血（当薪火消灭一个单位时，恢复 5 点生命值）。");
            addCrackedHelmet = Config.Bind("General", "CrackedHelmet", true, "Enable Cracked Helmet. (Damage spells get Piercing.)\n启用裂纹头盔（所有伤害性法术获得穿刺）。");
            addDantesCloak = Config.Bind("General", "DantesCloak", true, "Enable Dante's Cloak. (+2 Magic Power' for every Blight card in your deck.)\n启用但丁的斗篷（卡组里每有一张祸患卡牌，获得 +2 魔法强度）。");
            addEmberStasis = Config.Bind("General", "EmberStasis", true, "Enable Ember Stasis. (Playing a Blight card deals 120 damage to the front enemy unit.)\n启用静态余烬（每当打出一张祸患牌时，都会对前排敌方单位造成 120 点伤害）。");
            addFrozenNostalgia = Config.Bind("General", "FrozenNostalgia", true, "Enable Frozen Nostalgia. (-1Capacity on each floor. +20 Magic Power.)\n启用冰凝旧日（每层 -1 容量，+20 魔法强度）。");
            addHeavensGold = Config.Bind("General", "HeavensGold", true, "Enable Heaven's Gold. (Your Pyre gets +1Attack for every 10Gold you have.)\n启用天堂的金币（每拥有 10 金币，你的薪火就获得 +1 攻击力）。");
            addHistoryoftheWorld = Config.Bind("General", "HistoryoftheWorld", true, "Enable History of the World. (+3Capacity on a random floor.)\n启用世界史（随机一层 +3 容量）。");
            addImmortalityPotion = Config.Bind("General", "ImmortalityPotion", true, "Enable Immortality Potion. (Friendly non-Morsel units get Endless.)\n启用永生药剂（友方非影裔单位获得复生）。");
            addPenitentRemains = Config.Bind("General", "PenitentRemains", true, "Enable Penitent Remains. (When summoned friendly units get +2Attack for every Blight card in your deck.)\n启用忏悔遗骨（召唤时，卡组里每有一张祸患卡牌，友方单位获得 +2 攻击力）。");
            addPetrifiedHeart = Config.Bind("General", "PetrifiedHeart", true, "Enable Petrified Heart. (Friendly units get +10Health and Heartless.)\n启用石化之心（友方单位获得 +10 生命值，无心）。");
            addRailforgersHammer = Config.Bind("General", "RailforgersHammer", true, "Enable Railforger's Hammer. (+1Capacity on each floor.)\n启用锻铁者之锤（每层获得 +1 容量）。");
            addShardofDivinity = Config.Bind("General", "ShardofDivinity", true, "Enable Shard of Divinity. (Your Pyre starts each battle with Armor 100.)\n启用神祇碎片（战斗开始时，你的薪火获得护甲 100）。");
            addVialofTears = Config.Bind("General", "VialofTears", true, "Enable Vial of Tears. (At end of turn, restore 5 health to friendly units.)\n启用泪水之瓶（回合结束时，为所有友方单位恢复 5 点生命值）。");
            addWeatheredColdstones = Config.Bind("General", "WeatheredColdstones", true, "Enable Weathered Coldstones. (When you play a Blight card, restore 5 Pyre health.)\n启用风化冰晶石（当你打出祸患牌时，恢复 5 点薪火生命值）。");

            List<String> paths = [];

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
                    c.AddMergedJsonFile(paths);
                }
            );

            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
