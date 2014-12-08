using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts.MoveIT
{
    public interface ICarsNeededForAreaRule
    {
        int CarsNeededForArea(MoveInfo moveInfo);
    }
}