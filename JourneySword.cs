using System;

namespace StudyInterface
{
    public class JourneySword: IWeapon
    {
        public Characteristic[] Characteristices {get; set;}
		public int AttackPont { get; }
		public JourneySword() {
            AttackPont = 1;
            Characteristices = new Characteristic[] {Characteristic.noAttribute};
        }
    }
}
