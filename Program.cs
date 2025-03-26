using System;
using System.Collections.Generic;
using System.Globalization;
using GerenciadorTarefas.Models;


class Program
{
    static void Main()
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
        gerenciador.ExibirMenu();
    }
}

class GerenciadorDeTarefas
{

    private List<Tarefa> tarefas = new List<Tarefa>();

    public void ExibirMenu()
    {
        string mensagem = "GERENCIADOR DE TAREFAS\n"
                + "1 - Adicionar Tarefa\n"
                + "2 - Remover Tarefa\n"
                + "3 - Listar Tarefas\n"
                + "4 - Marcar Tarefa como concluida\n"
                + "5 - Sair\n"
                + "Escolha uma Opção: ";
        while (true) 
        {
            Console.Clear();
            System.Console.WriteLine(mensagem);
            string opcao = Console.ReadLine() ?? ""; 

            switch (opcao) 
            {
                case "1":
                    AdicionarTarefa();
                    break;
                
                case "2":
                    RemoverTarefa();
                    break;

                case "3":
                    ListarTarefas();
                    System.Console.WriteLine("Aperte ENTER para continuar.");
                    Console.ReadLine();
                    break;

                case "4": 
                    MarcarConcluida();
                    break;

                case "5": 
                    System.Console.WriteLine("Programa finalizado...");
                    return;

                case "":
                    System.Console.WriteLine("Insira alguma opção: (Aperte ENTER para continuar.)");
                    Console.ReadLine();
                    break;
                    
                default:
                    System.Console.WriteLine("Escolha uma Opção Válida!!! (Aperte ENTER para continuar.)");
                    Console.ReadLine();
                    break;
            }
        }

    }  

    public void AdicionarTarefa()
    {
        Console.Clear();
        System.Console.WriteLine("Qual o nome da tarefa: ");
        string nome = Console.ReadLine() ?? "";

        System.Console.WriteLine("Qual a descrição da tarefa: ");
        string descricao = Console.ReadLine() ?? "";

        tarefas.Add(new Tarefa(nome, descricao));
    }

    public void ListarTarefas()
    {
        Console.Clear();
        if (tarefas.Count == 0)
        {
            System.Console.WriteLine("Nenhuma tarefa registrada!!");
        } 
        else 
        {
            System.Console.WriteLine("====LISTA DE TAREFAS====");
            for (int i = 0; i < tarefas.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}-{tarefas[i].ToString()}");
            }
        }
    }

    public void RemoverTarefa()
    {
        int num = -1;
        while(num != 0)
        {
            Console.Clear();
            ListarTarefas();
            System.Console.WriteLine("Digite o número da tarefa que deseja remover: ");
            num = int.Parse(Console.ReadLine() ?? "");
            tarefas.Remove(tarefas[num - 1]);
            System.Console.WriteLine("Tarefa removida com sucesso!");
        }
    }

    public void MarcarConcluida()
    {
        ListarTarefas();
        System.Console.WriteLine("Digite o número da tarefa que deseja marcar como concluida/pendente: ");
        int num = int.Parse(Console.ReadLine() ?? "");
        if(num < tarefas.Count && num > tarefas.Count)
        {
            System.Console.WriteLine("Essa tarefa não existe");
        } 
        else if(tarefas[num - 1].Concluida == false)
        {
            tarefas[num - 1].Concluida = true;
        }
        else{
            tarefas[num - 1].Concluida = false;
        }
    }
}



