using System;
namespace StudyInterface
{
    public class TheBrave
    {
        public Equipment[] Equipments { get; }
		public TheBrave() {
            Equipments = new Equipment[4];
            Equip(new JourneySword(),  0);
            Equip(new JourneyShield(), 1);
		}
		// @to-do 知能を持ったモンスタークラスの作成
		// @to-do インタフェース化 
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
    }
}
