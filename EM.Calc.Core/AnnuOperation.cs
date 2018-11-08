using System;
using System.Linq;

namespace EM.Calc.Core
{
    public class AnnuOperation : IExtOperation
    {
        public string Name => "AIpoteka";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

    public Guid Uid => new Guid("{77BAD8F3-140A-4834-AE27-C6F7A35BECCF}");

    public string Description => "Высчитывает ежемесячный аннуитетный платеж";

    public int? ArgCount => 3;

    public double? Execute()
        {
            int ii = Operands.Length ;

            if (ii == 3)
            {
                double s = Operands.First();
                double n = Operands.Last()*12;
                double i = Operands.Aggregate((a, b) => a * b) / (s * n/12)/1200;
                double Res = s*i/ (1-Math.Pow(1 + i, 0-n));
                Result = Math.Round(Res,2);
            }
                return Result;
        }
    }
}
