# Antes de POO

## Modelando um aluno

```cs
string ra;
string nome;
int idade;
double? nota;
bool? aprovado;
```

## Tipos anuláveis

```cs
Nullable<double> 
```

## Modelando vários alunos(turma)

```cs
string[] RAs;
string[] nomes;
int[] idades;
double?[] notas;
bool?[] aprovados;
```

## Relembrando: como trocar variáveis

```cs
int a = 2, b = 3;
int aux = a;
a = b;
b = aux;
```

## Melhorando o procedural

```cs
struct Aluno {
  string nome;
  int idade;
  double? nota;
  bool? aprovado;
}
```

## Introduzindo POO

**Classe:** É o molde que vai dar forma ao objeto(fruto deste molde)

**Objeto:** Fruto dessa classe contendo tudo previsto neste modelo.

## 1. Atributos 

O que um objeto terá.

```cs
class Aluno {

  // atributos
  string nome;
  int idade;
  double? nota;
  bool? aprovado;

}
```

## 2. Métodos

O que o objeto será capaz de fazer.

```cs
class Aluno {

  // atributos
  string nome;
  int idade;
  double? nota;
  bool? aprovado;

  // métodos
  void fazerAniversario(){
    idade++;
  }

  void fazerProva(double notaDaProva){
    nota = notaDaProva;
  }

  double somar(double a, double b) {
    return a + b;
  }

}
```

## Privacidade dos atributos e métodos

Inicialmente iremos disponibilizar para uso todas as partes do nosso molde (classe).

```cs
public class Aluno {

  // atributos
  public string nome;
  public int idade;
  public double? nota;
  public bool? aprovado;

  // métodos
  public void fazerAniversario(){
    idade++;
  }

  public void fazerProva(double notaDaProva){
    nota = notaDaProva;
  }

  public double somar(double a, double b) {
    return a + b;
  }

} 
```

Além disso, para dividirmos mais a responsabilidade dos nossos projetos podemos usar arquivos diferentes pelo nosso programa, no qual cada um irá guardar sua própria classe.

Então nossa estrutura do projeto neste caso:

```
📂 Entities
 | - Aluno.cs
Program.cs
```

Desta forma por exemplo criamos uma pasta para modelar entidades do nosso projeto, por exemplo, e salvamos nossa entidade Aluno dentro dela.

Podemos ter subpastas com nomes menos usuais para organizar as entidades por exemplo:

```
📂 Entities
 | 📂 Animals
 |  | - Dog.cs
 |  | - Cat.cs
 |  | - Fish.cs
 | - Aluno.cs
Program.cs
```

Adicionando entidades para representar animais e facilitando a visualização.

## Convenções

Classes: Iniciam com letra maiúscula.
Atributos públicos: tem seu nome iniciado por letra maiúscula.
Métodos: Iniciam com letra maiúsculos.

**obs:** Parâmetros seguem o padrão convencional de variáveis de terem letra minúscula no inicio do CamelCase.

### Nomes comuns para pastas de um projeto:

1. Model(s)/Entity(ies)/Domain
2. Util
3. Repository(ies)
4. Db
5. Exception(s)
6. Service(s)
7. Controller(s) / Resource(s)
8. View(s)

Aos poucos iremos entender mais o significado desta organização de projeto.