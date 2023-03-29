const output = document.querySelector("#app");

function log(msg) {
  output.innerHTML += `
    ${msg} 
    <br>
  `;
}

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

// const salary = employee.salary ?? "Não se aplica";
// const job = employee.job ?? "Não se aplica";

// const companyOfEmployee = employee.job
//   ? employee.job.company
//     ? employee.job.company.name
//     : "Not on a Company"
//   : "Not on a Company";

const companyOfEmployee1 = employee1.job?.company?.name;
const companyOfEmployee2 = employee2.job?.company?.name ?? "Not on a company";
const bebeuCoffee = employee1.job?.drinkCoffee?.(16);

const { name, job: responsabilty, nickname = "Newbie" } = employee1;

const lista = [1, 1, 2, 3, 5, 8, 13, 25, 34];

const soma = lista.reduce((accumulator, value) => {
  accumulator += value;
  return accumulator;
}, 0);

const produto = lista.reduce((accumulator, value) => {
  accumulator *= value;
  return accumulator;
}, 1);

log(name);
log(JSON.stringify({ name, responsabilty, nickname }));
log("");
log("");
log(companyOfEmployee1);
log(companyOfEmployee2);
log(bebeuCoffee);
log(soma);
log(produto);
