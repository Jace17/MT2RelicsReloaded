using BepInEx;
using BepInEx.Logging;
using TrainworksReloaded.Core;
using TrainworksReloaded.Core.Extensions;

namespace Monster_Train_2_Relics_Reloaded.Plugin
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger = new(MyPluginInfo.PLUGIN_GUID);
        public void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;

            var builder = Railhead.GetBuilder();
            builder.Configure(
                MyPluginInfo.PLUGIN_GUID,
                c =>
                {
                    // Be sure to include all of your json files if you add more.
                    // Be sure to update the project configuration if you include more folders
                    //   the project only copies json files in the json folder and not in subdirectories.
                    c.AddMergedJsonFile(
                        "json/plugin.json",
                        "json/global.json",
                        // Clanless Artifacts 
                        "json/relics/advanced_prototype.json",
                        "json/relics/boon_of_the_blacksmith.json",
                        "json/relics/cheaters_hand.json",
                        "json/relics/concussive_coals.json",
                        "json/relics/faulty_loader.json",
                        "json/relics/forver_flame.json",
                        "json/relics/golden_vault.json", 
                        "json/relics/hammered_chestplates.json", 
                        "json/relics/improved_firebox.json",
                        "json/relics/infused_mallet.json",
                        "json/relics/iron_dropcage.json",
                        "json/relics/lights_gift.json",
                        "json/relics/mark_of_a_champion.json",
                        "json/relics/mark_of_an_exile.json",
                        "json/relics/precious_plating.json",
                        "json/relics/pyrewall.json",
                        "json/relics/rationing_scales.json",
                        "json/relics/refracting_lenses.json",
                        "json/relics/tempered_talisman.json",
                        "json/relics/the_first_hellpact.json",
                        "json/relics/vapor_funnel.json",
                        "json/relics/winged_indulgence.json",
                        "json/relics/worn_grindstone.json",
                        // Event Artifacts
                        "json/relics/abandoned_stave.json",
                        "json/relics/blood_for_blood.json",
                        "json/relics/cracked_helmet.json",
                        "json/relics/dantes_cloak.json",
                        "json/relics/ember_stasis.json",
                        "json/relics/frozen_nostalgia.json",
                        "json/relics/heavens_gold.json",
                        "json/relics/history_of_the_world.json",
                        "json/relics/immortality_potion.json",
                        "json/relics/penitent_remains.json",
                        "json/relics/petrified_heart.json",
                        "json/relics/railforgers_hammer.json",
                        "json/relics/shard_of_divinity.json",
                        "json/relics/vial_of_tears.json",
                        "json/relics/weathered_coldstones.json"
                    );
                }
            );

            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
            
            // Uncomment if you need harmony patches, if you are writing your own custom effects.
            //var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            //harmony.PatchAll();
        }
    }
}
