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
