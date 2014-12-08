using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class OneCarPerFiftySquareMetersRule : ICarsNeededForAreaRule
    {
        public int CarsNeededForArea(MoveInfo moveInfo)
        {
            return moveInfo.Area / 50 + 1;
        }
    }
}