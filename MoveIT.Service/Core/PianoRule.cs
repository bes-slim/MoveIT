using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
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