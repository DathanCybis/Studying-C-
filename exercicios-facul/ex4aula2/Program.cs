using System;
using System.Collections.Generic;
// Dathan - H781086
namespace EmpresaVendas
{
    // Classe Base Abstrata
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public long Cpf { get; set; }
        protected const double SalarioMinimo = 1412.00;

        public Funcionario(string nome, long cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        // Método abstrato: cada filho deve implementar sua lógica
        public abstract double CalcularSalario();
    }

    // Classe Vendedor
    public class Vendedor : Funcionario
    {
        public double Comissao { get; set; }
        public long NumeroVendas { get; set; }

        public Vendedor(string nome, long cpf, double comissao, long numeroVendas) 
            : base(nome, cpf)
        {
            Comissao = comissao;
            NumeroVendas = numeroVendas;
        }

        public override double CalcularSalario()
        {
            return SalarioMinimo + (Comissao * NumeroVendas);
        }
    }

    // Classe Consultor
    public class Consultor : Funcionario
    {
        public double ValorHora { get; set; }
        public long HorasTrabalhadas { get; set; }

        public Consultor(string nome, long cpf, double valorHora, long horasTrabalhadas) 
            : base(nome, cpf)
        {
            ValorHora = valorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public override double CalcularSalario()
        {
            return ValorHora * HorasTrabalhadas;
        }
    }

    // Classe Gerente
    public class Gerente : Funcionario
    {
        public double Bonificacao { get; set; }

        public Gerente(string nome, long cpf, double bonificacao) 
            : base(nome, cpf)
        {
            Bonificacao = bonificacao;
        }

        public override double CalcularSalario()
        {
            return (SalarioMinimo * 6) + Bonificacao;
        }
    }

    // Programa Principal
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios.Add(new Vendedor("João Silva", 12345678900, 50.0, 20));
            funcionarios.Add(new Consultor("Maria Souza", 98765432100, 100.0, 160));
            funcionarios.Add(new Gerente("Carlos Oliveira", 55544433322, 1500.0));

            Console.WriteLine("--- Folha de Pagamento ---");
            foreach (var f in funcionarios)
            {
                Console.WriteLine($"Nome: {f.Nome} | Cargo: {f.GetType().Name} | Salário: {f.CalcularSalario():C}");
            }
        }
    }
}
