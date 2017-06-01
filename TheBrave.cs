using System;
namespace StudyInterface
{
    public class TheBrave
    {
        public int[] JyoutaiIjyo { get; set; }
        private Equipment[] equipments; 
        public Equipment[] Equipments {
            get {
                return equipments;
            } 
            set {
                // この書き方だと，装備の種類が増えるたびに書き換える必要がある気が......
                // 武器種は大別だからいいか
                if (equipments.GetType() == typeof(Equipment)) {
                    // もし攻撃魔法ならXXに格納
                }
                equipments = value;
            } 
        }
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
        public void Attack() {
            // もし装備品を所持していない場合
            Console.WriteLine("勇者の攻撃");
            IWeapon wepon = new JourneySword();


		}
    }
}
