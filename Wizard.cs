
using System;
namespace StudyInterface
{
    /// <summary>
    /// バトルキャラクター「魔法使い」の為のクラス．
    /// 魔法が使える．
    /// </summary>
    public class Wizard : BattleCharacter
    {
        public IMagic[] MagicList { get; private set; }
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
    }
}
