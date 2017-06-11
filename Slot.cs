using System;
namespace StudyInterface
{
    public class Slot
    {
		public  BattleCharacter BattleCharacter { get; private set; }
		private IEquipment equipment;
        public  IEquipment Equipment {
            get {
                return this.equipment;
            }
            set {
                this.equipment = value;
            }
        }
        public Slot(ref BattleCharacter battleCharacter) {
            BattleCharacter = battleCharacter;
        }
    }
}
