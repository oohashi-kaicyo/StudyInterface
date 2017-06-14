using System;
namespace StudyInterface
{
    public enum Characteristic {
        dragonAttributesSpecialAttack,
        darknessAttributesSpecialAttack,
        pairMagicalPower,
        noAttribute,
        fireAttribute,
        human
    }
    public interface ICharacteristic
    {
        Characteristic[] Characteristices { get; set; }
	}
}
