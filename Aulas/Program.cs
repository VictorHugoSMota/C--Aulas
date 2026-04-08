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
//     static int[] pilha = new int[5];

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

//         topo++;
//         pilha[topo] = numero;

//         Console.WriteLine("Numero inserido!");
//     }

//     static void Pop()
//     {
//         if (topo == -1)
//         {
//             Console.WriteLine("Pilha vazia!");
//             return;
//         }

//         Console.WriteLine("Removido: " + pilha[topo]);
//         topo--;
//     }

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
// using System;

// class Program
// {
//     static int[] fila = new int[5];

//     static int inicio = 0;
//     static int fim = -1;

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n----MENU FILA---- ");
//             Console.WriteLine("1 - Enqueue (Inserir)");
//             Console.WriteLine("2 - Dequeue (Remover)");
//             Console.WriteLine("3 - Front (Consultar inicio)");
//             Console.WriteLine("0 - Sair");

//             opcao = LerOpcao();

//             switch (opcao)
//             {
//                 case 1:
//                     Enqueue();
//                     break;
//                 case 2:
//                     Dequeue();
//                     break;
//                 case 3:
//                     Front();
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

//     static void Enqueue()
//     {
//         if (fim == fila.Length - 1)
//         {
//             Console.WriteLine("Fila cheia!");
//             return;
//         }

//         Console.Write("Digite um numero: ");
//         if (!int.TryParse(Console.ReadLine(), out int numero))
//         {
//             Console.WriteLine("Apenas numeros!");
//             return;
//         }

//         fim++;
//         fila[fim] = numero;

//         Console.WriteLine("Numero inserido!");
//     }

//     static void Dequeue()
//     {
//         if (inicio > fim)
//         {
//             Console.WriteLine("Fila vazia!");
//             return;
//         }

//         Console.WriteLine("Removido: " + fila[inicio]);
//         inicio++;
//     }

//     static void Front()
//     {
//         if (inicio > fim)
//         {
//             Console.WriteLine("Fila vazia!");
//             return;
//         }

//         Console.WriteLine("Inicio da fila: " + fila[inicio]);
//     }
// }

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










 // 6° Aula - 24/03 ==========================================================================================


//  1° MODELO --------------------------------------------------------------------------------------  

// using System;

// class Program
// {
//     static int HashFunction(int key, int tableSize)
//     {
//         return key % tableSize;
//     }

//     static void InserirValor(int[] tabela, int key, int tableSize)
//     {
//         int pos = HashFunction(key, tableSize);

//         while (tabela[pos] != 0)
//         {
//             pos = (pos + 1) % tableSize;
//         }

//         tabela[pos] = key;
//     }

//     static void Main()
//     {
//         int tamanho = 5;
//         int[] tabela = new int[tamanho];

//         int[] valores = { 10, 22, 31, 4, 15 };

//         foreach (int v in valores)
//         {
//             InserirValor(tabela, v, tamanho);
//         }

//         for (int i = 0; i < tamanho; i++)
//         {
//             Console.WriteLine($"[{i}] = {tabela[i]}");
//         }
//     }
// }


//  2° MODELO --------------------------------------------------------------------------------------  

// using System;
// class Program
// {

// int HashFunction (int key, int tableSize)
//     {
//         return key % tableSize;
//     }

// static void InseriValor()
// {
    
// }
// }


//  3° MODELO --------------------------------------------------------------------------------------

// using System;

// class Carro{
    
// }

// class Program
// {
//     static int tableSize = 5;
//     static int[] tabela = new int[tableSize];

//     static int HashFunction(int key, int tableSize)
//     {
//         return key % tableSize;
//     }

//     static void InserirValor(int key)
//     {
//         int pos = HashFunction(key, tableSize);

//         tabela[pos] = key;
//     }

//     static void Main()
//     {
//         InserirValor(10);
//         InserirValor(22);
//         InserirValor(31);
//         InserirValor(40);

