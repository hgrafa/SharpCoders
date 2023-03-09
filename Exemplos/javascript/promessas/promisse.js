const accept = false;

const myPromise = new Promise((resolve, reject) => {
  const acceptMsg = "motorista a caminho";
  const resfusedMsg = "buscando outro motorista";

  return accept ? resolve(acceptMsg) : reject(resfusedMsg);
});

console.log("buscando um motorista");

myPromise
  .then((result) => console.log(result))
  .catch((error) => console.log(error))
  .finally(() => console.log("obrigado por utilizar!"));
