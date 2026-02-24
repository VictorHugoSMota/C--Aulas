// 1° AULA - 03/02 ===========================================================================================

/*
1° MODELO --------------------------------------------------------------------------------------  

inicio:
 Console.WriteLine("Escolha qual Operação Usar:");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Substituição");
Console.WriteLine("3 - Divisão");
Console.WriteLine("4 - Multiplicação");

var Decisao = Console.ReadLine();
int Decisao = 0;

try
{
    Decisao INT = Convert.ToInt16(Decisao);
}
catch
{
    Console.WhiteLine("Valor Invalido!");
    goto inicio;
}


Console.WhiteLine("Digite o 1° Numero: ");
var Num1 = ConsoleColor.ReadLine();

float NumeroConvertido;

try
{
    var NumeroConvertido = float.Parse(Num1).Replace(",",",",".");
}
catch
{
    Console.Clear();
    goto inicio;
}

Console.WhiteLine("Digite o 2° Numero: ");
var Num2 = ConsoleColor.ReadLine();

float NumeroConvertido;

try
{
    var NumeroConvertido = float.Parse(Num1).Replace(",",",",".");
}
catch
{
    Console.Clear();
    goto inicio;
}


static float Adição(float Num1, float Num2);
{
    return Num1 + Num2;
}

switch(Decisao)
{
    case 1: 
        Console.WhiteLead("O Valor da Adição é: " + Adição);
}
*/


/* 2° MODELO --------------------------------------------------------------------------------------  

using System;

Console.WriteLine("Escolha qual operação usar:");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Divisão");
Console.WriteLine("4 - Multiplicação");

int decisao;

while (!int.TryParse(Console.ReadLine(), out decisao) || decisao < 1 || decisao > 4)
{
    Console.WriteLine("Opção inválida! Escolha de 1 a 4:");
}

// ===== PRIMEIRO NÚMERO =====
Console.WriteLine("Digite o 1º número:");
float num1;

while (!float.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Número inválido! Digite novamente:");
}

// ===== SEGUNDO NÚMERO =====
Console.WriteLine("Digite o 2º número:");
float num2;

while (!float.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Número inválido! Digite novamente:");
}

// ===== CÁLCULO =====
float resultado = 0;

switch (decisao)
{
    case 1:
        resultado = num1 + num2;
        break;

    case 2:
        resultado = num1 - num2;
        break;

    case 3:
        if (num2 == 0)
        {
            Console.WriteLine("Erro: divisão por zero não existe.");
            return;
        }
        resultado = num1 / num2;
        break;

    case 4:
        resultado = num1 * num2;
        break;
}

Console.WriteLine($"Resultado: {resultado}");
*/


/* 3° MODELO --------------------------------------------------------------------------------------  
/* 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");

        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        Console.Write("Digite o primeiro número: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        float num2 = float.Parse(Console.ReadLine());

        float resultado = 0;

        if (opcao == 1)
        {
            resultado = num1 + num2;
        }
        else if (opcao == 2)
        {
            resultado = num1 - num2;
        }
        else if (opcao == 3)
        {
            resultado = num1 / num2;
        }
        else if (opcao == 4)
        {
            resultado = num1 * num2;
        }
        else
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}
*/


/* 4° MODELO --------------------------------------------------------------------------------------  

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora ===");
        Console.WriteLine(" 1 - Adição");
        Console.WriteLine(" 2 - Subtração");
        Console.WriteLine(" 3 - Divisão");
        Console.WriteLine(" 4 - Multiplicação");

        Console.WriteLine("Escolhe a opção desejada: ");
        var decisao = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o 1° Numero: ");
        var Num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o 2° Numero: ");
        var Num2 = float.Parse(Console.ReadLine());

        float resultado = 0;

        if(decisao == 1)
        {
            resultado = Num1 + Num2;
        } 

        else if(decisao ==2)
        {
            resultado = Num1 - Num2;
        }

        else if(decisao == 3)
        {
            resultado = Num1 / Num2;
        }

        else if( decisao == 4)
        {
            resultado= Num1 * Num2;
        }

        else
        {
            Console.WriteLine("Opção Invalida");
            return;
        }

        Console.WriteLine("o Resultado é: " + resultado);
        
    }
    };

    */




















// 2° AULA - 10/02 ===========================================================================


/* 1° MODELO --------------------------------------------------------------------------------------  
using System;

class Program
{
        static void Main()
    {
        int[] numeros = {10,20,30,40,50};

        for(int i = 0; i< numeros.Length; i++)
        {
            Console.WriteLine("Posição: "+ numeros[i]);
        }
    }
}
*/


/* 2° MODELO --------------------------------------------------------------------------------------  
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nValores digitados:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Posição " + (i + 1) + ": " + numeros[i]);
        }

        Console.WriteLine("\nDeseja fazer alguma alteração? S/N");
        string alteracao = Console.ReadLine();

        if (alteracao == "S")
        {
            Console.WriteLine("Qual índice deseja trocar?");
            int indice = int.Parse(Console.ReadLine());

            indice = indice - 1;

            Console.WriteLine("Digite o novo valor:");
            numeros[indice] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nValores atualizados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posição " + (i + 1) + ": " + numeros[i]);
            }
        }
        else if( alteracao == "N")
        {
            for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Posição " + (i + 1) + ": " + numeros[i]);
        }
            Console.WriteLine("Tabela Finalida!");
        }
        
    }
}

*/



