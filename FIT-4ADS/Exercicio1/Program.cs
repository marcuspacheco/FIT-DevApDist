using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercicio1
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Digite o número do exercício: ");
            var resposta = Console.ReadLine();
            if (!string.IsNullOrEmpty(resposta))
            {
                if (int.TryParse(resposta, out var numero))
                {
                    if (numero < 1 || numero > 10)
                    {
                        Console.WriteLine("Os exercícios são de 1 até 10.");
                        Console.ReadLine();
                        Environment.Exit(160);
                    }
                    else
                    {
                        Invoker.CreateAndInvoke("Exercicio1.Program", $"Exercicio{numero}");
                    }
                }
                else
                {
                    Console.WriteLine($"{resposta} não é número!");
                    Console.ReadLine();
                    Environment.Exit(160);
                }
            }
        }

        public void Exercicio1()
        {
            var total = 0;
            for (var i = 1; i < 101; i++)
            {
                total += i;
            }
            Console.WriteLine($"A soma dos números naturais de 1 ao 100 é: {total}!");
            Console.ReadLine();
        }

        public void Exercicio2()
        {
            Console.WriteLine("Múltiplos de 7 menores que 200:");
            for (var i = 7; i < 200; i += 7)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public void Exercicio3()
        {
            Console.WriteLine("Divisíveis por 4 menores do que 100:");
            for (var i = 4; i < 100; i++)
            {
                if (i % 4 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public void Exercicio4()
        {
            Console.Write("Informe X: ");
            var resposta = Console.ReadLine();
            if (!string.IsNullOrEmpty(resposta))
            {
                if (int.TryParse(resposta, out var numero))
                {
                    var resultado = 0;
                    for (var i = 1; i < 21; i++)
                    {
                        if (i % 2 == 1)
                            resultado += numero / i;
                        else
                            resultado -= numero / i;
                    }
                    Console.WriteLine($"O valor é igual a {resultado}!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine($"{resposta} não é número!");
                Console.ReadLine();
                Environment.Exit(160);
            }
        }

        public void Exercicio5()
        {
            Console.WriteLine("Tabuada do 5 (For):");
            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine($"5 x {i.ToString().PadLeft(2, '0')} = { 5 * i}");
            }
            Console.WriteLine();
            Console.WriteLine("Tabuada do 5 (While):");

            var i2 = 1;
            while (i2 < 11)
            {
                Console.WriteLine($"5 x {i2.ToString().PadLeft(2, '0')} = {5 * i2}");
                i2++;
            }
            Console.ReadLine();
        }

        public void Exercicio6()
        {
            var numero = 1;
            while (numero != -1)
            {
                Console.Write("Informe X: ");
                var resposta = Console.ReadLine();
                if (!string.IsNullOrEmpty(resposta))
                {
                    if (int.TryParse(resposta, out numero))
                    {
                        if (numero == -1)
                            break;

                        Console.WriteLine("Tabuada do 5 (For):");
                        for (var i = 1; i < 11; i++)
                        {
                            Console.WriteLine($"{numero} x {i.ToString().PadLeft(2, '0')} = {numero * i}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tabuada do 5 (While):");

                        var i2 = 1;
                        while (i2 < 11)
                        {
                            Console.WriteLine($"{numero} x {i2.ToString().PadLeft(2, '0')} = {numero * i2}");
                            i2++;
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine($"{resposta} não é número!");
                    Console.ReadLine();
                    Environment.Exit(160);
                }
            }
        }

        public void Exercicio7()
        {
            var i = 0;
            double totalV = 0, totalP = 0;
            while (i < 26)
            {
                Console.Write("Informe a transação: ");
                var transacao = Console.ReadLine();
                if (transacao != null)
                {
                    var valor = Regex.Match(transacao, @"\d+").Value;
                    var dblValor = 0.0;
                    if (valor.Length > 0)
                    {
                        dblValor = double.Parse(valor);
                    }
                    if (transacao.Contains("v"))
                    {
                        totalV += dblValor;

                    }
                    else if (transacao.Contains("p"))
                    {
                        totalP += dblValor;
                    }
                }

                i++;
            }

            Console.WriteLine($"Valor total das compras à vista: R${totalV}!");
            Console.WriteLine($"Valor total das compras a prazo: R${totalP}!");
            Console.WriteLine($"Valor total das compras efetuadas: R${totalV + totalP}!");
            Console.WriteLine($"Valor a receber pelas compras a prazo: R${totalP / 3}!");
            Console.ReadLine();
        }

        public void Exercicio8()
        {
            Console.Write("Informe a quantidade de notas: ");
            var resposta = Console.ReadLine();
            if (!string.IsNullOrEmpty(resposta))
            {
                if (int.TryParse(resposta, out var quantidade))
                {
                    var notas = new double[quantidade];
                    var i = 0;
                    while (i < quantidade)
                    {
                        Console.Write("Informe a nota: ");
                        var notaLine = Console.ReadLine();
                        if (!string.IsNullOrEmpty(notaLine))
                        {
                            if (double.TryParse(notaLine, out var nota))
                            {
                                notas[i] = nota;
                            }
                        }
                        i++;
                    }

                    var media = notas.Average();
                    var menores = new List<double>();
                    Console.WriteLine($"A média das notas é: {media}!");
                    Console.WriteLine("Notas maiores do que a média:");
                    foreach (var n in notas)
                    {
                        if (n > media)
                        {
                            Console.WriteLine(n);
                        }
                        else if (n < media)
                        {
                            menores.Add(n);
                        }
                    }
                    menores.Sort();

                    Console.WriteLine("Notas menores do que a média:");
                    foreach (var n in menores)
                    {
                        Console.WriteLine(n);
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{resposta} não é número!");
                    Console.ReadLine();
                    Environment.Exit(160);
                }
            }
        }

        public void Exercicio9()
        {
            Console.Write("Informe a quantidade de notas: ");
            var resposta = Console.ReadLine();
            if (!string.IsNullOrEmpty(resposta))
            {
                if (int.TryParse(resposta, out var quantidade))
                {
                    var i = 0;
                    var conjunto = new Dictionary<string, double>();
                    while (i < quantidade)
                    {
                        Console.Write("Informe o nome: ");
                        var nome = Console.ReadLine();
                        if (!string.IsNullOrEmpty(nome))
                        {
                            Console.Write("Informe a nota: ");
                            var notaLine = Console.ReadLine();
                            if (!string.IsNullOrEmpty(nome))
                            {
                                if (double.TryParse(notaLine, out var nota))
                                {
                                    conjunto.Add(nome, nota);
                                }
                            }
                        }
                        i++;
                    }

                    var media = conjunto.Values.Average();
                    //var total = 0.0;
                    //foreach (var c in conjunto)
                    //{
                    //    total += c.Value;
                    //}
                    //media = total / conjunto.Count;
                    Console.WriteLine($"Alunos com nota maior do que a média ({media}):");
                    foreach (var c in conjunto)
                    {
                        if (c.Value > media)
                        {
                            Console.WriteLine(c.Key);
                        }
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{resposta} não é número!");
                    Console.ReadLine();
                    Environment.Exit(160);
                }
            }
        }

        public void Exercicio10()
        {
            var salario = 0.0;
            var salarios = new List<double>();
            while (salario != -1)
            {
                Console.Write("Informe o salário: ");
                var resposta = Console.ReadLine();
                if (!string.IsNullOrEmpty(resposta))
                {
                    if (double.TryParse(resposta, out salario))
                    {
                        if (salario == -1)
                            break;

                        salarios.Add(salario);
                    }
                }
                else
                {
                    Console.WriteLine($"{resposta} não é número!");
                    Console.ReadLine();
                    Environment.Exit(160);
                }
            }

            Console.Write("Informe o valor do reajuste: ");
            var reajuste = Console.ReadLine();
            if (!string.IsNullOrEmpty(reajuste))
            {
                if (double.TryParse(reajuste, out var dblReajuste))
                {
                    foreach (var s in salarios)
                    {
                        Console.WriteLine(s * dblReajuste);
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{reajuste} não é número!");
                    Console.ReadLine();
                    Environment.Exit(160);
                }
            }
            else
            {
                Console.WriteLine($"{reajuste} não é número!");
                Console.ReadLine();
                Environment.Exit(160);
            }
        }
    }

    public static class Invoker
    {
        public static object CreateAndInvoke(string typeName, string methodName)
        {
            var type = Type.GetType(typeName);
            var instance = Activator.CreateInstance(type ?? throw new InvalidOperationException(), null);

            var method = type.GetMethod(methodName);
            return method.Invoke(instance, null);
        }
    }
}