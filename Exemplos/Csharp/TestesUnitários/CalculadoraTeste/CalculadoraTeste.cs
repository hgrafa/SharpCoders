using ProjetoCalculadora;
using ProjetoCalculadora.Exceptions;
using static ProjetoCalculadora.Calculadora;

namespace CalculadoraTeste;

public class CalculadoraTeste {

    // annotations
    [Theory()]
    [InlineData(3, 4, 7)]
    [InlineData(12, 12, 34)]
    [InlineData(0, 0, 0)]
    [InlineData(10, 4, 7)]
    public void GivenSomaWhenSomandoDoisNumerosThenReturnTheSum(
        double firstValue, double secondValue, double expectedValue) {

        // when - act - agir
        double resultValue = Somar(firstValue, secondValue);

        // then - assert - teste
        Assert.Equal(expectedValue, resultValue);
    }

    [Fact] // annotations
    public void GivenDiferencaWhenSubtraindoDoisNumerosThenReturnTheSubtracao() {
        // given/arrange
        double firstValue = 10.0;
        double secondValue = 3.0;
        double expectedValue = 7.0;

        // when - act - agir
        double resultValue = Subtrair(firstValue, secondValue);

        // then - assert - teste
        Assert.Equal(expectedValue, resultValue);
    }


    [Fact] // annotations
    public void GivenProdutoWhenMultiplicandoDoisNumerosThenReturnTheProduct() {
        // given/arrange
        double firstValue = 10.0;
        double secondValue = 10.0;
        double expectedValue = 100.0;

        // when - act - agir
        double resultValue = Multiplicar(firstValue, secondValue);

        // then - assert - teste
        Assert.Equal(expectedValue, resultValue);
    }

    [Fact(DisplayName = "Divisao por zero")] // annotations
    public void GivenDivisaoWhenDividindoDoisNumerosThenReturnTheDivision() {
        // given/arrange
        double firstValue = 20.0;
        double secondValue = 4.0;
        double expectedValue = 5.0;

        // when - act - agir
        double resultValue = Dividir(firstValue, secondValue);

        // then - assert - teste
        Assert.Equal(expectedValue, resultValue);
    }

    [Fact] // annotations
    public void GivenDivisaoWhenDividindoPorZeroThenThrowsDivisionByZeroException() {
        // given/arrange
        double firstValue = 20.0;
        double secondValue = 0.0;
        double expectedValue = 4.0;

        // when - act - agir
        double resultValue = Dividir(firstValue, secondValue);

        Assert.Throws<DivisionByZeroException>(() => Dividir(firstValue, secondValue));
    }



    // GWT = Given When Then
    // dado alguma coisa, quanto tal coisa, então ...
    // AAA = Arrange Act Assert
    // Dado... Faça... Garanta...
    // Should

    // SEVT
    // Setup Execute Verify Teardown
    // Configura... Executa... Verifica... Limpa!

    // Piramide de teste
    // teste unitários
    // teste automatizados

    // Inteface/Frontend > Services > Unidades/Funções
    // mais alto => maior custo
    // mais baixo => mais veloz
    // mais baixo maior a quantidade

    // TDD => Test Development Drive
    // RGR => Red: Falha => Green: Sucesso => Refactor

}
