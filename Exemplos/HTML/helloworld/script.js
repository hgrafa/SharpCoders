// linter: eslint, commitlint
// Document Object Model
let x = 3;
const output = document.getElementById('teste')
x = "mudou pra string";
x = [1, 2, 3, "outra string"];

// truthy and falsy values
// truthy: != 0, "aaa"
// falsy: null, undefined, [], "", NaN(Not a number)

// == : testa valores 
// '1'== 1 : true
// '1' !== 1 : false

const sum = 2 + 3;
let a = 4;
a++;

// json: javascript object notation
x = {
  nome: "joao",
  idade: 20,
  altura: 1.8,

  dizerOi(nome) {
    // método
    console.log(`olá, ${nome}`);
  },
};

// operador ternário
let autorizado = x.idade >= 18 ? "ok" : "not";

// for and while
for (let i = 0; i < 10; i++) {
  console.log(i);
}

// function
const soma1 = (a, b) => a + b;
const soma2 = function (a, b) {
  return a + b;
}

function soma3(a, b) {
  return a + b;
};

document.getElementById("title").innerText = "meu hello world!";
output.innerText += `x = ${x}\n`
output.innerText += `x objeto = ${JSON.stringify(x)}`
console.log("Hello World");

// event listener
// call stack = pilha de chamada
// single thread
// streaming Nodejs
// javascript everywhere

// google remote procedure call
