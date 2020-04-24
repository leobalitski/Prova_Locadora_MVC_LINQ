using System;
using Models;
using Controllers;
using System.Linq;

namespace View
{
    public class ClienteView
    {
        
        public static void CadastrarCliente()
        {
            Console.WriteLine("---===[ CADASTRO DO CLIENTE ]===---");
            Console.WriteLine("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("\nData de Nascimento (dd/mm/yyyy): ");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("\nCPF.: ");
            string cpfCLiente = Console.ReadLine();
            Console.WriteLine("\nDias  Devolução: ");
            int diasDevolucao = Convert.ToInt32(Console.ReadLine());

            ClienteController.CadastrarCliente(
                nomeCliente, 
                dataNascimento, 
                cpfCLiente, 
                diasDevolucao
            );
        }

     
        public static void ListarClientes()
        {
            Console.WriteLine("=================[ LISTA DE CLIENTES ]=================");
            ClienteController.GetClientes().ForEach(cliente => Console.WriteLine(cliente));
        }

       
        public static void ConsultarCliente()
        {
            Console.WriteLine("ID do Cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());
            

            try 
            {
                ClienteModels cliente =
                (from cliente1 in ClienteController.GetClientes()
                 where cliente1.IdCliente == idCliente
                 select cliente1).First();


                Console.WriteLine("=================[ CONSULTA CLIENTE ]==================");
                Console.WriteLine(cliente.ToString());
            }
            catch
            {
                Console.WriteLine("==> CLIENTE NÃO encontrado!");
            }
        }
    }
}