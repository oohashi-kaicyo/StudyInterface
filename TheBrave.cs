using System;

namespace StudyInterface
{
    public class TheBrave: Character
    {
        //public JourneySword wepon = new JourneySword();
        //public int[] JyoutaiIjyo { get; set; }
		//private Equipment[] equipments; 
        //public Equipment[] Equipments {
        //    get {
        //        return equipments;
        //    }
        //    set {
        //        if (equipments.GetType() == typeof(Equipment)) {
        //        }
        //        equipments = value;
        //    }
        //}
        public TheBrave() {
            //Equipments = new Equipment[4];
            //Equip(new JourneySword(),  0);
            //Equip(new JourneyShield(), 1);
            Characteristic = new string[]{"無", "人間"};
            weapon = new JourneySword();
		}
		//public void Equip(Equipment equipment, int idx) {
        //    int equipableIdx = Equipments.Length - 1;
        //    if(idx > equipableIdx) {
        //        return;
        //    }
        //    Equipments[idx] = equipment;
        //}
        //public void useEquipment(int idx) {
        //    int equipableIdx = Equipments.Length - 1;
        //    if (idx > equipableIdx || Equipments[idx] == null) {
        //        return;
        //    }
        //    Equipments[idx].Help();
        //}
    }
}
