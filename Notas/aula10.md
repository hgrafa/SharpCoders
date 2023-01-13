# Static keyword

- Um atributo estático é um atributo que pertence a um lugar compartilhado da memória, por todos os objetos produzidos.

```cs
public class Circulo {

  public static readonly double PI = 3.14159265;
  public double Raio {get; set;}

}
```

- Métodos estáticos não dependem da criação de um objeto para serem utilizados.


`Menu.cs`:
```cs
public class Menu {

  public static void ApresentarMenuPrincipal() {
    // ...
  }

}
```

`Program.cs`

```cs
public class Program {

  public static void DizerOi() {
    Console.WriteLine("oi");
  } 

  public static void Main(String[] args) {

    // chamando método de classe externa
    Menu.ApresentarMenuPrincipal();

    // chamando método da própria classe
    Program.DizerOi();

  }

}
```

- Caso nós precisemos alterar um atributo estático, também não é necessário criar um objeto e este atributo compartilhará a mudança para todos os outros objetos frutos deste tipo.
