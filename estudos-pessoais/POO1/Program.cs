Pessoa obj1 = new Pessoa();
obj1.Nome = "Ralf";
obj1.Apresentacao();

Pessoa obj2 = new();
obj2.Nome = "Stella";
obj2.Apresentacao();

Pessoa obj3 = new()
{
    Nome = "Merlin",
    Idade = 23
};
obj3.Apresentacao();
string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);
