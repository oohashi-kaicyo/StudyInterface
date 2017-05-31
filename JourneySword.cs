using System;
namespace StudyInterface
{
    public class JourneySword: Equipment
    {
        public JourneySword() {
            
        }
        public override void Help() {
            Console.WriteLine("旅たちの剣: 勇者として旅立つものに贈られる剣");
        }
    }
}
