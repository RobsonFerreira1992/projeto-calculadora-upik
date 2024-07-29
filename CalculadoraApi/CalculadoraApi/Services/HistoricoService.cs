using System.Collections.Concurrent;
using CalculatorApi.Models;

namespace CalculatorApi.Services
{
    public static class HistoricoService
    {
        private static readonly ConcurrentBag<HistoricoEntry> historico = new ConcurrentBag<HistoricoEntry>();
        private static int currentId = 0;

        public static void AddHistoricoEntry(double number1, double number2, string operation, double result)
        {
            var entry = new HistoricoEntry
            {
                Id = ++currentId,
                Number1 = number1,
                Number2 = number2,
                Operation = operation,
                Result = result,
                Timestamp = DateTime.UtcNow
            };

            historico.Add(entry);
        }

        public static List<HistoricoEntry> GetHistorico()
        {
            return historico.OrderByDescending(h => h.Timestamp).ToList();
        }
    }
}