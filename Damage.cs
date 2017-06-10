using System;
namespace StudyInterface
{
    public class Damage
    {
        public Damage(ref BattleCharacter ally, ref BattleCharacter enemy) {
            this.Calc(ref ally, ref enemy);
        }
        private void Calc(ref BattleCharacter ally, ref BattleCharacter enemy) {
            int damagePoint = ally.Weapon.Atk;
            enemy.Hp = damagePoint;
        }
    }
}
