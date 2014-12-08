using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts.MoveIT
{
    public interface ICarsNeededCalculator
    {
        int CalculateNeededCars(MoveInfo info);
    }
}