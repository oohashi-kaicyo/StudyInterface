using System;
using StudyInterface.Properties;

namespace StudyInterface
{
    public class TheBrave: ICharacteristic
    {
        public int[] JyoutaiIjyo { get; set; }
        public string[] Characteristic { get; }
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
        // 1:1ではなく1:Nの場合
        public void Attack(/*ref エネミー*/) {
            // もし装備品を所持していない場合
            //Console.WriteLine("勇者の攻撃");
            JourneySword wepon = new JourneySword();
			// ダメージクラス
			// クラスに分ける理由
			//new DamergeManager(this, enermy);
			// たとえば，ダメージを予測するメソッドにも実装可能
			// 計算式(相性計算)
			// wepon.Atkや属性，敵の属性からダメージ計算
			// 相手のHPを削る
			// 勇者がエネミーA1に対して攻撃
			// theBrave.Attack(enemyA1);
			// 使用者は，この内側の設計がどうなっているかを考慮する必要はない
		}
    }
}
