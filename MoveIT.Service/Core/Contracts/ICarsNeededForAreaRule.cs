using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface ICarsNeededForAreaRule
    {
        int CarsNeededForArea(MoveInfo moveInfo);
    }
}