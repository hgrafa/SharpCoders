const timeOutTick = 1000;
const timeOutClock = 10000;

let momento = {
  minuto: 59,
  segundo: 57,

  prosseguir() {
    this.segundo++;

    if (this.segundo === 60) {
      this.segundo = 0;
      this.minuto++;
    }

    if (this.minuto === 60) {
      throw {
        msg: "Limite de tempo excedido!",
      };
    }
  },
};

// template literals
const marcarDorRelogio = () => {
  console.log(`tick... (${momento.minuto}:${momento.segundo})`);
  momento.prosseguir();
};

const x = 2;

let interval = setInterval(marcarDorRelogio, timeOutTick);

setTimeout(() => clearInterval(interval), timeOutClock);
