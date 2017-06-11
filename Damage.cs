using System;
namespace StudyInterface
{
    public class Damage
    {
        public Damage(ref BattleCharacter myself, ref BattleCharacter[] enemies) {
            this.Calc(ref myself, ref enemies);
        }
        private void Calc(ref BattleCharacter myself, ref BattleCharacter[] enemies) {
            IAttackPoint myselfAttackObject;
            if(myself.GrabedWeapon == null) {
                myselfAttackObject = myself;
                return;
            } else {
                myselfAttackObject = myself.GrabedWeapon;
            }
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

    }
}
