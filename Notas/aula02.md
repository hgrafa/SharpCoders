# Saídas no C#

## 1. Concatenação

Atalho `cw` + `tab` + `tab`

```C#
Console.WriteLine("Olá," + " Hugo!");
```

saída
```
Olá, Hugo

```

```c#
Console.Write("Testando sem");
Console.Write("quebra de linha");
```

saída
```
Testando semquebra de linha
```

## 2. Interpolação

```c#
string nomeDoUsuario = "João"; 
Console.WriteLine($"O nome do usuário deste projeto é {nomeDoUsuario}")
```

## 3. Interporlação por referência

```c#
Console.WriteLine("O nome do usuario deste projeto é {0} {1} {2}", nomeDoUsuario, codigoDoUsuario, codigoDoUsuario);
```

# Variáveis

Servem para guardar dados em memória durante a execução de um programa.

|nome|ideia|exemplo|
|:-:|:-:|:-:|
|inteiro|guarda inteiros|`int idade`|
|double|guarda numeros reais|`double altura`|
|string|guarda textos|`string nome`|
|character|guarda caracteres|`char sexo`|
|float|guarda numeros reais|`float nota`|
|long|guarda inteiros|`long identificador`|

```c#
  string nome = "Joao da Silva";
  int idade = 21;
  double altura = 1.8;
  float nota = 8.9f;
  char sexo = 'M';
  long identificador = 4L;
```

# Leitura de dados

Para leitura usamos o comando:

```cs
Console.ReadLine()
```

Ele retorna toda a linha lida até apertarmos a tecla `enter`. O seu retorno de leitura é do tipo `string`, capturando tudo que foi escrito em forma de texto.

## Lendo outros tipos

Para ler outros tipos podemos converter para o tipo desejado e guardar em outras variáveis.

```cs
 int a = int.Parse(Console.ReadLine());
 double a = double.Parse(Console.ReadLine());
 float a = float.Parse(Console.ReadLine());
 char a = char.Parse(Console.ReadLine());
 // ...
```


