
using System;
namespace StudyInterface
{
    public class Wizard: BattleCharacter
    {
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
        }
    }
}
