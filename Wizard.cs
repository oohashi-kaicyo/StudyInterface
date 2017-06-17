
using System;
namespace StudyInterface
{
    /// <summary>
    /// バトルキャラクター「魔法使い」の為のクラス．
    /// 魔法が使える．
    /// </summary>
    public class Wizard : BattleCharacter, IUseMagic
    {
        public IMagic[] MagicList { get; private set; }

        public int MagicPoint { get; private set; }

        public IMagic SelectMaigic { get; set; }

        public Wizard() {
			Hp = 10;
			AttackPont = 0;
			Characteristices = new Characteristic[] {
				Characteristic.magic,
				Characteristic.human
			};
			BattleCharacter myself = this;
			Slots = new Slot[]{new Slot(ref myself),
							   new Slot(ref myself),
							   new Slot(ref myself),
							   new Slot(ref myself),
                               new Slot(ref myself),
			};
            MagicList = new IMagic[4];
            MagicList[0] = new FireBall();
            MagicList[1] = new FireBolt();
        }

        public void UseMagic() {
			Func<bool> isLearnedMagic = () => {
				foreach (IMagic learnedMagic in MagicList) {
					// XXX: Nullの場合，true?false?
					if (learnedMagic?.GetType() == SelectMaigic.GetType()) {
						return true;
					}
				}
				return false;
			};
            Func<bool> isEnoughMagicPoint = () => {
                return SelectMaigic.MagicPoint > MagicPoint;
			};
		    if(!isLearnedMagic()) {
                // TODO: 例外処理
                return;
            }
            if(!isEnoughMagicPoint()) {
				// TODO: 例外処理
				return;
            }
            MagicPoint -= SelectMaigic.MagicPoint;
            SelectMaigic = SelectMaigic;
            if(SelectMaigic.GetType() == typeof(IAttackMagic)) {
                return;
            }
        }
		public void UseAttackMagic(ref BattleCharacter[] enemies) {
            UseMagic();
            BattleCharacter myself = this;
            Damage damage = new Damage(ref myself, ref enemies);
		}
    }
}
