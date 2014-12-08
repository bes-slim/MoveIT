using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
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