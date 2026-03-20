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












// 3° AULA - 24/02 ===========================================================================

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










// 4° Aula - 05/03 (Faltei) ==========================================================================================
// (PILHA)


// using System;

// class Program
// {
//     static int[] pilha = new int[5];

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n----MENU PILHA---- ");
//             Console.WriteLine("1 - Push (Inserir no topo)");
//             Console.WriteLine("2 - Pop (Remover do topo)");
//             Console.WriteLine("3 - Peek (Consultar topo)");
//             Console.WriteLine("0 - Sair");

//             opcao = LerOpcao();

//             switch (opcao)
//             {
//                 case 1:
//                     Push();
//                     break;
//                 case 2:
//                     Pop();
//                     break;
//                 case 3:
//                     Peek();
//                     break;
//                 case 0:
//                     Console.WriteLine("Encerrando...");
//                     break;
//             }

//         } while (opcao != 0);
//     }

    
//     static int LerOpcao()
//     {
//         int opcao;

//         while (true)
//         {
//             Console.Write("Escolha uma opcao: ");

//             if (!int.TryParse(Console.ReadLine(), out opcao))
//             {
//                 Console.WriteLine("Digite apenas numeros.");
//                 continue;
//             }

//             if (opcao < 0 || opcao > 3)
//             {
//                 Console.WriteLine("Escolha apenas entre 0 e 3.");
//                 continue;
//             }

//             return opcao;
//         }
//     }

//     static void Push()
//     {
//         if (pilha[pilha.Length - 1] != 0)
//         {
//             Console.WriteLine("Pilha cheia, numero nao inserido");
//             return;
//         }

//         Console.Write("Digite um numero para inserir: ");
//         if (!int.TryParse(Console.ReadLine(), out int numero))
//         {
//             Console.WriteLine("Apenas numeros sao permitidos");
//             return;
//         }

//         for (int i = 0; i < pilha.Length; i++)
//         {
//             if (pilha[i] == numero)
//             {
//                 Console.WriteLine("Numero já existe");
//                 return;
//             }
//         }

//         for (int i = 0; i < pilha.Length; i++)
//         {
//             if (pilha[i] == 0)
//             {
//                 pilha[i] = numero;
//                 Console.WriteLine("Numero inserido");
//                 return;
//             }
//         }
//     }

//     static void Pop()
//     {
//         for (int i = pilha.Length - 1; i >= 0; i--)
//         {
//             if (pilha[i] != 0)
//             {
//                 Console.WriteLine("Removido: " + pilha[i]);
//                 pilha[i] = 0;
//                 return;
//             }
//         }

//         Console.WriteLine("Pilha vazia!");
//     }

//     static void Peek()
//     {
//         for (int i = pilha.Length - 1; i >= 0; i--)
//         {
//             if (pilha[i] != 0)
//             {
//                 Console.WriteLine("Topo da pilha: " + pilha[i]);
//                 return;
//             }
//         }

//         Console.WriteLine("Pilha vazia!");
//     }
// }


// CODIGO PARA ESTUDO (PILHA)
// using System;

// class Program
// {
//     // Array que representa a pilha
//     static int[] pilha = new int[5];

//     // Variável que controla o topo da pilha
//     // Começa em -1 porque a pilha está vazia
//     static int topo = -1;

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n----MENU PILHA---- ");
//             Console.WriteLine("1 - Push (Inserir no topo)");
//             Console.WriteLine("2 - Pop (Remover do topo)");
//             Console.WriteLine("3 - Peek (Consultar topo)");
//             Console.WriteLine("0 - Sair");

//             opcao = LerOpcao();

//             switch (opcao)
//             {
//                 case 1:
//                     Push();
//                     break;
//                 case 2:
//                     Pop();
//                     break;
//                 case 3:
//                     Peek();
//                     break;
//                 case 0:
//                     Console.WriteLine("Encerrando...");
//                     break;
//             }

//         } while (opcao != 0);
//     }

//     // Método para ler opção com validação
//     static int LerOpcao()
//     {
//         int opcao;

//         while (true)
//         {
//             Console.Write("Escolha uma opcao: ");

//             if (!int.TryParse(Console.ReadLine(), out opcao))
//             {
//                 Console.WriteLine("Digite apenas numeros.");
//                 continue;
//             }

//             if (opcao < 0 || opcao > 3)
//             {
//                 Console.WriteLine("Escolha apenas entre 0 e 3.");
//                 continue;
//             }

//             return opcao;
//         }
//     }

//     // PUSH = inserir no topo
//     static void Push()
//     {
//         // Verifica se a pilha está cheia
//         if (topo == pilha.Length - 1)
//         {
//             Console.WriteLine("Pilha cheia!");
//             return;
//         }

//         Console.Write("Digite um numero: ");
//         if (!int.TryParse(Console.ReadLine(), out int numero))
//         {
//             Console.WriteLine("Apenas numeros!");
//             return;
//         }

//         // Sobe o topo
//         topo++;

//         // Insere o valor na posição do topo
//         pilha[topo] = numero;

//         Console.WriteLine("Numero inserido!");
//     }

//     // POP = remove do topo
//     static void Pop()
//     {
//         // Verifica se está vazia
//         if (topo == -1)
//         {
//             Console.WriteLine("Pilha vazia!");
//             return;
//         }

//         Console.WriteLine("Removido: " + pilha[topo]);

//         // "Remove" diminuindo o topo
//         topo--;
//     }

