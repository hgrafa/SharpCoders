function RegisterAndPrint(dataProcess) {
  console.log("estou registrando...");
  console.log(dataProcess());
}

RegisterAndPrint(function () {
  return "sou um processo";
});
