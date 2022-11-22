# Operadores

## Operadores Aritméticos

**1. operador módulo - `%`**

```
7%2 -> 1
1001%5 -> 1
5%3 -> 2
```

## Operador reflexivo

Fala sobre operadores que alteram o valor da própria variável usada na expressão matemática.

```cs
double totalParcial1 = 89.09, totalParcial2 = 43.34;

double total = 0;

total = total + totalParcial1;
total = total + totalParcial2;

Console.WriteLine(a);
```

reescrevendo com incremento
```cs
total += totalParcial1;
total += totalParcial2;

Console.WriteLine(a);
```

reescrevendo com decremento
```cs
double desconto = 45.78;

total -= desconto; // total = total - desconto
```

usando o `*=`

```cs
total *= 2; // total = total * 2
```

## Operador unário

**Operador `++`**

```cs
int a = 2;
a++; // a = a + 1
Console.WriteLine(a); // 3
```

**Operador `--`**

```cs
int a = 2;
a--; // a = a + 1
Console.WriteLine(a); // 1
```

## Operadores de comparação

1. testa igualdade: `==`
2. testa diferença: `!=`
3. maior ou igual que: `>=`
4. menor ou igual que: `<=`
5. nega uma expressão booleana: `!`

# Variáveis booleanas

```cs
bool interruptor = true; // true ou false
```

# Estruturas de Seleção

## Estrutura `if` - *SE*

```cs
int idade = 35;
bool condicao = (idade > 23);

if (condicao) {
  Console.WriteLine("Foi identificada uma idade ok!");
}
```

## Estrutura `if-else` - *SE...SENÃO...*

```cs
double nota = 8.9;

if(nota >= 7.0) {
  Console.WriteLine("Aprovado");
} else {
  Console.WriteLine("Reprovado");
}
```

## Estrutura `if-else if-else` - *SE... SENÃO SE... SENÃO*

sem o uso do `else if`:
```cs
if(nota >= 7.0) {
  Console.WriteLine("Aprovado");
} else {
  if(nota >= 4.0) {
    Console.WriteLine("Aprovado");
  } else {
    Console.WriteLine("Reprovado");
  }
}
```

usando multiplos `else if`'s:

```cs
  if(nota == 10.0) {
      Console.WriteLine("excelente!");
  } else if ( nota >= 7.0 ) {
      Console.WriteLine("Aprovado!");
  } else if ( nota >= 4.0 ) {
      Console.WriteLine("Recuperação");
  } else {
      Console.WriteLine("Reprovado");
  }
```