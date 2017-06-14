using System;
namespace StudyInterface
{
    public class FireBall: IAttackMagic
    {
		public int AttackPont { get; set; }
		public Characteristic[] Characteristices { get; set; }
        public FireBall() {
            AttackPont = 3;
            Characteristices = new Characteristic[] { Characteristic.fireAttribute };
        }
    }
}
