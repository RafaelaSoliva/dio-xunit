namespace TestesUnitarios.Tests;
using TestesUnitarios.Services;

public class ValidacoesListaTests {

    private ValidacoesLista validacoesLista = new ValidacoesLista();


    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista () {
        // Arrange
        List<int> lista = new List<int> {-10, -5, 0, 5, 10};

        // Act
        var resultado = validacoesLista.RemoverNumerosNegativos(lista);
        var resultadoEsperado = new List<int> {5, 10};

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveConterONumero9NaLista () {
        // Arrange
        List<int> lista = new List<int> {8, 9, 10};
        int numeroBuscado = 9;

        // Act
        var resultado = validacoesLista.ListaContemDeterminadoNumero(lista, numeroBuscado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista () {
        // Arrange
        List<int> lista = new List<int> {0, 1, 2};
        int numeroBuscado = 10;

        // Act
        var resultado = validacoesLista.ListaContemDeterminadoNumero(lista, numeroBuscado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2 () {
        // Arrange
        List<int> lista = new List<int> {1, 2, 3, 4};
        int numeroMultiplicador = 2;

        // Act
        var resultado = validacoesLista.MultiplicarNumerosLista(lista, numeroMultiplicador);
        var resultadoEsperado = new List<int> {2, 4, 6, 8};

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista () {
        // Arrange
        List<int> lista = new List<int> {7, 8, 9};

        // Act
        var resultado = validacoesLista.RetornarMaiorNumeroLista(lista);
        var resultadoEsperado = 9;

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista () {
        // Arrange
        List<int> lista = new List<int> {-8, -7, -6};

        // Act
        var resultado = validacoesLista.RetornarMenorNumeroLista(lista);
        var resultadoEsperado = -8;

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornarTrueParaListaVazia () {
        // Arrange
        List<int> lista = new List<int>();

        // Act
        var resultado = validacoesLista.AListaEVazia(lista);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void DeveRetornarFalseParaListaVazia () {
        // Arrange
        List<int> lista = new List<int> {0, 1, 2};

        // Act
        var resultado = validacoesLista.AListaEVazia(lista);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveRetornar5ParaNumeroDeItensDaLista () {
        // Arrange
        List<int> lista = new List<int> {1, 2, 3, 4, 5};

        // Act
        var resultado = validacoesLista.ContarItens(lista);
        var resultadoEsperado = 5;

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornar2ParaQuantidadeDeItensPares () {
        // Arrange
        List<int> lista = new List<int> {1, 2, 3, 4};

        // Act
        var resultado = validacoesLista.ContarItensPares(lista);
        var resultadoEsperado = 2;

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornar2ParaQuantidadeDeItensImpares () {
        // Arrange
        List<int> lista = new List<int> {1, 2, 3, 4};

        // Act
        var resultado = validacoesLista.ContarItensImpares(lista);
        var resultadoEsperado = 2;

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornar7EMeioParaMediaDeValoresDaLista () {
        // Arrange
        List<int> lista = new List<int> {7, 8};

        // Act
        var resultado = validacoesLista.RetornarMediaValores(lista);
        var resultadoEsperado = 7.5;

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }
}