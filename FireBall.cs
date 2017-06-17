using System;
namespace StudyInterface
{
    public class FireBall: IAttackMagic
    {
		// HACK: 特定のインタフェースからのアクセスのみ許可したい
		public int MagicPoint { get; set; }
		public int AttackPont { get; set; }
		public Characteristic[] Characteristices { get; set; }
        public FireBall() {
            MagicPoint = 1;
            AttackPont = 3;
            Characteristices = new Characteristic[] { Characteristic.fireAttribute };
        }
    }
}
