# Composição

## Sem composição

```cs
public class Arqueiro {

  // jeito ruim
  // parece procedural
  // não representa o arco
  // apenas a ideia do arco
  public double ForcaDoArco {get; set;}
  public double VelocidadeDoArco {get; set;}
  public double PrecisaoDoArco {get; set;}

}
```

## Com composição

```cs
public class Arco {

  // tem um
  public double Forca {get; set;}
  public double Velocidade {get; set;}
  public double Precisao {get; set;}

  // tem vários
  public List<Flecha> Flechas {get; set;}

}
```

```cs
public class Arqueiro {

  public Arco Arco {get; set;}

}
```

## Recaptulando POO

Classe = ['tem', 'faz', 'é']

```json
Arqueiro: {
  "tem" : ["Arco", "Força", "Velocidade", "Defesa"],
  "faz": ["TiroComArco()", "AdquirirNovoArco()"],
  "é": ["Personagem"]
}
```

# Herança

Pessoa -> Aluno

Conta -> ContaPremium, ContaPoupanca, ...

```cs
public class Pessoa {

  public string Nome {get; set;}
  public double Altura {get; set;}
  public int Idade {get; set;}

  public String DizerMeuTipo() {
    return "Eu sou uma Pessoa";
  }

}
```

```cs
public class Aluno : Pessoa {

  public double Nota {get; set;}

}
```

# Princípios

## DRY

**Don't Repeat Yourself**:

> Não fique se repetindo

## YAGNI

**You ain't gonna need it**:

> Você vai acabar nem precisando disso

## KISS

**Keep It Simple Stupid**:

> Mantenha isso o mais estúpido possível

## SOLID

**Single Responsability Principle**:

> Princípio da Responsabilidade Única

**Open Closed Principle**:

> Princípio de abertos e fechados

Iremos discutir o restante dos princípios com mais maturidade.

# Glossário

LTS: Long Term Support
CLI: Command Line Interface
.NET CLI:

- dotnet run
- dotnet run --project <nome-projeto>
