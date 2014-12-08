using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
{
    public class OneCarPerFiftySquareMetersRule : ICarsNeededForAreaRule
    {
        public int CarsNeededForArea(MoveInfo moveInfo)
        {
            return moveInfo.Area / 50 + 1;
        }
    }
}