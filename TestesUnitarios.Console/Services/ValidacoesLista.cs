namespace TestesUnitarios.Services;

public class ValidacoesLista {

    public List<int> RemoverNumerosNegativos (List<int> lista) {
        List<int> listaFiltrada = lista.Where(x => x > 0).ToList();
        return listaFiltrada;
    }

    public bool ListaContemDeterminadoNumero (List<int> lista, int numeroBuscado) {
        return lista.Contains(numeroBuscado);
    }

    public List<int> MultiplicarNumerosLista (List<int> lista, int numeroMultiplicador) {
        List<int> listaMultiplicada = lista.Select(x => x * numeroMultiplicador).ToList();
        return listaMultiplicada;
    }

    public int RetornarMaiorNumeroLista (List<int> lista) {
        return lista.Max();
    }

    public int RetornarMenorNumeroLista (List<int> lista) {
        return lista.Min();
    }

    public bool AListaEVazia (List<int> lista) {
        return lista.Count == 0;
    }

    public int ContarItens (List<int> lista) {
        return lista.Count;
    }

    public int ContarItensPares (List<int> lista) {
        int quantidadeNumerosPares = lista.Count(x => x % 2 == 0);
        return quantidadeNumerosPares;
    }

    public int ContarItensImpares (List<int> lista) {
        int quantidadeNumerosImpares = lista.Count(x => x % 2 == 1);
        return quantidadeNumerosImpares;
    }

    public double RetornarMediaValores (List<int> lista) {
        return lista.Average();
    }
}