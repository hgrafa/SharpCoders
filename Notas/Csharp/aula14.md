# Exceptions

## Exceptions nativas

```cs
int a = Console.ReadLine(); // 5
int b = Console.ReadLine(); // 0

int division = a / b;
```

dá uma `Exeption`

```cs
int a = Console.ReadLine(); // 5
int b = Console.ReadLine(); // 0

try {
  int division = a / b;
} catch(Exception exception) {
  Console.WriteLine(exception.Message);
}
```
