# Problemas da aula passada

`Program.Main()`:
```cs
  Pessoa maria = new Pessoa();
```

**Problema1:** Existe um momento em que o nosso objeto `maria` não possui seus atributos *obrigatórios* já inicializados.

```cs
public class Pessoa {

  public string Nome;
  public double Altura;
  public int Idade;
  public string Telefone;

  public void fazerAniversario() {
    Idade++;
  }

}
```

# Construtores

## Construtor padrão

Na classe abaixo personalizamos o construtor padrão, quando formos criar um objeto do tipo Pessoa, a mensagem irá aparecer no console.

É um método chamado na inicialização de um objeto.

```cs
public class Pessoa {

  // atributos
  public string Nome;
  public double Altura;
  public int Idade;
  public string Telefone;

  // construtor padrão
  public Pessoa(){
    Console.WriteLine("estou inicializando meu objeto");
  }

  // métodos
  public void fazerAniversario() {
    Idade++;
  }

}
```

## Construtores personalizados

```cs
public class Pessoa {

  // atributos
  public string Nome;
  public double Altura;
  public int Idade;
  public string Telefone;
  public Endereco Endereco;

  // construtor personalizado
  public Pessoa(string nomeEntrada, double alturaEntrada, int idadeEntrada){
    Nome = nomeEntrada;
    Altura = alturaEntrada;
    Idade = idadeEntrada;
  }

  // métodos
  public void FazerAniversario() {
    Idade++;
  }

}
```

**Errado** a partir de agora:
```cs
Pessoa maria = new Pessoa()
```

**Certo** a partir de agora:
```cs
Pessoa maria = new Pessoa("Maria da Silva", 1.75, 21);
```

## Recaptulando sobrecarga

```cs
public static void dizerOi(){
  Console.WriteLine("oi");
}

public static void dizerOi(string nome){
  Console.WriteLine($"oi, {nome}");
}
```

## Sobrecarga de construtores

```cs
  public Pessoa() {
  }

  public Pessoa(string nomeEntrada, double alturaEntrada, int idadeEntrada){
    Nome = nomeEntrada;
    Altura = alturaEntrada;
    Idade = idadeEntrada;
  }

  public Pessoa(string nomeEntrada, double alturaEntrada, int idadeEntrada, string telefoneEntrada){
    Nome = nomeEntrada;
    Altura = alturaEntrada;
    Idade = idadeEntrada;
    Telefone = telefoneEntrada;
  }
```

<!-- ```cs

public class Calculadora {

  public static double Erro {get; set;};
  private static double _buffer = 0;

  public static double Buffer {
    get {
      return _buffer;
    }
  }

  public static double Somar(double a, double b) {
    double soma = a + b;
    _buffer += soma + erro;
    return soma;
  }

}
```

```cs
Calculadora.Erro = -3;
Calculadora.Somar(2, 3);
Calculadora.Somar(2, 3);
Console.WriteLine(Calculadora.Buffer);
``` -->