//         for (int i = 0; i < tableSize; i++)
//         {
//             Console.WriteLine($"[{i}] = {tabela[i]}");
//         }
//     }
// }


//  4° MODELO --------------------------------------------------------------------------------------  

// using System;
// class Carro
// {
//     public int Id;
//     public string Modelo;

//     public Carro(int id, string modelo)
//     {
//         Id = id;
//         Modelo = modelo;
//     }
// }

// class Program
// {
//     static int tableSize = 5;
//     static Carro[] tabela = new Carro[tableSize];

//     static int HashFunction(int key, int tableSize)
//     {
//         return key % tableSize;
//     }

//     static void InserirCarro(Carro carro)
//     {
//         int pos = HashFunction(carro.Id, tableSize);

//         tabela[pos] = carro;
//     }

//     static void Main()
//     {
//         InserirCarro(new Carro(10, "Civic"));
//         InserirCarro(new Carro(22, "Corolla"));
//         InserirCarro(new Carro(31, "HB20"));
//         InserirCarro(new Carro(4, "Gol"));
//         InserirCarro(new Carro(15, "Onix"));

//         for (int i = 0; i < tableSize; i++)
//         {
//             if (tabela[i] != null)
//                 Console.WriteLine($"[{i}] = {tabela[i].Id} - {tabela[i].Modelo}");
//             else
//                 Console.WriteLine($"[{i}] = vazio");
//         }
//     }
// }

// 7° Aula - 31/03 (FALTEI) ==========================================================================================


//  1° MODELO -------------------------------------------------------------------------------------- 

// using System;

// class Aluno
// {
//     public int Matricula;
//     public string Nome;

//     public Aluno(int Matricula, string Nome)
//     {
//         Matricula = matricula;
//         Nome = nome;
//     }
// }

// class Program
// {
//     static int tableSize = 5;
//     static Aluno[] tabela = new Aluno[tableSize];
//     static bool[] removido = new bool[tableSize];

//     static int HashFunction(int key)
//     {
//         return key % tableSize;
//     }

    
//     static void InserirAluno()
//     {
//         Console.Write("Matricula: ");
//         int matricula = int.Parse(Console.ReadLine());

//         Console.Write("Nome: ");
//         string nome = Console.ReadLine();

//         int pos = HashFunction(id);
//         int i = 0;

//         while (tabela[pos] != null && !removido[pos])
//         {
//             i++;
//             pos = (HashFunction(matricula) + i) % tableSize;

//             if (i >= tableSize)
//             {
//                 Console.WriteLine("Tabela cheia!");
//                 return;
//             }
//         }

//         tabela[pos] = new Aluno(matricula, nome);
//         removido[pos] = false;

//         Console.WriteLine("Aluno inserido com sucesso");
//     }

    
//     static void Listar()
//     {
//         Console.WriteLine("\n--- TABELA HASH ---");

//         for (int i = 0; i < tableSize; i++)
//         {
//             if (tabela[i] != null && !removido[i])
//                 Console.WriteLine("[" + i + "] = " + tabela[i].Matricula + " - " + tabela[i].Nome);
//             else
//                 Console.WriteLine("[" + i + "] = vazio");
//         }
//     }

   
//     static void Remover()
//     {
//         Console.Write("Digite a matricula para remover: ");
//         int matricula = int.Parse(Console.ReadLine());

//         int pos = HashFunction(id);
//         int i = 0;

//         while (tabela[pos] != null)
//         {
//             if (tabela[pos].Matricula == matricula && !removido[pos])
//             {
//                 removido[pos] = true; /
//                 Console.WriteLine("Aluno removido!");
//                 return;
//             }

//             i++;
//             pos = (HashFunction(id) + i) % tableSize;

//             if (i >= tableSize)
//                 break;
//         }

