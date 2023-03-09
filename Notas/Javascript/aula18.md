# ...

## API e Rest

- request: cliente e response
- header, body
- troca de dados
- integração
- garçom
- intermediador

### Response e Request

DTO: Data transfer object

- EntidadeFormal: User
- EntidadesEntrada: SignUpUserDto, SignInUserDto, SearchUserDto
- EntidadesSaida: ProfileDto, ShortProfileDto

### exemplos

gateway: porta

quando vamos pagar algo em algum site, somos redirecionados para um gerenciador do pagamento

**fetch:**

https://api.github.com/users/hgrafa

## try...catch

```js
function hello(name) {
  throw "nome nao aceito!";
}

try {
  hello();
} catch (e) {
  console.log(e);
}
```

```js
function hello(name) {
  throw {
    error: "empty name",
    message: "you cannot pass empty name",
  };
}

try {
  hello();
} catch (e) {
  console.log(e.message);
}

console.log("fim do programa");
```

## POO

classe: molde
objeto: reflexo da classe

```js
class Pessoa {
  construtor(nome, idade, altura) {
    this.nome = nome;
    this._idade = idade;
    this.altura = altura;
  }
}
```

propriedades, construtor, métodos
construtor: função que instancia

```js
class Pessoa {
  constructor(nome, idade, altura) {
    this.nome = nome;
    this._idade = idade;
    this.altura = altura;
  }

  get idade() {
    return this._idade;
  }

  set idade(idade) {
    this._idade = idade;
  }

  pular = () => console.log("pulo");
}

const joao = new Pessoa("Joao", 21, 1.8);

console.log(joao);

joao.idade = 20;

console.log(`idade = ${joao.idade}`);
```

herança e polimorfismo

```js
class Aluno extends Pessoa {
  constructor(nome, idade, altura, nota) {
    super(nome, idade, altura);
    this.nota = nota;
  }
}

class Administrador extends Pessoa {
  constructor(nome, idade, altura, funcao) {
    super(nome, idade, altura);
    funcao = funcao;
  }
}
```

```js
const aluno = new Aluno("Aluno", 25, 1.9, 10);
const funcionario = new Administrador("Adm", 25, 1.6, () => {
  console.log("estou trabalhando");
});

console.log(aluno instanceof Pessoa); // true
console.log(aluno instanceof Administrador); // false
```

métodos estáticos

Design patterns

- Factory Design Pattern: Singleton

```js
class PessoaFactory {
  static byNameAndSurname(name, surname) {
    return new Pessoa {
      name: name,
      surname: surname
    }
  }
}


const joao = PessoaFactory.byNameAndSurname();
```

```js
function extrairFuncionario(formElement) {
  return {
    nome: formElement.querySelector(".nome").value;
  }
}
```

## Callbacks

Call: Chamar/Chamada

Back: Atras, Antes

then: Então

```js
const input = document.querySelector("input");
const timeOut = 5000;

input.onkeypress = () => {
  console.log("pressionei uma tecla");
};

// assincrono
setTimout(() => {
  console.log("terminou aqui no assincrono");
  input.value = "";
}, timeOut);
```

```
setTimout(): configura um tempo de espera
clearTimout()
setInterval(): configura um tempo de repetição
clearInterval()
```
