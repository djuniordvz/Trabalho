namespace TRABALHO{

    public class CadastroBase
    {
        private string nome = "";
        private string cpf = "";
        private string rg = "";
        private string dataNascimento = "";
        private Endereco endereco;

        public string GetNome(){
            return nome;
        }
        public string SetNome(string nome){
            this.nome = nome;
        }

        public string GetCpf(){
            return cpf;
        }
        public string SetCpf(string cpf){
            this.cpf = cpf;
        }

        public string GetRg(){
            return rg;
        }
        public string SetRg(string rg){
            this.rg = rg;
        }

        public string GetDataNascimento(){
            return dataNascimento;
        }
        public string SetDataNascimento(string dataNascimento){
            this.dataNascimento = dataNascimento;

         public Endereco GetEndereco(){
            return endereco;
        }
        public void SetEndereco(Endereco endereco){
            this.endereco = endereco;
        }

        }
    }
}