//         Console.WriteLine("Aluno não encontrado");
//     }

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n==== MENU ====");
//             Console.WriteLine("1 - Inserir aluno");
//             Console.WriteLine("2 - Listar alunos");
//             Console.WriteLine("3 - Remover aluno");
//             Console.WriteLine("4 - Sair");
//             Console.Write("Escolha: ");

//             opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     InserirCarro();
//                     break;

//                 case 2:
//                     Listar();
//                     break;

//                 case 3:
//                     Remover();
//                     break;

//                 case 4:
//                     Console.WriteLine("Saindo...");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida!");
//                     break;
//             }

//         } while (opcao != 4);
//     }
// }


//  2° MODELO -------------------------------------------------------------------------------------- 

// using System;

// class Aluno
// {
//     public int Matricula;
//     public string Nome;

//     public Aluno(int matricula, string nome)
//     {
//         this.Matricula = matricula;
//         this.Nome = nome;
//     }
// }

// class Program
// {
//     static int tableSize = 5;
//     static Aluno[] tabela = new Aluno[tableSize];
//     static bool[] removido = new bool[tableSize];

//     static int HashFunction(int key)
//     {
//         return key % tableSize;
//     }

    
//     static void InserirAluno()
//     {
//         Console.Write("Matricula: ");
//         int matricula = int.Parse(Console.ReadLine());

//         Console.Write("Nome: ");
//         string nome = Console.ReadLine();

//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null && !removido[pos])
//         {
//             i++;
//             pos = (HashFunction(matricula) + i) % tableSize;

//             if (i >= tableSize)
//             {
//                 Console.WriteLine("Tabela cheia!");
//                 return;
//             }
//         }

//         tabela[pos] = new Aluno(matricula, nome);
//         removido[pos] = false;

//         Console.WriteLine("Aluno inserido com sucesso");
//     }

    
//     static void Listar()
//     {
//         Console.WriteLine("\n--- TABELA HASH ---");

//         for (int i = 0; i < tableSize; i++)
//         {
//             if (tabela[i] != null && !removido[i])
//                 Console.WriteLine("[" + i + "] = " + tabela[i].Matricula + " - " + tabela[i].Nome);
//             else
//                 Console.WriteLine("[" + i + "] = vazio");
//         }
//     }

   
//     static void Remover()
//     {
//         Console.Write("Digite a matricula para remover: ");
//         int matricula = int.Parse(Console.ReadLine());

//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null)
//         {
//             if (tabela[pos].Matricula == matricula && !removido[pos])
//             {
//                 removido[pos] = true; 
//                 Console.WriteLine("Aluno removido!");
//                 return;
//             }

//             i++;
//             pos = (HashFunction(matricula) + i) % tableSize;

//             if (i >= tableSize)
//                 break;
//         }

//         Console.WriteLine("Aluno não encontrado");
//     }

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n==== MENU ====");
//             Console.WriteLine("1 - Inserir aluno");
//             Console.WriteLine("2 - Listar alunos");
//             Console.WriteLine("3 - Remover aluno");
//             Console.WriteLine("4 - Sair");
//             Console.Write("Escolha: ");

//             opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     InserirAluno();
//                     break;

//                 case 2:
//                     Listar();
//                     break;

//                 case 3:
//                     Remover();
//                     break;

//                 case 4:
//                     Console.WriteLine("Saindo...");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida!");
//                     break;
//             }

//         } while (opcao != 4);
//     }
// }


//  3° MODELO -------------------------------------------------------------------------------------- 

// using System;

// class Aluno
// {
//     public int Matricula;
//     public string Nome;

//     public Aluno(int matricula, string nome)
//     {
//         this.Matricula = matricula;
//         this.Nome = nome;
//     }
// }

// class Program
// {
//     static int tableSize = 100;
//     static Aluno[] tabela = new Aluno[tableSize];
//     static bool[] removido = new bool[tableSize];

//     static int HashFunction(int key)
//     {
//         return key % tableSize;
//     }

