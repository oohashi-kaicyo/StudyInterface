using System;
namespace StudyInterface
{
    public class Damage
    {
        public Damage(ref Character ally, ref Character enemy) {
            this.Calc(ref ally, ref enemy);
        }
        private void Calc(ref Character ally, ref Character enemy) {
            int damagePoint = ((TheBrave)ally).wepon.Atk * 10 * 10 * 1 * 1;
            enemy.Hp = damagePoint;
        }
    }
}
