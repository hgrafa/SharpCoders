# Matrizes (Arrays 2d)

```c#
int[] vetor = {1, 2, 3, 4};

int[,] vetorDeVetor = { {1, 2, 3},
                        {3, 4, 5},
                        {5, 6, 7} };

string[,] matrizDePalavras = new string[4,5];

Console.WriteLine(vetorDeVetor[1,1]);
```

## Testando casos pequenos

```
[0,0] [0,1] [0,2]
[1,0] [1,1] [1,2]
[2,0] [2,1] [2,2]
```

## Ideia

esta (a -> b): estb
é (b -> c): é
uma (c -> d): uma
frase (d -> e): frase

> recebe a linha
> faz o split da frase
> palavras = {"esta", "é", "uma", "frase"}
> letrasDasPalavras = { {'e' , 's', 't', a'},
>                       {'é'},
>                       ... }

## Lendo valores para uma matriz

entrada:
```
4 3
4 3 2
2 3 5
5 6 7
3 5 7
```

código:
```c#
string[] input = Console.ReadLine().Split();
int nLinhas = int.Parse(input[0]), nColunas = int.Parse(input[1]);
int[,] matriz = new int[nLinhas, nColunas]

for(int i = 0; i < nLinhas; i++){
  // lendo linha por linha
  input = Console.ReadLine().Split();

  for(int j = 0; j < nColunas; j++){
    // quebando a linha pelas colunas da matriz
    matriz[i,j] = int.Parse(input[j]);
  }  
}
```

## Problema indicado

**[2407 - Quadrado Mágico](https://www.beecrowd.com.br/judge/pt/problems/view/2407)**

# Listas

```c#
  int tamanho = 0;
  int[] vetor = new int[10];
```

```c#
  List<int> sequencia = new List<>();
  sequencia.Add(2);
  sequencia.Add(3);
  sequencia.Add(4);

  for(int i = 0; i < sequencia.Count; i++){
    Console.WriteLine(sequencia[i]);
  }
```

# Vantagens em relação ao Array

1. Não tem tamanho fixo
2. Maior quantidade de métodos
3. Métodos aceitando programação funcional

# Desvantagens

1. Acesso um pouco mais lento às posições

## Principais métodos

1. `Add`, `Insert`, `Count`, `RemoveRange`
2. Por predicados: `Find`, `FindIndex`, `FindLast`, `FindLastIndex`, `Where`
3. `Remove`, `RemoveAll`, `RemoveAt`, `RemoveRange`
4. `Select`


## Dicas

* Por vezes as listas retornam um tipo menos específico de dado quando realizamos alguma destas operações, para facilitar a inferência de tipos pelo programa pode-se usar a palavra `var`.

```c#
  var result = sequencia.Select(x => x*2);
```

* Alguns métodos nas listas podem ser associados em uma única operação, por exemplo:

```c#
  sequencia.Where(x => x%2==0).Where(y => y > 10).Select(n => 2*n);
```

Neste conjunto de operações associdas nós filtramos a lista primeiro nos números pares, depois nos números maiores que 10, e posteriormente transformamos cada um destes números no dobro de seu valor correspondente.

* Predicados são expressões que retornam expressões booleanas. Elas normalmente podem ser lidas através do *tal que*.

```c#
  sequencia.Where(x => x>3);
```

Leitura:
> dada uma sequencia, filtre ela **para todo elemento x, tal que x maior que 3**