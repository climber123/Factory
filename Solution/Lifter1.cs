using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Solution
{
    public class Lifter1: ILifter
    {
        public bool State { get; set; }
        public int Index { get; set; }

        public Lifter1()
        {
            State = false;
        }
        public void GetDetail(Stanok s)
        {
            Index = s.Index;
            State = true;
            Thread.Sleep(3000);
            State = false;
        }
    }
}
