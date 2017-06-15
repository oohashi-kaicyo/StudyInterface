using System;
namespace StudyInterface
{
    public class FireBolt
    {
        : IAttackMagic
    {
        public int AttackPont { get; set; }
		public Characteristic[] Characteristices { get; set; }
		public FireBolt() {
			AttackPont = 3;
			Characteristices = new Characteristic[] { Characteristic.fireAttribute };
		}
    }
}
