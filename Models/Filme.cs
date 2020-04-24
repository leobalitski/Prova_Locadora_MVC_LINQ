using System.Linq;
using DbRespositorie;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class FilmeModels
    {
        
        [Key] 
        public int IdFilme { get; set; }
        
        [Required] 
        public string Titulo { get; set; }
      
        [Required]
        public string DataLancamento { get; set; }
        
        [Required]
        public string Sinopse { get; set; }
    
        [Required]
        public double ValorLocacaoFilme { get; set; }
        
        [Required]
        public int EstoqueFilme { get; set; }
        
        public int FilmeLocado { get; set; }
        
        public List<LocacaoModels> locacoes = new List<LocacaoModels>();

    
        public FilmeModels(string titulo, string dataLancamento, string sinopse, double valorLocacaoFilme, int estoqueFilme)
        {
            Titulo = titulo;
            DataLancamento = dataLancamento;
            Sinopse = sinopse;
            ValorLocacaoFilme = valorLocacaoFilme;
            EstoqueFilme = estoqueFilme;
            FilmeLocado = 0;

            var db = new Context();
            db.Filmes.Add(this);
            db.SaveChanges();
        }

            public FilmeModels()
        {

        }

               public static FilmeModels GetFilme(int idFilme)
        {
            var db = new Context();
            return (from filme in db.Filmes
                    where filme.IdFilme == idFilme
                    select filme).First();
        }

        
        public override string ToString()
        {
            var db = new Context();

           
            int qtdFilme = (
                from filme in db.LocacaoFilme
                where filme.IdFilme == IdFilme
                select filme
                ).Count();

            return $"--------------------===[ FILME ]===----------------------------------------------------------------------------------------------\n" +
                    $"--> Nº ID DO FILME: {IdFilme}\n" +
                    $"-> TÍTULO: {Titulo}\n" +
                    $"-> DATA DE LANÇAMENTO: {DataLancamento}\n" +
                    $"-> SINOPSE: {Sinopse}\n" +
                    $"-> VALOR DA LOCAÇÃO: {ValorLocacaoFilme.ToString("C")}\n" +
                    $"-> QTDE EM ESTOQUE: {EstoqueFilme}\n" +
                    $"-> QTDE DE LOCAÇÕES REALIZADAS: {qtdFilme}\n" +
                    $"---------------------------------------------------------------------------------------------------------------------------------\n";
        }

       
        public void AtribuirLocacao(LocacaoModels locacao)
        {
            locacoes.Add(locacao);
        }

       
        public static List<FilmeModels> GetFilmes()
        {
            var db = new Context();
            return db.Filmes.ToList();
        }
    }
}