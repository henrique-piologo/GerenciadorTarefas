## 📝 Documentação Técnica – Gerenciador de Tarefas

### 📌 Identificação do Projeto

* **Nome**: Gerenciador de Tarefas
* **Linguagem**: C#
* **Plataforma**: .NET Framework 4.0 ou superior

---

### 🎯 Objetivo

O projeto tem como objetivo fornecer uma aplicação de console simples para gerenciamento de tarefas, onde é possível adicionar, listar, remover e marcar tarefas como concluídas. Ele utiliza os princípios da programação orientada a objetos para separar responsabilidades e garantir organização e manutenibilidade do código.

---

### 🧱 Estrutura do Projeto

#### **Classes:**

* **Program.cs**

  * Classe principal que inicia o programa.
  * Responsável apenas por instanciar o gerenciador e chamar o menu.

* **GerenciadorDeTarefas**

  * Responsável por toda a lógica de controle do sistema.
  * Contém as funcionalidades:

    * `ExibirMenu()`
    * `AdicionarTarefa()`
    * `ListarTarefas()`
    * `RemoverTarefa()`
    * `MarcarConcluida()`

* **Tarefa** (presume-se que esteja em `Models/Tarefa.cs`)

  * Representa uma tarefa com:

    * Nome
    * Descrição
    * Status de conclusão (booleano)
  * Métodos:

    * Construtor
    * `ToString()` sobrescrito para exibição no menu.

---

### ✅ Funcionalidades

1. **Adicionar Tarefa**

   * Recebe o nome e a descrição da tarefa via console e adiciona à lista.
2. **Remover Tarefa**

   * Exibe a lista de tarefas e permite remover uma pelo índice.
3. **Listar Tarefas**

   * Exibe todas as tarefas existentes com seu status.
4. **Marcar como Concluída**

   * Alterna o status entre "concluída" e "pendente".

---

### 📦 Boas Práticas Utilizadas

* **Orientação a Objetos (POO)**

  * Classes bem separadas: `Program`, `GerenciadorDeTarefas`, `Tarefa`.
  * Encapsulamento aplicado (lista de tarefas é privada).

* **Separação de Camadas**

  * Interface (entrada via Console) separada da lógica de negócio (`GerenciadorDeTarefas`).

* **Facilidade de Leitura**

  * Código com nomes descritivos.
  * Uso de `Console.Clear()` e mensagens amigáveis.

---

### 🛠️ Tecnologias Utilizadas

* .NET Framework 4.0+
* C#
* Console Application

---
