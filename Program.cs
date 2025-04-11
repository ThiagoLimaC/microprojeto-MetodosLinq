
using Dumpify;

IEnumerable<int> listaNumeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// WHERE
// listaNumeros.Where(num => num > 5).Dump();

listaNumeros.Skip(5).Dump();
