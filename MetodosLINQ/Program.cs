using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 20 },
                new Pessoa { Nome = "Maria", Idade = 30 },
                new Pessoa { Nome = "José", Idade = 40 },
                new Pessoa { Nome = "Ana", Idade = 50 }
            };

            //1 - Metodo First - Retorna o primeiro elemento de uma coleção
            var pessoa = pessoas.First();
            Console.WriteLine(pessoa.Nome);

            //3 - Metodo any - Retorna true se houver algum elemento na coleção

            Console.WriteLine(pessoas.Any(p => p.Nome =="João")); //True
            Console.WriteLine(pessoas.Any(p => p.Nome == "Pedro")); //False

            //4 - Metodo All - Retorna true se todos os elementos da coleção atenderem a condição
            Console.WriteLine(pessoas.All(p => p.Idade > 18)); //True
            Console.WriteLine(pessoas.All(p => p.Idade > 30)); //False

            //5 - Metodo Count - Retorna a quantidade de elementos na coleção
            Console.WriteLine(pessoas.Count()); //4

            //6 - Metodo Max - Retorna o maior valor da coleção
            Console.WriteLine(pessoas.Max(p => p.Idade)); //50
            Console.WriteLine(pessoas.Max(p => p.Nome)); //Maria 

            //7 - Metodo Min - Retorna o menor valor da coleção
            Console.WriteLine(pessoas.Min(p => p.Idade)); //20
            Console.WriteLine(pessoas.Min(p => p.Nome)); //Ana

            //8 - Metodo OrderBy - Ordena a coleção em ordem crescente
            var pessoasOrdenadas = pessoas.OrderBy(p => p.Nome);
            foreach (var p in pessoasOrdenadas)
            {
                Console.WriteLine(p.Nome);
            }

            //9 - Metodo OrderByDescending - Ordena a coleção em ordem decrescente
            var pessoasOrdenadasDesc = pessoas.OrderByDescending(p => p.Nome);
            foreach (var p in pessoasOrdenadasDesc)
            {
                Console.WriteLine(p.Nome);
            }

            //10 - Metodo Skip - Pula uma quantidade de elementos da coleção
            var pessoasPuladas = pessoas.Skip(2);
            foreach (var p in pessoasPuladas)
            {
                Console.WriteLine(p.Nome);
            }


            //11 - Metodo Take - Retorna uma quantidade de elementos da coleção
            var pessoasRetornadas = pessoas.Take(2);
            foreach (var p in pessoasRetornadas)
            {
                Console.WriteLine(p.Nome);
            }

            //12 - Metodo Where - Retorna os elementos que atendem a condição
            var pessoasFiltradas = pessoas.Where(p => p.Idade > 30);
            foreach (var p in pessoasFiltradas)
            {
                Console.WriteLine(p.Nome);
            }

            //13 - Metodo Distinct - Retorna os elementos distintos da coleção
            var pessoasDistintas = pessoas.Distinct();
            foreach (var p in pessoasDistintas)
            {
                Console.WriteLine(p.Nome);
            }

            //14 - Metodo Concat - Concatena duas coleções
            var pessoas2 = new List<Pessoa>
            {
                new Pessoa { Nome = "Pedro", Idade = 60 },
                new Pessoa { Nome = "Paulo", Idade = 70 }
            };
            var pessoasConcatenadas = pessoas.Concat(pessoas2);
            foreach (var p in pessoasConcatenadas)
            {
                Console.WriteLine(p.Nome);
            }

            //15 - Metodo Intersect - Retorna os elementos que estão em ambas as coleções
            var pessoasIntersect = pessoas.Intersect(pessoas2);
            foreach (var p in pessoasIntersect)
            {
                Console.WriteLine(p.Nome);
            }

            //16 - Metodo Union - Retorna os elementos distintos de ambas as coleções
            var pessoasUnion = pessoas.Union(pessoas2);
            foreach (var p in pessoasUnion)
            {
                Console.WriteLine(p.Nome);
            }

            //17 - Metodo Except - Retorna os elementos que estão na primeira coleção e não estão na segunda
            var pessoasExcept = pessoas.Except(pessoas2);
            foreach (var p in pessoasExcept)
            {
                Console.WriteLine(p.Nome);
            }

            //18 - Metodo Average - Retorna a média dos valores da coleção
            Console.WriteLine(pessoas.Average(p => p.Idade)); 

            //19 - Metodo Sum - Retorna a soma dos valores da coleção
            Console.WriteLine(pessoas.Sum(p => p.Idade));

            //20 - Metodo ToList - Converte a coleção para uma lista
            var lista = pessoas.ToList();
            foreach (var p in lista)
            {
                Console.WriteLine(p.Nome);
            }

            //21 - Metodo ToArray - Converte a coleção para um array
            var array = pessoas.ToArray();
            foreach (var p in array)
            {
                Console.WriteLine(p.Nome);
            }

            //22 - Metodo ToDictionary - Converte a coleção para um dicionário
            var dicionario = pessoas.ToDictionary(p => p.Nome);
            foreach (var p in dicionario)
            {
                Console.WriteLine(p.Key + " - " + p.Value.Idade);
            }

            //23 - Metodo SkipWhile - Pula elementos enquanto a condição for verdadeira
            var pessoasPuladasWhile = pessoas.SkipWhile(p => p.Idade < 40);
            foreach (var p in pessoasPuladasWhile)
            {
                Console.WriteLine(p.Nome);
            }

            //24 - Metodo TakeWhile - Retorna elementos enquanto a condição for verdadeira
            var pessoasRetornadasWhile = pessoas.TakeWhile(p => p.Idade < 40);
            foreach (var p in pessoasRetornadasWhile)
            {
                Console.WriteLine(p.Nome);
            }

            //25 - Metodo ToLookup - Converte a coleção para um Lookup
            var lookup = pessoas.ToLookup(p => p.Idade);
            foreach (var p in lookup[20])
            {
                Console.WriteLine(p.Nome);
            }

            //26 - Metodo ElementAt - Retorna o elemento na posição informada
            Console.WriteLine(pessoas.ElementAt(2).Nome);

            //27 - Metodo ElementAtOrDefault - Retorna o elemento na posição informada ou um valor padrão
            Console.WriteLine(pessoas.ElementAtOrDefault(10)?.Nome);
            // 28 - Método Select - Projeção de uma sequência de elementos em uma nova forma
            var nomes = pessoas.Select(p => p.Nome);
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            // 29 - Método SelectMany - Projeção e aplanamento de uma sequência de sequências
            var todasAsLetrasDosNomes = pessoas.SelectMany(p => p.Nome);
            foreach (var letra in todasAsLetrasDosNomes)
            {
                Console.WriteLine(letra);
            }

            // 30 - Método GroupBy - Agrupa elementos com base em uma chave
            var pessoasAgrupadasPorIdade = pessoas.GroupBy(p => p.Idade);
            foreach (var grupo in pessoasAgrupadasPorIdade)
            {
                Console.Write($"Pessoas com idade {grupo.Key}: ");
                foreach (var p in grupo)
                {
                    Console.Write(p.Nome," ");
                }
                Console.WriteLine();
            }

            // 31 - Método Join - Junta duas sequências com base em uma chave de correspondência
            var cidades = new List<Cidade>
            {
                new Cidade { Nome = "São Paulo", CodigoPostal = 1000 },
                new Cidade { Nome = "Rio de Janeiro", CodigoPostal = 2000 },
                new Cidade { Nome = "Belo Horizonte", CodigoPostal = 3000 }
            };

            var pessoasComCidades = pessoas.Join(cidades,
                                                  p => pessoa.Idade,
                                                  cidade => cidade.CodigoPostal,
                                                  (p, cidade) => new
                                                  {
                                                      Pessoa = pessoa.Nome,
                                                      Cidade = cidade.Nome
                                                  });
            foreach (var item in pessoasComCidades)
            {
                Console.WriteLine($"{item.Pessoa} vive em {item.Cidade}");
            }


            Console.ReadKey();
        }

        class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
        }

        class Cidade
        {
            public string Nome { get; set; }
            public int CodigoPostal { get; set; }
        }
    }
}
