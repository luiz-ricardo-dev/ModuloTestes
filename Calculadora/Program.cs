
using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();
ContarCaracteres v = new ContarCaracteres();

int num1 = 5;
int num2 = 10;
string texto = "Luiz";

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");


Console.WriteLine($"A palavra {texto}, tem {v.ContarStrings(texto)} caracteres.");
