using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface ICarsNeededCalculator
    {
        int CalculateNeededCars(MoveInfo info);
    }
}