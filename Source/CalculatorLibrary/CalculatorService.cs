using System;

namespace CalculatorLibrary
{
    public class CalculatorService
    {
        private readonly IAdditionPerformer additionPerformer;

        private readonly ISubtractionPerformer subtractionPerformer;
        private readonly IMultiplicationPerformer multiplicationPerformer;

        public CalculatorService(
            IAdditionPerformer additionPerformer,
            ISubtractionPerformer subtractionPerformer,
            IMultiplicationPerformer multiplicationPerformer
        ) {
            this.additionPerformer = additionPerformer;
            this.subtractionPerformer = subtractionPerformer;
            this.multiplicationPerformer = multiplicationPerformer;
        }

        public int Add(int num1, int num2) {
            return additionPerformer.Perform(num1, num2);
        }

        public int Multiply(int num1, int num2)
        {
            return multiplicationPerformer.Perform(num1, num2);
        }

        public int Subtract(int num1, int num2) {
            return subtractionPerformer.Perform(num1, num2);
        }
    }
}