//     // PEEK = ver o topo
//     static void Peek()
//     {
//         if (topo == -1)
//         {
//             Console.WriteLine("Pilha vazia!");
//             return;
//         }

//         Console.WriteLine("Topo da pilha: " + pilha[topo]);
//     }
// }


// CODIGO PARA ESTUDO ( FILA )
using System;

class Program
{
    static int[] fila = new int[5];

    static int inicio = 0;
    static int fim = -1;

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n----MENU FILA---- ");
            Console.WriteLine("1 - Enqueue (Inserir)");
            Console.WriteLine("2 - Dequeue (Remover)");
            Console.WriteLine("3 - Front (Consultar inicio)");
            Console.WriteLine("0 - Sair");

            opcao = LerOpcao();

            switch (opcao)
            {
                case 1:
                    Enqueue();
                    break;
                case 2:
                    Dequeue();
                    break;
                case 3:
                    Front();
                    break;
                case 0:
                    Console.WriteLine("Encerrando...");
                    break;
            }

        } while (opcao != 0);
    }

    static int LerOpcao()
    {
        int opcao;

        while (true)
        {
            Console.Write("Escolha uma opcao: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Digite apenas numeros.");
                continue;
            }

            if (opcao < 0 || opcao > 3)
            {
                Console.WriteLine("Escolha apenas entre 0 e 3.");
                continue;
            }

            return opcao;
        }
    }

    static void Enqueue()
    {
        if (fim == fila.Length - 1)
        {
            Console.WriteLine("Fila cheia!");
            return;
        }

        Console.Write("Digite um numero: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Apenas numeros!");
            return;
        }

        fim++;
        fila[fim] = numero;

        Console.WriteLine("Numero inserido!");
    }

    static void Dequeue()
    {
        if (inicio > fim)
        {
            Console.WriteLine("Fila vazia!");
            return;
        }

        Console.WriteLine("Removido: " + fila[inicio]);
        inicio++;
    }

    static void Front()
    {
        if (inicio > fim)
        {
            Console.WriteLine("Fila vazia!");
            return;
        }

        Console.WriteLine("Inicio da fila: " + fila[inicio]);
    }
}

// TAREFA DE CASA 03/03 (AULA 04) ---------------------------------------------------------------------------
//(FILA)

//using System;
// class Program
// {
//     static int[] fila = new int[10];
//     static int fim = 0;

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             while (true)
//             {
//                 Console.WriteLine("\n=== MENU FILA ===");
//                 Console.WriteLine("1 - ENQUEUE (Inserir na fila)");
//                 Console.WriteLine("2 - DEQUEUE (Remover da fila)");
//                 Console.WriteLine("3 - PEEK (Ver início da fila)");
//                 Console.WriteLine("0 - Sair");
//                 Console.Write("Escolha uma opção: ");

//                 string entrada = Console.ReadLine();

//                 if (int.TryParse(entrada, out opcao) && opcao >= 0 && opcao <= 3)
//                     break;

//                 Console.WriteLine("Opção inválida. Digite um número entre 0 e 3.");
//             }

//             switch (opcao)
//             {
//                 case 1:
//                     int valor;

//                     while (true)
//                     {
//                         Console.Write("Digite um valor positivo: ");
//                         string entradaValor = Console.ReadLine();

//                         if (!int.TryParse(entradaValor, out valor))
//                             Console.WriteLine("Digite apenas números.");
//                         else if (valor < 0)
//                             Console.WriteLine("Não são permitidos números negativos.");
//                         else
//                             break;
//                     }

//                     Enqueue(valor);
//                     break;

//                 case 2:
//                     Dequeue();
//                     break;

//                 case 3:
//                     Peek();
//                     break;

//                 case 0:
//                     Console.WriteLine("Encerrando...");
//                     break;
//             }

//         } while (opcao != 0);
//     }

//     static void Enqueue(int valor)
//     {
//         if (fim == fila.Length)
//         {
//             Console.WriteLine("Fila cheia.");
//         }
//         else
//         {
//             fila[fim] = valor;
//             fim++;
//             Console.WriteLine("Valor inserido na fila.");
//         }
//     }

//     static void Dequeue()
//     {
//         if (fim == 0)
//         {
//             Console.WriteLine("Fila vazia.");
//             return;
//         }

//         Console.WriteLine("Valor removido: " + fila[0]);

        
//         for (int i = 0; i < fim - 1; i++)
//         {
//             fila[i] = fila[i + 1];
//         }

//         fim--;
//         fila[fim] = 0; 
//     }

//     static void Peek()
//     {
//         if (fim == 0)
//         {
//             Console.WriteLine("Fila vazia.");
//         }
//         else
//         {
//             Console.WriteLine("Primeiro valor da fila: " + fila[0]);
//         }
//     }
// }











 // 5° Aula - 10/03 ==========================================================================================
//  using System.Collections.Generic;

// public class Deck
// {
//     private LinkedList<int> deque = new LinkedList<int>();

//     public void AddFront(int valor)
//     {
//         deck.AddFirst(valor);
//     }

//     public void AddRear(int valor)
//     {
//         deck.AddLast(valor);
//     }

//     public int RemoveFront()
//     {
//         int valor = deque.First.Value;
//         deck.RemoveFirst();
//         return valor;
//     }

//     public int RemoveRear()
//     {
//         int valor = deque.Last.Value;
//         deck.RemoveLast();
//         return valor;
//     }

//     public int PeekFront()
//     {
//         return deck.First.Value;
//     }

//     public int PeekRear()
//     {
//         return deck.Last.Value;
//     }
// }