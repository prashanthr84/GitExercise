namespace CalculatorLibrary {
    public class SubtractionPerformer: ISubtractionPerformer {
        public int Perform(in int num1, in int num2) {
            return num2 - num1;
        }
    }
}