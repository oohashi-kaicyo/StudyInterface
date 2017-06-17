using System;
namespace StudyInterface
{
    public interface IUseMagic
    {
        IMagic[] MagicList { get; }
        int MagicPoint { get; }
        void UseMagic(IMagic magic);
    }
}