//     // funcao para contar quantos alunos tem na tabela para saber se esta acima de 70
//     static int QuantidadeElementos()
//     {
//         int count = 0;

//         for (int i = 0; i < tableSize; i++)
//         {
//             if (tabela[i] != null && !removido[i])
//                 count++;
//         }

//         return count;
//     }

//     // funcao que define se é quadratico ou linear, usada no metodos inseriraluno
//     static int ProximaPosicao(int matricula, int i)
//     {
//         double fatorCarga = (double)QuantidadeElementos() / tableSize;

//         if (fatorCarga >= 0.7) // quadratico
//             return (HashFunction(matricula) + i * i) % tableSize;
//         else 
//             return (HashFunction(matricula) + i) % tableSize; // linear
//     }

//     static bool ExisteMatricula(int matricula)
//     {
//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null)
//         {
//             if (tabela[pos].Matricula == matricula && !removido[pos])
//             {
//                 return true;
//             }

//             i++;
//             pos = ProximaPosicao(matricula, i); // funcao que define se é quadratico ou linear

//             if (i >= tableSize)
//                 break;
//         }

//         return false;
//     }

//     static void InserirAluno()
//     {
//         Console.Write("Matricula: ");
//         int matricula = int.Parse(Console.ReadLine());

//         if (ExisteMatricula(matricula))
//         {
//             Console.WriteLine("Erro: matricula ja cadastrada");
//             return;
//         }

//         Console.Write("Nome: ");
//         string nome = Console.ReadLine();

//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null && !removido[pos])
//         {
//             i++;
//             pos = ProximaPosicao(matricula, i); // funcao que define se e quadratico ou linear

//             if (i >= tableSize)
//             {
//                 Console.WriteLine("Tabela cheia!");
//                 return;
//             }
//         }

//         tabela[pos] = new Aluno(matricula, nome);
//         removido[pos] = false;

//         Console.WriteLine("Aluno inserido com sucesso");
//     }

//     static void Listar()
//     {
//         Console.WriteLine("\n--- TABELA HASH ---");

//         for (int i = 0; i < tableSize; i++)
//         {
//             if (tabela[i] != null && !removido[i])
//                 Console.WriteLine("[" + i + "] = " + tabela[i].Matricula + " - " + tabela[i].Nome);
//             else
//                 Console.WriteLine("[" + i + "] = vazio");
//         }
//     }

//     static void Remover()
//     {
//         Console.Write("Digite a matricula para remover: ");
//         int matricula = int.Parse(Console.ReadLine());

//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null)
//         {
//             if (tabela[pos].Matricula == matricula && !removido[pos])
//             {
//                 removido[pos] = true;
//                 Console.WriteLine("Aluno removido!");
//                 return;
//             }

//             i++;
//             pos = ProximaPosicao(matricula, i); // Função que define se é quadratico ou linear

//             if (i >= tableSize)
//                 break;
//         }

//         Console.WriteLine("Aluno não encontrado");
//     }

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n==== MENU ====");
//             Console.WriteLine("1 - Inserir aluno");
//             Console.WriteLine("2 - Listar alunos");
//             Console.WriteLine("3 - Remover aluno");
//             Console.WriteLine("4 - Sair");
//             Console.Write("Escolha: ");

//             opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     InserirAluno();
//                     break;

//                 case 2:
//                     Listar();
//                     break;

//                 case 3:
//                     Remover();
//                     break;

//                 case 4:
//                     Console.WriteLine("Saindo...");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida!");
//                     break;
//             }

//         } while (opcao != 4);
//     }
// }


//  4° MODELO -------------------------------------------------------------------------------------- 

// using System;

// class Aluno
// {
//     public int Matricula;
//     public string Nome;

//     public Aluno(int matricula, string nome)
//     {
//         this.Matricula = matricula;
//         this.Nome = nome;
//     }
// }

