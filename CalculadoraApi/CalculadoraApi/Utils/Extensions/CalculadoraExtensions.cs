using CalculatorApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorCalc.Utils.Extensions
{
    public static class CalculatorExtensions
    {
        public static double Calculate(this CalculadoraRequest request, string operation)
        {
            return operation switch
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