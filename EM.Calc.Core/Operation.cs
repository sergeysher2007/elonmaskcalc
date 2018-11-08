using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class SumOperation : IExtOperation
    {
        public string Name => "sum";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public Guid Uid => new Guid("{7EF4CE0C-F562-4E7B-AE39-30E1A4DA735E}");

        public string Description => "Суммирует всё и вся";

        public int? ArgCount => 1;

        public double? Execute()
        {
            Result = Operands.Sum();
            return Result;
        }
    }
}
