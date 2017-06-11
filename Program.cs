using System;

namespace StudyInterface
{
    class MainClass
    {
        public static void Main(string[] args) {
            BattleCharacter theBrave        = new TheBrave();
            Console.WriteLine("ステータス: {0}--------------------------------------------", theBrave.ToString());
            Console.WriteLine("HP: {0}", theBrave.Hp);
            Console.WriteLine("ATK: {0}", theBrave.AttackPont);
			Console.WriteLine("装備一覧--------------------------------------------");
			for (int idx = 0; idx < theBrave.Slots.Length; idx++) {
                Console.WriteLine("装備: {0}", theBrave.Slots[idx].Equipment?.ToString());
            }
			theBrave.Slots[0].Equipment = new JourneySword();
            Console.WriteLine("{0}の装備枠{1}に{2}を装備----------------------------", theBrave.ToString(), 0, theBrave.Slots[0].Equipment.ToString());
			Console.WriteLine("装備一覧--------------------------------------------");
			for (int idx = 0; idx < theBrave.Slots.Length; idx++) {
				Console.WriteLine("装備: {0}", theBrave.Slots[idx].Equipment?.ToString());
			}
			Console.WriteLine("----------------------------------------------------");
			theBrave.GrabedWeapon = (IWeapon)theBrave.Slots[0].Equipment;
            BattleCharacter[] enemies = { new TheBrave() };
            theBrave.Attack(ref enemies);
        }
    }
}
