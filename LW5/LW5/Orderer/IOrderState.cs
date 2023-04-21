using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW5.Orderer
{
    public interface IOrderState
    {
        void ShowInformation(int OrderID);
        void PayForTheOrder (int OrderID);
        void ParcelTracking(int OrderID);
    }
}
