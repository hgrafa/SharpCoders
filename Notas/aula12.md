# Relembrando

Classe: molde

Classe abstrata:

- base para outros moldes
- uma classe que não produz objetos

## Construtores em heranças

Quando temos construtores em heranças, é importante satisfazer o construtor da classe base na classe filha também.

Exemplo:

1. Para criar uma forma geometrica, pedimos uma cor
2. Círcula é uma forma geométrica

Logo:
Para criar um circulo precisamos de um construtor recebendo cor e passando para a classe base.

```cs
public Circulo(Cor cor)
  : base(cor) {
    // ...
  }
```

# Classes com heranças

## `override` + `virtual`

Override = sobreescrever ou sobrepor

```cs
public class FormaGeometrica {

    public double Espessura { get; set; }
    public Cor Cor { get; set; } // enum

    // criando um calcula de Area
    // abrindo ele para ser sobreescrito
    public virtual void Perimetro() {
        return -1;
    }

    // criando um calcula de Area
    // abrindo ele para ser sobreescrito
    public virtual double Area() {
        return -1;
    }

}
```

```cs
public class Circulo : FormaGeometrica {

    public static readonly double PI = 3.14159265;
    public double Raio { get; set; }

    // sobrepondo regras da classe FormaGeometrica
    public override double Perimetro() {
      return 2*PI*Raio;
    }

    // sobrepondo regras da classe FormaGeometrica
    public override double Area() {
      return PI*Raio*Raio;
    }

}
```

# Classes abstratas

```cs
public abstract class FormaGeometrica {

    public double Espessura { get; set; }
    public Cor Cor { get; set; } // enum

    // assinatura de método abstrato
    // "tem perimetro, a regra alguém resolve dps"
    public abstract double Perimetro();

    // assinatura de método abstrato
    // "tem área, a regra alguém resolve dps"
    public abstract double Area();

}
```

```cs
public class Circulo : FormaGeometrica {

    public double Raio { get; set; }

    // implementando contrato da classe mãe
    public override double Perimetro() {
      return 2*PI*Raio;
    }

    // implementando contrato da classe mãe
    public override double Area() {
      return PI*Raio*Raio;
    }

}
```

## virtual vs. abstract

## sealed

Podemos selar um método para que as classes filhas não o sobreescrevam mais.