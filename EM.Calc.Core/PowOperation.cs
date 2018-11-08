using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class PowOperation : IExtOperation
    {
        public string Name => "pow";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public Guid Uid => new Guid("{729608B3-CA59-4AFD-AD3A-4D66269ECC2E}");

        public string Description => "Возводит в степень";

        public int? ArgCount => 2;

        public double? Execute()
        {
            Result = Operands.Aggregate((lhs, rhs) => Math.Pow(lhs, rhs));
            return Result;
        }
    }
}
