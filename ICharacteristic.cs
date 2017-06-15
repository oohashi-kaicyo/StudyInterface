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
        Machinery,
        magic,
        human
    }
    public interface ICharacteristic
    {
        Characteristic[] Characteristices { get; set; }
	}
}
