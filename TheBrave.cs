﻿using System;

namespace StudyInterface
{
    public class TheBrave: BattleCharacter
    {
        public TheBrave() {
            Hp         = 15;
            AttackPont = 1;
            Characteristices = new Characteristic[] {
                Characteristic.noAttribute, 
                Characteristic.human
            };
            BattleCharacter myself = this;
            Slots = new Slot[]{new Slot(ref myself), 
                               new Slot(ref myself), 
                               new Slot(ref myself), 
                               new Slot(ref myself)
            };
		}
    }
}
