using System;

namespace HelloWorld
{
  class Program
  { int userAge = 30; // declarando variavel

    static void Main(string[] args)

    {
    Console.Write("Hello World!"); // print na mesma linha
    
    Console.WriteLine(userAge);  // print da variavel pulando para a prox linha
    
    Console.WriteLine("Sua idade é igual a: "+userAge+"anos"); // concatenacao

    Console.WriteLine("{0}, você tem {1} anos!", "Fulano", userAge); // A chave zero {0} recebe o primeiro valor informado apos a virgula e o um {1} o segundo.

    Console.WriteLine("{0}, você tem {1:F2} anos!", "Fulano", 123.45678); // ao se utilizar ":F2" indicamos que qualquer numero utilizado deve ser arredondado com no máximo duas casas decimais após a virgula
      
    Console.WriteLine("{0}, você tem {1:C} anos!", "Fulano", 123.45678); // ao se utilizar ":C" indicamos que qualquer numero utilizado deve ser apresentado com cifrão

    }
  }
}