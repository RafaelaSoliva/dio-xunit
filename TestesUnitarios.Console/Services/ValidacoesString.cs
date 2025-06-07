namespace TestesUnitarios.Services;

public class ValidacoesString {

    public int RetornarQuantidadeCaracteres (string palavra) {
        return palavra.Length;
    }

    public bool ContemCaractere (string palavra, string busca) {
        return palavra.Contains(busca);
    }

    public bool TextoTerminaCom (string palavra, string busca) {
        return palavra.EndsWith(busca);
    }

    public bool AStringEstaVazia (string palavra) {
        return palavra.Length == 0;
    }

    public bool TextoComecaCom (string palavra, string busca) {
        return palavra.StartsWith(busca);
    }

    public bool AStringEUmNumero (string palavra) {
        return int.TryParse(palavra, out int numeros);
    }
}