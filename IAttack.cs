using System;
namespace StudyInterface
{
    public interface IAttack {
        void Attack(ref BattleCharacter[] enemies);
    }
}
