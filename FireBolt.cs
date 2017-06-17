using System;
namespace StudyInterface
{
    public class FireBolt: IMagic, IAttackMagic {
        // HACK: 特定のインタフェースからのアクセスのみ許可したい
		public int MagicPoint { get; set; }
		public int AttackPont { get; set; }
		public Characteristic[] Characteristices { get; set; }
		public FireBolt() {
			MagicPoint = 2;
			AttackPont = 3;
			Characteristices = new Characteristic[] { Characteristic.fireAttribute };
		}
    }
}
