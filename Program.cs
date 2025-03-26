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
                Console.Clear();
                    AdicionarTarefa();
                    break;
                
                case "2":
                Console.Clear();
                    RemoverTarefa();
                    break;

                case "3":
                Console.Clear();
                    ListarTarefas();
                    System.Console.WriteLine("Aperte ENTER para continuar.");
                    Console.ReadLine();
                    break;

                case "4": 
                Console.Clear();
                    MarcarConcluida();
                    break;

                case "5": 
                Console.Clear();
                    System.Console.WriteLine("Programa finalizado...");
                    return;

                case "":
                Console.Clear();
                    System.Console.WriteLine("Insira alguma opção: (Aperte ENTER para continuar.)");
                    Console.ReadLine();
                    break;
                    
                default:
                Console.Clear();
                    System.Console.WriteLine("Escolha uma Opção Válida!!! (Aperte ENTER para continuar.)");
                    Console.ReadLine();
                    break;
            }
        }

    }  

    public void AdicionarTarefa()
    {
        System.Console.WriteLine("Qual o nome da tarefa: ");
        string nome = Console.ReadLine() ?? "";

        System.Console.WriteLine("Qual a descrição da tarefa: ");
        string descricao = Console.ReadLine() ?? "";

        tarefas.Add(new Tarefa(nome, descricao));
    }

    public void ListarTarefas()
    {
        if (tarefas.Count == 0)
        {
            Console.Clear();
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
        System.Console.WriteLine("Digite o número da tarefa que deseja remover: ");
        ListarTarefas();
        if(tarefas.Count != 0)
        {
            int num = int.Parse(Console.ReadLine() ?? "");
            tarefas.Remove(tarefas[num - 1]);
            System.Console.WriteLine("Tarefa removida com sucesso!");
        }
        else
        {
            Console.ReadLine();
            return;
        }
        
    }

    public void MarcarConcluida()
    {
        ListarTarefas();
        if(tarefas.Count != 0)
        {
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
        else
        {
            Console.ReadLine();
            return;
        }
        
    }
}



