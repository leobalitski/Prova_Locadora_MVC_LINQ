using System;
using View;


namespace Locadora_MVC_LinQ
{
    public class Principal
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("LOCADORA DE FILMES");


            
            int menu = 0;
            do
            {
                
                Console.WriteLine("\n|******************************|");
                Console.WriteLine("|============[ MENU ]============|");
                Console.WriteLine("|********************************|");
                Console.WriteLine("|---|---===[ USUSARIO ]===--------|");
                Console.WriteLine("| 1 |  Cadastrar usuario         |");
                Console.WriteLine("| 2 |  Consultar usuario         |");
                Console.WriteLine("| 3 |  Listar usuarios           |");
                Console.WriteLine("|---|-------===[ FILME ]===---------|");
                Console.WriteLine("| 4 |  Cadastrar Filme           |");
                Console.WriteLine("| 5 |  Consultar Filme           |");
                Console.WriteLine("| 6 |  Listar Filmes             |");
                Console.WriteLine("|---|-----===[ LOCAÇÃO ]===------|");
                Console.WriteLine("| 7 |  Cadastrar Locação         |");
                Console.WriteLine("| 8 |  Consultar Locação         |");
                Console.WriteLine("| 9 |  Listar Locações           |");
                Console.WriteLine("| 99 |  SAIR                      |");
                Console.WriteLine("|---|-----------------------------|");
                Console.WriteLine("|*********************************|");

                Console.WriteLine("\nDigite a Opção: ");
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    menu = 99;
                }


                
                switch (menu)
                {
                    case 1: 
                        ClienteView.CadastrarCliente();
                        break;
                    case 2: 
                        ClienteView.ConsultarCliente();
                        break;
                    case 3: 
                        ClienteView.ListarClientes();
                        break;
                    case 4:
                        FilmeView.CadastrarFilme();
                        break;
                    case 5:
                        FilmeView.ConsultarFilme();
                        break;
                    case 6:
                        FilmeView.ListarFilmes();
                        break;
                    case 7:
                        LocacaoView.CadastrarLocacao();
                        break;
                    case 8:
                        LocacaoView.ConsultarLocacao();
                        break;
                    case 9:
                        LocacaoView.ListarLocacao();
                        break;
                }
            } while (menu != 99);

        }
    }
}
