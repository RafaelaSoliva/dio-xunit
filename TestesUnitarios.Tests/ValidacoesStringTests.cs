namespace TestesUnitarios.Tests;
using TestesUnitarios.Services;

public class ValidacoesStringTests {

    private ValidacoesString validacoesString = new ValidacoesString();


    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix () {
        // Arrange
        string palavra = "Matrix";

        // Act
        int resultado = validacoesString.RetornarQuantidadeCaracteres(palavra);
        int resultadoEsperado = 6;

        // Assert
        Assert.Equal(resultado, resultadoEsperado);
    }

    [Fact]
    public void DeveConterAPalavraQualquerNoTexto () {
        // Arrange
        string palavra = "Esse é um texto qualquer";
        string busca = "qualquer";

        // Act
        bool resultado = validacoesString.ContemCaractere(palavra, busca);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto () {
        // Arrange
        string palavra = "Esse é um texto qualquer";
        string busca = "teste";

        // Act
        bool resultado = validacoesString.ContemCaractere(palavra, busca);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado () {
        // Arrange
        string palavra = "Começo, meio e fim do texto procurado";
        string busca = "procurado";

        // Act
        bool resultado = validacoesString.TextoTerminaCom(palavra, busca);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void TextoNaoDeveTerminarComAPalavraProcurado () {
        // Arrange
        string palavra = "Hello, world";
        string busca = "procurado";

        // Act
        bool resultado = validacoesString.TextoTerminaCom(palavra, busca);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveRetornarQueAStringEstaVazia () {
        // Arrange
        string palavra = "";

        // Act
        bool resultado = validacoesString.AStringEstaVazia(palavra);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void DeveRetornarQueAStringNaoEstaVazia () {
        // Arrange
        string palavra = "Hello, world";

        // Act
        bool resultado = validacoesString.AStringEstaVazia(palavra);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveComecarComAPalavraTeste () {
        // Arrange
        string palavra = "Teste, olá";
        string busca = "Teste";

        // Act
        bool resultado = validacoesString.TextoComecaCom(palavra, busca);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void TextoNaoDeveComecarComAPalavraTeste () {
        // Arrange
        string palavra = "Olá, teste";
        string busca = "Teste";

        // Act
        bool resultado = validacoesString.TextoComecaCom(palavra, busca);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoEUmNumero () {
        // Arrange
        string palavra = "123";

        // Act
        bool resultado = validacoesString.AStringEUmNumero(palavra);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void TextoNaoEUmNumero () {
        // Arrange
        string palavra = "Hello, world";

        // Act
        bool resultado = validacoesString.AStringEUmNumero(palavra);

        // Assert
        Assert.False(resultado);
    }
}