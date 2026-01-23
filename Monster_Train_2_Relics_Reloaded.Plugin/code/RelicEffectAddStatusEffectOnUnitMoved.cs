using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Monster_Train_2_Relics_Reloaded.Plugin.code
{
    public sealed class RelicEffectAddStatusEffectOnUnitMoved : RelicEffectBase, ICharacterActionRelicEffect, IRelicEffect, IStatusEffectRelicEffect
    {
        public override bool CanShowNotifications
        {
            get
            {
                return false;
            }
        }

        public override void Initialize(RelicState relicState, RelicData relicData, RelicEffectData relicEffectData)
        {
            base.Initialize(relicState, relicData, relicEffectData);
            this.targetTeam = relicEffectData.GetParamSourceTeam();
            this.statusEffects = relicEffectData.GetParamStatusEffects();
        }

        public bool TestCharacterTriggerEffect(CharacterTriggerRelicEffectParams relicEffectParams, ICoreGameManagers coreGameManagers)
        {
            CharacterState characterState = relicEffectParams.characterState;
            return !characterState.IsDestroyed && characterState.GetTeamType() == this.targetTeam && 
                !characterState.HasStatusEffect("immune") && !coreGameManagers.GetCombatManager().GetCombatPhase().IsHeroMovement() && 
                (relicEffectParams.trigger == CharacterTriggerData.Trigger.PostAscension || relicEffectParams.trigger == CharacterTriggerData.Trigger.PostDescension
                    || relicEffectParams.trigger == CharacterTriggerData.Trigger.PostAttemptedAscension || relicEffectParams.trigger == CharacterTriggerData.Trigger.PostAttemptedDescension);
        }

        public IEnumerator ApplyCharacterTriggerEffect(CharacterTriggerRelicEffectParams relicEffectParams, ICoreGameManagers coreGameManagers)
        {
            CharacterState characterState = relicEffectParams.characterState;
            int num = RandomManager.Range(0, this.statusEffects.Length, RngId.Battle);
            int numStacks = (this.statusEffects[num].count > 0) ? this.statusEffects[num].count : 1;
            CharacterState.AddStatusEffectParams addStatusEffectParams = new CharacterState.AddStatusEffectParams
            {
                sourceRelicState = this._srcRelicState
            };
            characterState.AddStatusEffect(this.statusEffects[num].statusId, numStacks, addStatusEffectParams);
            if (this._srcRelicData.CanShowNotifications)
            {
                NotifyRelicTriggered(coreGameManagers.GetRelicManager(), characterState);
            }
            yield break;
        }

        public StatusEffectStackData[] GetStatusEffects()
        {
            return this.statusEffects;
        }

        public override PropDescriptions CreateEditorInspectorDescriptions()
        {
            return [];
        }

        private Team.Type targetTeam;

        private StatusEffectStackData[] statusEffects;
    }
}
