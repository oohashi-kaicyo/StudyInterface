using System;

namespace StudyInterface
{
    class MainClass
    {
        public static void Main(string[] args) {
            BattleCharacter theBrave        = new TheBrave();
            Console.WriteLine("ステータス: {0}", theBrave.ToString());
            Console.WriteLine("HP: {0}", theBrave.Hp);
            Console.WriteLine("ATK: {0}", theBrave.AttackPont);
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("装備一覧");
			for (int idx = 0; idx < theBrave.Slots.Length; idx++) {
                Console.WriteLine("装備: {0}", theBrave.Slots[idx].Equipment?.ToString());
            }
			Console.WriteLine("----------------------------------------------------");
			theBrave.Slots[0].Equipment = new JourneySword();
            Console.WriteLine("{0}の装備枠{1}に{2}を装備", theBrave.ToString(), 0, theBrave.Slots[0].Equipment.ToString());
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("装備一覧");
			for (int idx = 0; idx < theBrave.Slots.Length; idx++) {
				Console.WriteLine("装備: {0}", theBrave.Slots[idx].Equipment?.ToString());
			}
			Console.WriteLine("----------------------------------------------------");
			theBrave.GrabedWeapon = (IWeapon)theBrave.Slots[0].Equipment;
            // TODO 手に握っている武器種によって配列長を制限
            BattleCharacter[] enemies = { new TheBrave() };
			Console.WriteLine("HP: {0}", enemies[0].Hp);
			Console.WriteLine("ステータス: {0}", enemies[0].ToString());
			Console.WriteLine("----------------------------------------------------");
            theBrave.Attack(ref enemies);
            Console.WriteLine("{0}が{1}に攻撃", theBrave.ToString(), enemies[0].ToString());
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("ステータス: {0}", enemies[0].ToString());
			Console.WriteLine("HP: {0}", enemies[0].Hp);
        }
    }
}
