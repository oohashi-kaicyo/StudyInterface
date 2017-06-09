using System;

namespace StudyInterface
{
    public class JourneySword: IWeapon
    {
        public int Atk { get; private set; }
        public String[] Characteristic {get;}
        public JourneySword() {
            Atk = 10;
            Characteristic = new string[] {"竜属性特攻", "闇属性特攻"};
        }
    }
}
