using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class PianoRule : ISpecialFurnitureRule
    {
        public bool HasFurniture(MoveInfo info)
        {
            return info.HasPiano;
        }

        public decimal CalculatePrice()
        {
            return 5000m;
        }
    }
}