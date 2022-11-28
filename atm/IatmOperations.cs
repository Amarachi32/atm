using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal interface IatmOperations
    {
        static double AcctBal { get; set; }
        bool GetCard() { return true; }
        string GetCardUserName() { return ""; }
        int GetPin() { return 0; }
        void TakeAction() { }
        //void CutomerDetails() { }
        void Withdrawal() { }
        void CheckBal() { }
        void Transfer() { }
    }
}
