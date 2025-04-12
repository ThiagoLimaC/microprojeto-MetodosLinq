﻿
using Dumpify;

IEnumerable<int> listaNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

IEnumerable<Pessoa> pessoas = [
        new ("Fernanda", 15),
        new ("Lucas", 18),
        new ("Carlos", 18),
        new ("Eduarda", 17),
        new ("Mia", 12),
    ];

// AVERAGE
//listaNumeros.Average().Dump();

// SUM 
//listaNumeros.Sum().Dump();

record Pessoa(string nome, int idade);


// MAXBY e MINBY
// Retorna o maior e menor valor de acordo com a propriedade passada
//pessoas.MaxBy(x => x.idade).Dump();
//pessoas.MinBy(x => x.idade).Dump();

// MAX e MIN
//listaNumeros.Max().Dump();
//listaNumeros.Min().Dump();

// COUNT
//listaNumeros.Count().Dump();

// APPEND e PREPEND
// Adiciona o número 15 ao final da lista
//listaNumeros.Append(15).Dump();
// Adiciona o número 20 ao início da lista
//listaNumeros.Prepend(20).Dump();

// CONTAINS
// Verifica se a lista contém o número 15
//listaNumeros.Contains(15).Dump();

// ALL
// Verifica se todos os números são maiores que 2
//listaNumeros.All(x => x > 2).Dump();

// ANY
// Verifica se existe algum número maior que 5
//listaNumeros.Any(x => x > 15).Dump();

// CHUNK
// Divide a lista em partes de X elementos
//listaNumeros.Chunk(3).Dump();


// WHERE
// listaNumeros.Where(num => num > 5).Dump();

// SKIP e TAKE
// pula os 5 primeiros
//listaNumeros.Skip(5).Dump();
// pega os 5 primeiros
//listaNumeros.Take(5).Dump();

// SkipLast e TakeLast
// pula os 5 últimos
//listaNumeros.SkipLast(5).Dump();
// pega os 5 últimos
//listaNumeros.TakeLast(5).Dump();

// SkipWhile e TakeWhile
// pula os números enquanto for menor que 5
//listaNumeros.SkipWhile(x => x < 5).Dump();
// pega os números enquanto for menor que 2
//listaNumeros.TakeWhile(x => x < 2).Dump();