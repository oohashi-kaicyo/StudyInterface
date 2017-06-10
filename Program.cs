using System;

namespace StudyInterface
{
    class MainClass
    {
        public static void Main(string[] args) {
            TheBrave theBrave        = new TheBrave();
            theBrave.Weapon          = new JourneySword();
            BattleCharacter enemy    = new TheBrave();
            theBrave.Attack(ref enemy);
        }
    }
}
