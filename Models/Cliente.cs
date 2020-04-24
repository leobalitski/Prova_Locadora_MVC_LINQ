using System.Linq;
using DbRespositorie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ClienteModels
    {
    
        [Key] 
        public int IdCliente { get; set; }
       
        [Required] 
        public string NomeCliente { get; set; }

        [Required]
        public string DataNascimento { get; set; }
        
        [Required]
        public string CpfCliente { get; set; }
        
        [Required]
        public int DiasDevolucao { get; set; }
      
        public List<LocacaoModels> locacoes = new List<LocacaoModels>();

        
        public ClienteModels(string nomeCliente, string dataNascimento, string cpfCliente, int diasDevolucao)
        {
            NomeCliente = nomeCliente;
            DataNascimento = dataNascimento;
            CpfCliente = cpfCliente;
            DiasDevolucao = diasDevolucao; 
            locacoes = new List<LocacaoModels>();           

            var db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        } 

        
        public ClienteModels()
        {

        }

               public static ClienteModels GetCliente(int idCliente)
        {
            var db = new Context();
            return (from cliente in db.Clientes
                    where cliente.IdCliente == idCliente
                    select cliente).First();
        }

        
        public override string ToString()
        {
            return $"-------------------===[ CLIENTE ]===-------------------\n" +
                    $"--> Nº ID DO CLIENTE: {IdCliente}\n" +
                    $"-> NOME COMPLETO: {NomeCliente}\n" +
                    $"-> DATA DE NASCIMENTO: {DataNascimento}\n" +
                    $"-> CPF: {CpfCliente}\n" +
                    $"-> DIAS P/ DEVOLUÇÃO: {DiasDevolucao}\n" +
                    $"-------------------------------------------------------";
        }  

      public void AdicionarLocacao(LocacaoModels locacao)
        {
            locacoes.Add(locacao);
        }     

        
        public static List<ClienteModels> GetClientes()
        {
            var db = new Context();
            return db.Clientes.ToList();
        }
    }
}