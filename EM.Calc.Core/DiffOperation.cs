using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class DiffOperation : IExtOperation
    {
        public string Name => "DIpoteka";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

    public Guid Uid => new Guid("{77BAD8F3-140A-4834-AE27-C6F7A35BECCF}");

    public string Description => "Высчитывает ежемесячный дифференцированный платеж";

    public int? ArgCount => 3;

    public double? Execute()
        {
            int ii = Operands.Length ;

            if (ii == 3)
            {
                double s = Operands.First();
                double n = Operands.Last()*12;
                double i = Operands.Aggregate((a, b) => a * b) / (s * n/12)/1200;
                double Res = s / n + s * i;
               
                Result = Math.Round(Res,2);
            }
                return Result;
        }
    }
}
