using Maya.Common.Classes;
using Maya.Common.Enums;

namespace Maya.Common.Factories
{
    public interface IPlayerFactory 
    {
        Player Create(PlayerTypes playerType, ControlTypes controlType);
    }
}
