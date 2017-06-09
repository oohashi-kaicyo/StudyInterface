using System;

namespace StudyInterface
{
    public abstract class BattleCharacter
    {
        public int      Hp             { get; set; }
        public IWeapon  Weapon         { get; set; }
		public string[] Characteristic { get; set; }
		public void Attack(ref BattleCharacter enemy) {
			BattleCharacter myself = this;
			Damage damage = new Damage(ref myself, ref enemy);
		}
	}
}
