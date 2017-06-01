using System;
namespace StudyInterface
{
    public class JourneySword: Equipment, IWeapon
    {
        public int Atk { get; private set; }
        public String[] Characteristic {get;}
        public JourneySword() {
            Characteristic = new string[] {"竜属性特攻", "闇属性特攻"};
        }
        public override void Help() {
            Console.WriteLine("旅たちの剣: 勇者として旅立つものに贈られる剣");
        }
    }
}
