namespace CrudAPI.Models{
    public class Pessoa{
        public int PessoaID {get; set;}
        public string Nome {get; set;} = string.Empty;
        public string Sobrenome {get; set;} = string.Empty;
        public int Idade {get; set;}
        public string Profissao {get; set;} = string.Empty;
    }
}