
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

        public void UseMagic(IMagic magic) {
			Func<bool> isLearnedMagic = () => {
				foreach (IMagic learnedMagic in MagicList) {
					// XXX: Nullの場合，true?false?
					if (learnedMagic?.GetType() == magic.GetType()) {
						return true;
					}
				}
				return false;
			};
            Func<bool> isEnoughMagicPoint = () => {
                return magic.MagicPoint > MagicPoint;
			};
		    if(!isLearnedMagic()) {
                // TODO: 例外処理
                return;
            }
            if(!isEnoughMagicPoint()) {
				// TODO: 例外処理
				return;
            }
            MagicPoint -= magic.MagicPoint;
            if(magic.GetType() == typeof(IAttackMagic)) {
                // TODO: 攻撃魔法だった時のキャラクターへの未実装
            }
            throw new NotImplementedException();
        }
    }
}
