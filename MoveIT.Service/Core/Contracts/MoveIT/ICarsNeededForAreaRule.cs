using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts.MoveIT
{
    public interface ICarsNeededForAreaRule
    {
        int CarsNeededForArea(MoveInfo moveInfo);
    }
}