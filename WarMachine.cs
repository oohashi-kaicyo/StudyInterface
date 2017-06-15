using System;
namespace StudyInterface
{
    public class WarMachine: BattleCharacter
    {
        public WarMachine() {
            Hp = 22;
            AttackPont = 8;
            Characteristices = new Characteristic[] {
                Characteristic.Machinery,
            };
        }
    }
}
