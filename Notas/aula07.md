# Comandos importantes para git

## Iniciando processo de versionamento numa pasta

```bash
  git init
```

Para checar você pode digitar `ls - a`, este comando apresenta o que está dentro de sua pasta incluindo pastas ocultas pelo sistema. Verifique se existe a pasta `.git`.

## Adicionando arquivo ao stage

Uma zona que acumula arquivos para criarmos o checkpoint(commit)

**adicionando um a um**
```bash
  git add <meu-arquivo>
```

```bash
  git add <minha-pasta>
```

**adicionando todos os modificados e não rastreados**
```bash
  git add .
```

## Criando um commit

```bash
  git commit -m "mensagem do checkpoint"
```

## Checando status do seu repositório local

```bash
  git status
```

|classificação|motivo|
|:-:|:-:|
|`staged for commit`|será incluído no próximo checkpoint do projeto|
|`modified`|já está em processo de versionamento, porém a versão atual não está sendo registrada no próximo checkpoint|
|`untracked`|o arquivo ou pasta não está sendo versionado através do git|

## Checando seu histórico de commits

```bash
  git log
```

recomendação pessoal:

```bash
  git log --oneline
```

este comando que recomendo simplifica a forma que serão apresentados os commits feitos.

## Subindo seu projeto para o github

obs: caso você parta de uma clonagem de repositório a conexão que farei abaixo já terá sido criada automaticamente.

```bash
  git remote add origin <link-do-repositorio>
```

o nome `origin` é flexível, porém por enquanto podemos usá-lo.

atualmente o github usa como branch(linha do tempo) padrão uma chamada `main`, e nosso terminal costuma abrir na `master`.

Para renomeá-la basta usar:

```bash
  git branch -M main
```

## Fazendo o push

Desta forma estamos *empurrando*(**push**) nosso código para o repositório.

Através do `-u` estamos configurando como padrão o link da `origin` para a `main`

```bash
  git push -u origin main
```

Numa próxima execução podemos usar apenas `git push` se quisermos manter este padrão.

## Recebendo atualizações

Por vezes nosso repositório tem atualizações e precisamos puxá-las para nossa máquina antes de realizar um `push`. Nestes casos faremos um `pull` local antes.

```bash
  git pull origin main
```

**CONFLITOS!** Existe uma chance de ao trazer as alterações do projeto existirem conflitos entre o alterado e o que você deseja subir. Você pode iniciar um processo de resolução de conflitos ou forçar suas atualizações a sobreporem o repositório. 

No momento ensinarei apenas a forçar e depois aprenderemos a resolver conflitos.

```bash
  git push -u origin main --force
```

# Modificador de acesso params

## Sem modificador params

função:
```c#
  static double Sum(double[] vetor){
    return a + b;
  }

```

chamada:
```c#
  Sum(new int[]{2, 3, 4, 5});
```


## Com modificador params

Vantagem: passar uma quantidade indeterminada de parametros sem precisar usar a sintaxe de vetores na chamada da função

função
```c#
  static double Sum(params double[] vetor) {
      double sum = 0;
      foreach(double value in vetor) {
          sum += value;
      }

      return sum;
  }
```

chamada:
```c#
  Sum(2, 3, 4, 5);
```