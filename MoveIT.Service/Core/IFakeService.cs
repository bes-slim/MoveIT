using System;
using System.Text;
using System.Threading.Tasks;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
{
    public interface IFakeService
    {
        string[] GetValues();
        int GetOffer(MoveInfo info);
    }

    public class FakeService : IFakeService
    {
        public string[] GetValues()
        {
            return new string[] { "bessem", "slim", "ninject" };
        }


        public int GetOffer(MoveInfo info)
        {
            return info.Area*info.Distance;
        }
    }
}
