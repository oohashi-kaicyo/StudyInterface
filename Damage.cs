using System;
namespace StudyInterface
{
    public class Damage
    {
        public Damage(ref BattleCharacter myself, ref BattleCharacter[] enemies) {
            if(myself is IUseMagic) {
                CalcMagicDamage(ref myself, ref enemies);
            }
            CalcDamage(ref myself, ref enemies);
        }
        private void CalcDamage(ref BattleCharacter myself, ref BattleCharacter[] enemies) {
            IAttackPoint myselfAttackObject;
            if(myself.GrabedWeapon == null) {
                myselfAttackObject = myself;
            } else {
                myselfAttackObject = myself.GrabedWeapon;
            }
            SatusReflection(myselfAttackObject, ref enemies);
        }
        private void SatusReflection(IAttackPoint myselfAttackObject, ref BattleCharacter[] enemies) {
			int attackPoint = myselfAttackObject.AttackPont;
			Characteristic[] myselfCharacteristices = myselfAttackObject.Characteristices;
			foreach (BattleCharacter enemy in enemies) {
				Characteristic[] enemyCharacteristices = enemy.Characteristices;
				/* TODO 特攻が刺さるか判定 */
				attackPoint *= 1;
				int damagePoint = attackPoint;
				enemy.Hp -= damagePoint;
			}
		}
		private void CalcMagicDamage(ref BattleCharacter myself, ref BattleCharacter[] enemies) {
            IAttackPoint myselfAttackObject;
            Wizard wizard = (Wizard)myself;
            if (wizard.SelectMaigic == null) {
                myselfAttackObject = wizard;
			} else {
                myselfAttackObject = (IAttackMagic)wizard.SelectMaigic;
			}
            SatusReflection(myselfAttackObject, ref enemies);
            wizard.SelectMaigic = null;
		}
    }
}
