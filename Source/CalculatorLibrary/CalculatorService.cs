using System;

namespace CalculatorLibrary
{
    public class CalculatorService
    {
        private readonly IAdditionPerformer performer;

        public CalculatorService(IAdditionPerformer performer) {
            this.performer = performer;
        }

        public int Add(int num1, int num2) {
            return performer.Perform(num1, num2);
        }
    }
}
