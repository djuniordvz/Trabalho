namespace TRABALHO{

    public abstract class CadastroBase
    {
        private int codigo;
        private string nome = "";
        private string cpf = "";
        private string rg = "";
        private string dataNascimento = "";
        private Endereco endereco;
        private static int ultimoCodigo;

        public CadastroBase(){
            ultimoCodigo++
            this.codigo = ultimoCodigo;
            this.nome = "";
            this.cpf = "";
            this.rg = "";
            this.dataNascimento == new DateTime();
            this.endereco = new endereco();

        }
        
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

        public void CadastroBase(){
            Console.WriteLine("______________________________________|");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|           Cadastro Base :           |");
            Console.WriteLine("|_____________________________________|");
            Console.Write("\n\n");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("RG: ");
            rg = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            dataNascimento= Console.ReadLine();

            endereco.CadastroBase();
        }

        
    }
}