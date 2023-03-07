const buttons = document.querySelectorAll("#buttons-container button");
const lastOperationText = document.querySelector("#last-operation");
const currentOperationText = document.querySelector("#current-operation");

class Calculator {
  constructor(lastOperationText, currentOperationText) {
    this.lastOperationText = lastOperationText;
    this.currentOperationText = currentOperationText;
    this.currentOperation = "";
  }
}

const calculator = new Calculator(lastOperationText, currentOperationText);

buttons.forEach((btn) => {
  btn.addEventListener("click", (event) => {
    const value = event.target.innerText;

    if (value >= 0 || value === ".") {
      console.log(value);
      calculator.addDigit(value);
    } else {
      calculator.processSymbol(value);
    }
  });
});

// addEventListener("operation", "function")
