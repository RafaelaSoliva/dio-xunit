### ✅ **Testes Unitários com xUnit:**

Este projeto demonstra a criação e execução de testes unitários em C# utilizando o framework xUnit. Ele inclui exemplos de validações para listas e strings, com cobertura de cenários comuns de manipulação de dados.

##

### :hammer: **Funcionalidades Testadas:**

- **Validações de listas:** Remoção de números negativos, busca de elementos, multiplicação de itens, obtenção de maior/menor valor, verificação de lista vazia, contagem de itens, contagem de itens pares e ímpares, e cálculo de média.
- **Validações de strings:** Contagem de caracteres, busca de substrings, verificação de início/fim de texto, checagem de string vazia e validação se o texto é um número.

##

### 📚 **Principais Classes:**

- **ValidacoesLista:**  
  Métodos para manipulação e validação de listas de inteiros.

- **ValidacoesString:**  
  Métodos para manipulação e validação de strings.

- **ValidacoesListaTests / ValidacoesStringTests:**  
  Testes unitários cobrindo todos os métodos das classes de validação.

##

### ℹ️ **Observações:**

- Os testes utilizam o framework xUnit, com asserções para validar o comportamento esperado dos métodos.
- O projeto segue boas práticas de organização de código e separação de responsabilidades.
- Não há persistência de dados; todos os testes são executados em memória.

##

### **Como usar:**

<details><summary><strong> 1. Requisitos </strong></summary>

- [.NET 8.0 SDK ou superior](https://dotnet.microsoft.com/download)
- Windows, Linux ou MacOS

</details>

<details><summary><strong> 2. Clonando o repositório </strong></summary>

```sh
git clone https://github.com/seu-usuario/seu-repositorio.git
cd dio-xunit
```

</details>

<details><summary><strong> 3. Executando os testes </strong></summary>

No terminal, navegue até a pasta do projeto e execute:

```sh
dotnet test
```

</details>

##

### Estrutura do Projeto

```
dio-xunit/
│
├── TestesUnitarios.Console/
│   ├── Program.cs                  // Projeto principal (exemplo)
│   └── Services/
│       ├── ValidacoesLista.cs      // Lógica de validação de listas
│       └── ValidacoesString.cs     // Lógica de validação de strings
│
├── TestesUnitarios.Tests/
│   ├── ValidacoesListaTests.cs     // Testes unitários para listas
│   └── ValidacoesStringTests.cs    // Testes unitários para strings
│
└── README.md
```

##

##### [@RafaelaSoliva](https://github.com/RafaelaSoliva)
##### **Desenvolvida do zero.** Solução do [desafio da Dio](https://github.com/digitalinnovationone/trilha-net-testes-unitarios-desafio)
