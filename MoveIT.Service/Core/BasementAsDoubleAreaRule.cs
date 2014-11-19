using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
{
    public class BasementAsDoubleAreaRule : ICarsNeededForAreaRule
    {
        public int CarsNeededForArea(MoveInfo moveInfo)
        {
            return (moveInfo.BasementArea * 2) / 50;
        }
    }
}