# Exceptions

- criar/instanciar
- delegar
- tratar

## tratamento (`try-catch`)

```cs
try {
  // tenta algum código
} catch(Exception1 e1) {

} catch(Exception2 e2) {

}
```

## bloco `Finally`

```cs
double a = 3.4;
double b = 0.0;

try {
  if(b == 0)
    throw new ArithmeticException("You cannot divide by zero!");

  Console.WriteLine($"Result = {a/b}");
} catch(ArithmeticException arithmeticException) {
  Console.WriteLine($"Error: {arithmeticException.Message}");
}
```
