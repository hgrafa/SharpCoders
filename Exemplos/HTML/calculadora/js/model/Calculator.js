export class Calculator {
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