// class Program
// {
//     static int tableSize = 100;
//     static Aluno[] tabela = new Aluno[tableSize];
//     static bool[] removido = new bool[tableSize];

    
//     static int HashFunction(int key)
//     {
//         return key % tableSize;
//     }

//     // funcao de double hash
//     static int DoubleHashing(int key, int tableSize, int attempt)
//     {
//         int hash1 = HashFunction(key) % tableSize;

//         int hash2 = 1 + (key % (tableSize - 1));

//         return (hash1 + attempt * hash2) % tableSize;
//     }

//     // funcao para contar a quantidade de elementos
//     static int QuantidadeElementos()
//     {
//         int count = 0;

//         for (int i = 0; i < tableSize; i++)
//         {
//             if (tabela[i] != null && !removido[i])
//                 count++;
//         }

//         return count;
//     }

//     // funcao para definir qua hash utilizar com base na quatidade de elementos da tabela
//     static int ProximaPosicao(int matricula, int i)
//     {
//         double fatorCarga = (double)QuantidadeElementos() / tableSize;

//         if (fatorCarga >= 0.8) // DOUBLE HASHING
//             return DoubleHashing(matricula, tableSize, i);

//         else if (fatorCarga >= 0.7) // QUADRATICO
//             return (HashFunction(matricula) + i * i) % tableSize;

//         else // LINEAR
//             return (HashFunction(matricula) + i) % tableSize;
//     }

//     static bool ExisteMatricula(int matricula)
//     {
//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null)
//         {
//             if (tabela[pos].Matricula == matricula && !removido[pos])
//             {
//                 return true;
//             }

//             i++;
//             pos = ProximaPosicao(matricula, i);

//             if (i >= tableSize)
//                 break;
//         }

//         return false;
//     }

//     static void InserirAluno()
//     {
//         Console.Write("Matricula: ");
//         int matricula = int.Parse(Console.ReadLine());

//         if (ExisteMatricula(matricula))
//         {
//             Console.WriteLine("Erro: matricula ja cadastrada");
//             return;
//         }

//         Console.Write("Nome: ");
//         string nome = Console.ReadLine();

//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null && !removido[pos])
//         {
//             i++;
//             pos = ProximaPosicao(matricula, i);

//             if (i >= tableSize)
//             {
//                 Console.WriteLine("Tabela cheia!");
//                 return;
//             }
//         }

//         tabela[pos] = new Aluno(matricula, nome);
//         removido[pos] = false;

//         Console.WriteLine("Aluno inserido com sucesso");
//     }

//     static void Listar()
//     {
//         Console.WriteLine("\n--- TABELA HASH ---");

//         for (int i = 0; i < tableSize; i++)
//         {
//             if (tabela[i] != null && !removido[i])
//                 Console.WriteLine("[" + i + "] = " + tabela[i].Matricula + " - " + tabela[i].Nome);
//             else
//                 Console.WriteLine("[" + i + "] = vazio");
//         }
//     }

//     static void Remover()
//     {
//         Console.Write("Digite a matricula para remover: ");
//         int matricula = int.Parse(Console.ReadLine());

//         int pos = HashFunction(matricula);
//         int i = 0;

//         while (tabela[pos] != null)
//         {
//             if (tabela[pos].Matricula == matricula && !removido[pos])
//             {
//                 removido[pos] = true;
//                 Console.WriteLine("Aluno removido!");
//                 return;
//             }

//             i++;
//             pos = ProximaPosicao(matricula, i);

//             if (i >= tableSize)
//                 break;
//         }

//         Console.WriteLine("Aluno não encontrado");
//     }

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n==== MENU ====");
//             Console.WriteLine("1 - Inserir aluno");
//             Console.WriteLine("2 - Listar alunos");
//             Console.WriteLine("3 - Remover aluno");
//             Console.WriteLine("4 - Sair");
//             Console.Write("Escolha: ");

//             opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     InserirAluno();
//                     break;

//                 case 2:
//                     Listar();
//                     break;

//                 case 3:
//                     Remover();
//                     break;

