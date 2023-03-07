# Revisão js

## Tipagem fraca

As variáveis não ficam presas a um tipo durante toda a execução.

```js
let a = 2;
a = [1, 2, 3, 4];
```

## Hoisting

```js
x = 3;

console.log(x);

let x;
```

## Array methods

```js
let building = ["car", "house", "door"];

building.push("pool");
// ['car', 'house', 'door', 'pool']

building.pop();
// ['car', 'house', 'door']
```
