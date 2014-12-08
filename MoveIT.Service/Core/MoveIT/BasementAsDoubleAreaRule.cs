using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class BasementAsDoubleAreaRule : ICarsNeededForAreaRule
    {
        public int CarsNeededForArea(MoveInfo moveInfo)
        {
            return (moveInfo.BasementArea * 2) / 50;
        }
    }
}