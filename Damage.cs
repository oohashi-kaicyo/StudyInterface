using System;
namespace StudyInterface
{
    public class Damage
    {
        public Damage(ref BattleCharacter myself, /*何で攻撃するか*/ ref BattleCharacter[] enemies) {
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
			//Characteristic[] myselfCharacteristices = myselfAttackObject.Characteristic;
            foreach (BattleCharacter enemy in enemies) {
                //Characteristic[] enemyCharacteristices = enemy.Characteristic;
                /* TODO 特攻が刺さるか判定 */
                attackPoint *= 1;
                int damagePoint = attackPoint;
                enemy.Hp -= damagePoint;
            }
        }

    }
}
