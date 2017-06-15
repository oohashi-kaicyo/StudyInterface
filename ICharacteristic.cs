using System;
namespace StudyInterface
{
    public enum Characteristic {
        dragonAttributesSpecialAttack,
        darknessAttributesSpecialAttack,
        pairMagicalPower,
        noAttribute,
        fireAttribute,
        thunderAttribute,
        human
    }
    public interface ICharacteristic
    {
        Characteristic[] Characteristices { get; set; }
	}
}
