using System;

namespace CalculatorLibrary
{
    public class CalculatorService
    {
        private readonly IAdditionPerformer performer;
        private readonly ISubtractionPerformer subtractionPerformer;
        private readonly IMultiplicationPerformer multiplicationPerformer;
        private readonly IDivisionPerformer divisionPerformer;


        public CalculatorService(
            IAdditionPerformer performer,
            ISubtractionPerformer subtractionPerformer,
            IMultiplicationPerformer multiplicationPerformer,
            IDivisionPerformer divisionPerformer
        ) {
            this.performer = performer;
            this.subtractionPerformer = subtractionPerformer;
            this.multiplicationPerformer = multiplicationPerformer;
            this.divisionPerformer = divisionPerformer;
        }

        public int Add(int num1, int num2) {
            return performer.Perform(num1, num2);
        }

        public int Multiply(int num1, int num2)
        {
            return multiplicationPerformer.Perform(num1, num2);
        }

        public int Subtract(int num1, int num2) {
            return subtractionPerformer.Perform(num1, num2);
        }

        public int Divide(int num1, int num2) {
            return divisionPerformer.Perform(num1, num2);
        }
    }
}
