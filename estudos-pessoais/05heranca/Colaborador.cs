using System.Runtime.InteropServices;

class Colaborador : Pessoa
{
    // Atributoss
    private string? _cargo;
    private double _salario;

    // Construtor
    public Colaborador(string nome, int idade, string cargo, double salario)
    {
        Nome = nome;
        Idade = idade;  
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }

    // Método para apresentar os dados
    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"Salário: {_salario}");
    }
}
