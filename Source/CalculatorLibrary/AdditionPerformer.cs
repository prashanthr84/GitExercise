namespace CalculatorLibrary {
    public class AdditionPerformer : IAdditionPerformer {
        public int Perform(in int num1, in int num2) {
            return num1 + num2;
        }
    }
}