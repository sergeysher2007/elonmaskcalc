using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class NewOperation : IExtOperation
    {
        public string Name => "new";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public Guid Uid => new Guid("{6BDD72F0-7C96-43A5-A065-70599D637AEF}");

        public string Description => "Возвращает позитив";

        public int? ArgCount => 0;

        public double? Execute()
        {
            Result = double.PositiveInfinity;
            return Result;
        }
    }
}
