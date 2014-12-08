using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts.MoveIT
{
    public interface ICarsNeededCalculator
    {
        int CalculateNeededCars(MoveInfo info);
    }
}