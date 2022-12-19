# Estruturas de Repetição

```
1. inicialização
2. verificação
3. atualização
```

## Estrutura `while`

```cs
// inicialização

while(/*verificação*/){
  // código
  // atualização
}
```

```cs
int estoque = 10;

while(estoque != 0) {
  Console.WriteLine("estou vendendo!");
}
```

## Estrutura `for`

```cs
for(/*inicialização*/; /*verificação*/; /*atualização*/){

}
```

```cs
for(int count = 1; count <= 10; count++) {
  Console.WriteLine(count);
}
```