
using Dumpify;

IEnumerable<int> listaNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

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
listaNumeros.SkipWhile(x => x < 5).Dump();
listaNumeros.TakeWhile(x => x < 2).Dump();