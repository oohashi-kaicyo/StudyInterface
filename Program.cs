using System;

namespace StudyInterface
{
    class MainClass
    {
        public static void Main(string[] args) {
            Character theBrave = new TheBrave();
            theBrave.Weapon    = new JourneySword();
            Character enemy    = new TheBrave();
            theBrave.Attack(ref enemy);
        }
    }
}
