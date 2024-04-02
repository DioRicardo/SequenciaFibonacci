using SequenciaFibonacci.Modelos;

Fibonacci resposta = new();

Console.Write("Digite um número para saber se pertence à sequência de Fibonacci: ");
int inputNumber = int.Parse(Console.ReadLine()!);

string mensagem = resposta.SequenciaFibonacci(inputNumber);

Console.WriteLine(mensagem);