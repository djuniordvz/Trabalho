namespace TRABALHO{
    public abstract class Funcionario:CadastroBase{

        private double salario;

        
        private static int QtdFuncionarios{ get; set;}

        public Funcionario (double salario){
            this.salario = salario;
            QtdFuncionarios ++;
        }

        public double GetSalario(){
            return salario;
        }

        public void SetSalario(double salario){
            this.salario = salario;
        }
    }
}