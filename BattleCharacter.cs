using System;

namespace StudyInterface
{
    public abstract class BattleCharacter: IAttack, ICharacteristic, IAttackPoint
    {
        public  int              Hp               { get; set; }
		public  int              Level            { get; set; }
        // FIXME: 手のないキャラクターの存在を考慮していない
		public  IWeapon          GrabedWeapon     { get; set; }
        public  Characteristic[] Characteristices { get; set; }
        public  Slot[]           Slots            { get; set; }
		public  int              AttackPont       { get; set; }
		public virtual void Equip(int slotIdx, IEquipment equipment) {
            if (Slots.Length <= slotIdx) {
                return;    
            }
            Slots[slotIdx].Equipment = equipment;
        }
        public virtual void Attack(ref BattleCharacter[] enemies) {
			BattleCharacter myself = this;
			Damage damage = new Damage(ref myself, ref enemies);
		}
	}
}
