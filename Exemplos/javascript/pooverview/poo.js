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

  andar() {
    console.log("andando...");
  }

  pular = () => console.log("pulo");
}

class Aluno extends Pessoa {
  constructor(nome, idade, altura, nota) {
    super(nome, idade, altura);
    this.nota = nota;
  }
}

class PessoaFactory {
  static byNameAndSurname(name, surname) {
    let pessoa = new Pessoa();
    pessoa.name = name;
    pessoa.surname = surname;
    return pessoa;
  }
}

const joao = new Pessoa("Joao", 21, 1.8);
const lais = new Pessoa("Lais", "Silva");
const maria = new Aluno("Maria", 24, 1.7, 8.9);

console.log(joao);
console.log(lais);
console.log(maria);

joao.idade = 20;

console.log(`idade = ${joao.idade}`);
