
const buttons = document.querySelectorAll("#buttons-container button")
const lastOperationText = document.querySelector("#last-operation");
const currentOperationText = document.querySelector("#current-operation");

class Calculator {
  constructor(lastOperationText, currentOperationText) {
    this.lastOperationText = lastOperationText;
    this.currentOperationText = currentOperationText;
    this.currentOperation = "";
  }
  
  addDigit(value) {
    // preciso validar se é um ponto ou é depois do primeiro ponto
    this.currentOperation = value;
    this.updateScreen();
  }
  
  updateScreen(
    operationValue = null,
    operation = null,
    current = null,
    last = null
  ) {
    
    if(operationValue === null) {
      this.currentOperationText += this.currentOperation;
    } else {
      if(last == 0) {
        operationValue = current;
      }
       
      this.lastOperationText.innerText = `${operationValue} ${operation}`;
      this.currentOperationText.innerText = "";
    }
    
  }
  
  processSymbol(operationSymbolText) {
    
  }
}

const calculator = new Calculator(lastOperationText, currentOperationText);

buttons.forEach( (btn) => {
  btn.addEventListener("click", (event) => {
    const value = event.target.innerText;
    
    if(value >= 0 || value === ".") {
      console.log(value);
      calculator.addDigit(value);
    } else {
      calculator.processSymbol(value);
    }
  })
})

// addEventListener("operation", "function")