//                 case 4:
//                     Console.WriteLine("Saindo...");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida!");
//                     break;
//             }

//         } while (opcao != 4);
//     }
// }










// 8° Aula - 07/04 ==========================================================================================


//  1° MODELO -------------------------------------------------------------------------------------- 

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static HashSet<int> conjunto = new HashSet<int>();

//     static void Main()
//     {
//         int opcao;

//         do
//         {
//             Console.WriteLine("\n==== MENU ====");
//             Console.WriteLine("1 - ADD");
//             Console.WriteLine("2 - REMOVE");
//             Console.WriteLine("3 - CONTAINS");
//             Console.WriteLine("4 - Sair");
//             Console.Write("Escolha: ");

//             opcao = int.Parse(Console.ReadLine());

//             switch (opcao)
//             {
//                 case 1:
//                     MetodoAdd();
//                     break;

//                 case 2:
//                     MetodoRemove();
//                     break;

//                 case 3:
//                     MetodoContains();
//                     break;

//                 case 4:
//                     Console.WriteLine("Saindo...");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida!");
//                     break;
//             }

//         } while (opcao != 4);
//     }

//     static void MetodoAdd()
//     {
//         Console.Write("Digite um número: ");
//         int num = int.Parse(Console.ReadLine());

//         if (conjunto.Add(num))
//             Console.WriteLine("Número adicionado!");
//         else
//             Console.WriteLine("Número já existe!");
//     }

//     static void MetodoContains()
//     {
//         Console.Write("Digite um número: ");
//         int num = int.Parse(Console.ReadLine());

//         if (conjunto.Contains(num))
//             Console.WriteLine("O número existe!");
//         else
//             Console.WriteLine("O número NÃO existe!");
//     }

//     static void MetodoRemove()
//     {
//         Console.Write("Digite um número: ");
//         int num = int.Parse(Console.ReadLine());

//         if (conjunto.Remove(num))
//             Console.WriteLine("Número removido!");
//         else
//             Console.WriteLine("Número não encontrado!");
//     }
// }


//  2° MODELO -------------------------------------------------------------------------------------- 

using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> UsuarioInput = new HashSet<int>();
    static HashSet<int> AutoInput = new HashSet<int>() { 1,2,3,4,5,6,7,8,9,10 };
    static HashSet<int> Uniao = new HashSet<int>();

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1 - ADD");
            Console.WriteLine("2 - REMOVE");
            Console.WriteLine("3 - CONTAINS");
            Console.WriteLine("4 - ATUALIZAR UNIÃO");
            Console.WriteLine("5 - MOSTRAR UNIÃO");
            Console.WriteLine("6 - SAIR");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    MetodoAdd();
                    break;

                case 2:
                    MetodoRemove();
                    break;

                case 3:
                    MetodoContains();
                    break;

                case 4:
                    AtualizarUniao();
                    Console.WriteLine("União atualizada!");
                    break;

                case 5:
                    Uniao();
                    break;

                case 6:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 6);
    }

    static void MetodoAdd()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (UsuarioInput.Add(num))
            Console.WriteLine("Número adicionado!");
        else
            Console.WriteLine("Número já existe!");
    }

    static void MetodoRemove()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (UsuarioInput.Remove(num))
            Console.WriteLine("Número removido!");
        else
            Console.WriteLine("Número não encontrado!");
    }

    static void MetodoContains()
    {
        Console.Write("Digite um número: ");
        int num = int.Parse(Console.ReadLine());

        if (UsuarioInput.Contains(num))
            Console.WriteLine("O número existe!");
        else
            Console.WriteLine("O número NÃO existe!");
    }

    static void Uniao()
    {
        Uniao = new HashSet<int>(AutoInput);
        Uniao.UnionWith(UsuarioInput);
    }

    static void MostrarUniao()
    {
        Console.WriteLine("União:");

        foreach (var item in Uniao)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}