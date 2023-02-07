# Relembrando

## Método abstrato

é um método delegado para ser implementado por uma classe filha.

## virtual

expor um método para sofrer sobreescrições(`override`).

## virtual vs. abstract

virtual: ela abre a possibilidade do método ser sobreescrito por qualquer classe filha.

abstract: tenho que resolver o método, isto é, implementar ou delegar novamente através de mais uma classe abstrata.

## sealed(selado)

ela sela o método para que não sofra mais nenhum `override`.

# Serialização e Desserialização

`System.Text.Json`

```cs
class Cachorro {
  public string Nome {get; set;}
  public string Idade {get; set;}
  public string Raca {get; set;}
}
```

**json:** Javascript Object Notation

```json
{
  "nome": "thor",
  "idade": 5,
  "raca": "pastor suiço"
}
```

## Serializando

```cs
var meuCachorro = new Cachorro {
  Nome = "Thor",
  Idade = 5,
  Raca = "Pastor Suiço"
};

string arquivojson = "dog.json";
string cachorrojson = JsonSerializer
```
