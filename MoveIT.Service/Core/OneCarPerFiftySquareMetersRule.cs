using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
{
    public class OneCarPerFiftySquareMetersRule : ICarsNeededForAreaRule
    {
        public int CarsNeededForArea(MoveInfo moveInfo)
        {
            return moveInfo.Area / 50 + 1;
        }
    }
}