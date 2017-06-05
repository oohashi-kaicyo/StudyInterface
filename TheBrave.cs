using System;
using StudyInterface.Properties;

namespace StudyInterface
{
    public class TheBrave: Character, ICharacteristic
    {
        public JourneySword wepon = new JourneySword();
        public int[] JyoutaiIjyo { get; set; }
        public string[] Characteristic { get; set; }
		private Equipment[] equipments; 
        public Equipment[] Equipments {
            get {
                return equipments;
            }
            set {
                if (equipments.GetType() == typeof(Equipment)) {
                }
                equipments = value;
            }
        }
        public TheBrave() {
            Equipments = new Equipment[4];
            Equip(new JourneySword(),  0);
            Equip(new JourneyShield(), 1);
            Characteristic = new string[]{"無", "人間"};
		}
		public void Equip(Equipment equipment, int idx) {
            int equipableIdx = Equipments.Length - 1;
            if(idx > equipableIdx) {
                return;
            }
            Equipments[idx] = equipment;
        }
        public void useEquipment(int idx) {
            int equipableIdx = Equipments.Length - 1;
            if (idx > equipableIdx || Equipments[idx] == null) {
                return;
            }
            Equipments[idx].Help();
        }
        public void Attack(ref Character enemy) {
            Character _this = this;
            Damage damage = new Damage(ref _this, ref enemy);
		}
    }
}
