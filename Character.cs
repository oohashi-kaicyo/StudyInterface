using System;

namespace StudyInterface
{
    public abstract class Character
    {
        public int      Hp             { get; set; }
        public IWeapon  Weapon         { get; set; }
		public string[] Characteristic { get; set; }
        // virtualを付与しなければ，これが用いられる
		public void Attack(ref Character enemy) {
			Character myself = this;
			Damage damage = new Damage(ref myself, ref enemy);
		}
	}
}
