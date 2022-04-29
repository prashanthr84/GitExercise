using System;

namespace CalculatorLibrary
{
    public class CalculatorService
    {
        private readonly IAdditionPerformer performer;
        private readonly ISubtractionPerformer subtractionPerformer;

        public CalculatorService(
            IAdditionPerformer performer,
            ISubtractionPerformer subtractionPerformer
        ) {
            this.performer = performer;
            this.subtractionPerformer = subtractionPerformer;
        }

        public int Add(int num1, int num2) {
            return performer.Perform(num1, num2);
        }

        public int Subtract(int num1, int num2) {
            return subtractionPerformer.Perform(num1, num2);
        }
    }
}
