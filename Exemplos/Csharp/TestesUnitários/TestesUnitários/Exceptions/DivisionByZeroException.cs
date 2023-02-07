namespace ProjetoCalculadora.Exceptions;

public class DivisionByZeroException : Exception {
    
    public DivisionByZeroException() {
    }

    public DivisionByZeroException(string? message) : base(message) {
    }

}