//  3° MODELO --------------------------------------------------------------------------------------  

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numeros = new int[5];

//         for (int i = 0; i < numeros.Length; i++)
//         {
//             bool valido = false;

//             while (valido == false)
//             {
//                 Console.Write("Digite um número: ");
//                 valido = int.TryParse(Console.ReadLine(), out numeros[i]);

//                 if (valido == false)
//                 {
//                     Console.WriteLine("Digite apenas números.");
//                 }
//             }
//         }

//         Console.WriteLine("\nValores digitados:");
//         for (int i = 0; i < numeros.Length; i++)
//         {
//             Console.WriteLine("Posição " + (i + 1) + ": " + numeros[i]);
//         }

//         Console.WriteLine("\nDeseja alterar algum valor? S/N");
//         var resposta = Console.ReadLine();

//         if (resposta == "S")
//         {
//             int indice = 0;
//             bool indiceValido = false;

//             while (indiceValido == false)
//             {
//                 Console.WriteLine("Qual posição deseja alterar? (1 a 5)");
//                 indiceValido = int.TryParse(Console.ReadLine(), out indice);

//                 if (indiceValido == false || indice < 1 || indice > 5)
//                 {
//                     Console.WriteLine("Errado! Digite um número entre 1 e 5.");
//                     indiceValido = false;
//                 }
//             }

//             indice = indice - 1;

//             bool novoValorValido = false;

//             while (novoValorValido == false)
//             {
//                 Console.WriteLine("Digite o novo valor:");
//                 novoValorValido = int.TryParse(Console.ReadLine(), out numeros[indice]);

//                 if (novoValorValido == false)
//                 {
//                     Console.WriteLine("Erro! Digite apenas números.");
//                 }
//             }

//             Console.WriteLine("\nValores atualizados:");
//             for (int i = 0; i < numeros.Length; i++)
//             {
//                 Console.WriteLine("Posição " + (i + 1) + ": " + numeros[i]);
//             }
//         }

//         Console.WriteLine("\nPrograma finalizado.");
//         Console.ReadKey();
//     }

// }



//  4° MODELO --------------------------------------------------------------------------------------  

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numeros = new int[5];

//         // Entrada dos números
//         for (int i = 0; i < 5; i++)
//         {
//             while (true)
//             {
//                 try
//                 {
//                     Console.Write("Digite um número: ");
//                     numeros[i] = int.Parse(Console.ReadLine());
//                     break; // sai do while se der certo
//                 }
//                 catch
//                 {
//                     Console.WriteLine("Digite apenas números!");
//                 }
//             }
//         }

//         // Mostrar valores
//         Console.WriteLine("\nValores digitados:");
//         for (int i = 0; i < 5; i++)
//         {
//             Console.WriteLine("Posição " + (i + 1) + ": " + numeros[i]);
//         }

//         // Perguntar se quer alterar
//         Console.WriteLine("\nDeseja alterar algum valor? (S/N)");
//         string resposta = Console.ReadLine();

//         if (resposta.ToUpper() == "S")
//         {
//             int indice;

//             while (true)
//             {
//                 try
//                 {
//                     Console.Write("Qual posição deseja alterar? (1 a 5): ");
//                     indice = int.Parse(Console.ReadLine());

//                     if (indice < 1 || indice > 5)
//                     {
//                         Console.WriteLine("Escolha entre 1 e 5.");
//                         continue;
//                     }

//                     break;
//                 }
//                 catch
//                 {
//                     Console.WriteLine("Digite apenas números!");
//                 }
//             }

//             while (true)
//             {
//                 try
//                 {
//                     Console.Write("Digite o novo valor: ");
//                     numeros[indice - 1] = int.Parse(Console.ReadLine());
//                     break;
//                 }
//                 catch
//                 {
//                     Console.WriteLine("Digite apenas números!");
//                 }
//             }

//             Console.WriteLine("\nValores atualizados:");
//             for (int i = 0; i < 5; i++)
//             {
//                 Console.WriteLine("Posição " + (i + 1) + ": " + numeros[i]);
//             }
//         }

//         Console.WriteLine("\nPrograma finalizado.");
//         Console.ReadKey();
//     }
// }


// ==========================================================

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[,] numeros = new int[4, 6]
//         {
//             {1,2,3,4,5,6},
//             {7,8,9,10,11,12},
//             {13,14,15,16,17,18},
//             {19,20,21,22,23,24}
//         };

//         for (int i = 0; i < 4; i++)
//         {
//             for (int j = 0; j < 6; j++)
//             {
//                 // Console.WriteLine("[" + i + "," + j + "] - " + numeros[i, j]);
//                 if (numeros[i, j] == 16)
//                 {
//                     Console.WriteLine("Número 16 está na posição: [" + (i+1) + "," + (j+1) + "]!");
//                     return;
//                 }
//             }
//         }
//     }
// }





