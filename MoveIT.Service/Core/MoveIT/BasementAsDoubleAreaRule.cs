using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
{
    public class BasementAsDoubleAreaRule : ICarsNeededForAreaRule
    {
        public int CarsNeededForArea(MoveInfo moveInfo)
        {
            return (moveInfo.BasementArea * 2) / 50;
        }
    }
}