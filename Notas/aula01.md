# Introdução ao C#

Teremos um código base por enquanto para forcarmos em entender os primeiros tópicos da linguagem. Porém, posteriormente iremos entender toda sua estrutura.

## Código base

```C#
namespace Projeto {
    public class Program {
        public static void Main(string[] args) {

        }
    }
}
```

## Comentários

```c#
namespace PrimeiroProjeto {

    public class MeuPrimeiroPrograma {

        // método Main - Método Principal
        
        public static void Main(string[] args) {

          // seu código aqui

          // testando uma impressão na tela
          Console.WriteLine("Hello!");
        }
    }
}
```

## Impressão na tela

```c#
  Console.WriteLine("Hello World!");
```

## Usando valores na impressão

```c#
  int idade = 21;
  Console.WriteLine("A idade é" + idade);
```