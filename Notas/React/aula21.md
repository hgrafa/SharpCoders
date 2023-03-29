#

# React

## Compilers

- Babel: tirava o gap entre a evolução do ECS e do JS.

## Bundlers

- Webpack

## Nullish Coalescence Operator

```js
const employee = {
  name: "Pedro",
  salary: 0,
  job: null,
};

const salary = employee.salary || "Não se aplica";
const job = employee.job || "Não se aplica";

const salary = employee.salary ?? "Não se aplica";
const job = employee.job ?? "Não se aplica";

console.log(salary);
console.log(job);
```

## Optional Chaining - Ligamentos opicionais

```js
const employee1 = {
  name: "Pedro",
  salary: 0,
  job: {
    name: "dev",
    time: "2 months",
    company: {
      name: "chat SBT",
      createdAt: "2023-03-20",
    },

    drinkCoffee(hour) {
      return hour > 9 && hour < 17 ? "Coffe Time!" : "It's out of time";
    },
  },
};

const employee2 = {
  name: "Pedro",
  salary: 0,
  job: null,
};

// melhorada
const companyOfEmployee1 = employee1.job?.company?.name;
const companyOfEmployee2 = employee2.job?.company?.name ?? "Not on a company";
const bebeuCoffee = employee1.job?.drinkCoffee?.();

log(companyOfEmployee1);
log(companyOfEmployee2);
```

## Métodos de Array

```js
lista = [1, 1, 2, 3, 5, 8, 13, 25, 34];

// troca os elementos
const resultado1 = lista.map((e) => 2 * e);

const resultado2 = [];

// itera sob os elementos
lista.forEach((e) => {
  resultado.push(2 * e);
});
```

```js
lista = [1, 1, 2, 3, 5, 8, 13, 25, 34];

const resultado1 = lista.filter((e) => e % 2 == 0);
// [2, 8, 34]

const todosOsElementoSaoPares = lista.every((e) => e % 2 == 0);
//true

const temMultiploDe6 = lista.some((e) => e % 2 == 0);
//false
```

```js
const soma = lista.reduce((accumulator, value) => {
  accumulator += value;
  return accumulator;
}, 0);

const produto = lista.reduce((accumulator, value) => {
  accumulator *= value;
  return accumulator;
}, 1);
```

## Ideias sobre ordenações

```js
const original = lines.map((x) => parseInt(x));
const sortAscending = [...original];

sortAscending.sort(function (p1, p2) {
  const result = p1.idade - p2.idade;
  return (result != 0) result : (p1.nome - p2.nome);
});

for (let num = 0; num < sortAscending.length; num++)
  console.log(sortAscending[num]);

console.log();

for (let num = 0; num < original.length; num++) console.log(original[num]);
```
