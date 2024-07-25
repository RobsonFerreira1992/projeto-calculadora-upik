
using CalculatorApi.Models;

namespace CalculatorApi.Utils.Extensions
{
    public static class CalculatorExtensions
    {
        public static double Calculate(this CalculadoraRequest request)
        {
            if (string.IsNullOrEmpty(request.Operation))
            {
                throw new InvalidOperationException("Operação inválida");
            }

            return request.Operation switch
            {
                "+" => request.Number1 + request.Number2,
                "-" => request.Number1 - request.Number2,
                "*" => request.Number1 * request.Number2,
                "/" => request.Number2 != 0 ? request.Number1 / request.Number2 : throw new DivideByZeroException(),
                "%" => request.Number1 % request.Number2,
                _ => throw new InvalidOperationException("Operação inválida")
            };
        }
    }
}