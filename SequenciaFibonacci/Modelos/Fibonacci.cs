namespace SequenciaFibonacci.Modelos;

internal class Fibonacci
{
    private int PreviousNumber { get; set; } = 0;
    private int Number { get; set; } = 1;

    private int NextNumber { get; set; } = 0;

    public string SequenciaFibonacci(int inputNumber)
    {
        if (inputNumber == 0)
        {
            return $"O número {inputNumber} percente à sequencia de Fibonacci.";
        }
        while (Number < inputNumber)
        {
            NextNumber = PreviousNumber + Number;
            PreviousNumber = Number;
            Number = NextNumber;
        }

        if (Number == inputNumber)
        {
            return $"O número {inputNumber} percente à sequencia de Fibonacci.";
        }
        else
        {
            return $"O número {inputNumber} não percente à sequencia de Fibonacci.";
        }
    }
}