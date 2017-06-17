using System;
namespace StudyInterface
{
    public interface IUseMagic
    {
        IMagic[] MagicList { get; }
        int MagicPoint { get; }
        IMagic SelectMaigic { get; }
        void UseMagic();
    }
}
