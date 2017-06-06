using System;
using StudyInterface.Properties;

namespace StudyInterface
{
    public abstract class Character: ICharacteristic
    {
        public int Hp { get; set; }
        public IWeapon weapon { get; set; }
		public string[] Characteristic { get; set; }
		public void Attack(ref Character enemy) {
			Character _this = this;
			Damage damage = new Damage(ref _this, ref enemy);
		}
	}
}
