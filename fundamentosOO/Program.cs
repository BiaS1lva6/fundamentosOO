using fundamentosOO;

internal class Program
{
    private static void Main(string[] args)
    {
        //    // Instanciar um Objeto do tipo aluno
        //    Aluno aluno1 = new Aluno();
        //    Aluno aluno2 = new Aluno();
        //    // Preencher os atributos do objeto
        //    aluno1.Nome = "Beatriz Silva";
        //    aluno1.RM = "1234TI";
        //    aluno1.Email = "beatriz080407@gmail.com";
        //    aluno1.Nascimento = new DateOnly(2007, 04, 08);


        //    aluno2.Nome = "Flaviana Silva";
        //    aluno2.RM = "345700";
        //    aluno2.Email = "flaviananasc16@gmail.com";
        //    aluno2.Nascimento = new DateOnly(1980, 10, 16);

        //    //imprimir na tela
        //    Console.WriteLine("Aluno 1");
        //    Console.WriteLine("Nome: " + aluno1.Nome);
        //    Console.WriteLine("RM: " + aluno1.RM);
        //    Console.WriteLine("Email: " + aluno1.Email);
        //    Console.WriteLine("Nascimento: " + aluno1.Nascimento);
        //    Console.WriteLine("===============================================");

        //    Console.WriteLine("Aluno 2");
        //    Console.WriteLine("Nome: " + aluno2.Nome);
        //    Console.WriteLine("RM: " + aluno2.RM);
        //    Console.WriteLine("Email: " + aluno2.Email);
        //    Console.WriteLine("Nascimento: " + aluno2.Nascimento);
        //    Console.WriteLine("===============================================");

        //    //Instanciar um Objeto tipo produto
        //    Produto p1 = new Produto();
        //    p1.Codigo = 123456;
        //    p1.Nome = "Coca-cola  3L";
        //    p1.Preco = 12.99;
        //    p1.Estoque = 96;
        //    //Chamar o metodo QuantidadeEstoque
        //    p1.QuantidadeEstoque();
        //    p1.Estoque = 85;
        //    //Chamar o metodo QuantidadeEstoque
        //    p1.QuantidadeEstoque();



        //    Console.WriteLine("===============================================");
        //    Console.WriteLine();

        //    //Instanciar um objeto do tipo carro
        //    Carro carro1 = new Carro();
        //    carro1.Marca = "Ferrari";
        //    carro1.Modelo = "488";
        //    carro1.Velocidade = 80;

        //    carro1.Acelerar();
        //    carro1.Acelerar();
        //    carro1.Acelerar();
        //    carro1.Desacelerar();



        //    Console.WriteLine("===============================================");
        //    Console.WriteLine();

        //    Pessoa nome1 = new Pessoa();
        //    nome1.Nome = "Beatriz";
        //    nome1.Idade = 17;

        //    nome1.Envelhecer(5);


        //    Console.WriteLine("===============================================");
        //    Console.WriteLine();

        //    Funcionario func1 = new Funcionario();
        //    func1.Nome = "Aurora";
        //    func1.Idade = 20;
        //    func1.Cargo = "Aprendiz";
        //    func1.Salario = 1400.00;
        //    func1.ApresentarSe();

        //    //Console.WriteLine("===============================================");
        //    //Console.WriteLine();

        //    ////Instanciar um objeto
        //    //Animal animal1 = new Animal();

        //    //////inserindo dados do atributo
        //    //animal1.Especie = "Cachorro";

        //    ////chamando o metodo objeto
        //    //animal1.emitirSom();

        //    ////imprimindo informação na tela
        //    //Console.WriteLine("O Animal " + animal1.Especie + " emitiu um som");

        Gato gato = new Gato();
        gato.Nome = "Clara";
        Console.WriteLine(gato.Nome + " faz: ");
        gato.emitirSom();

        Galinha cocow = new Galinha();
        cocow.Nome = "Claudete";
        Console.WriteLine(cocow.Nome + " faz: ");
        cocow.emitirSom();

        Porco porc = new Porco();
        porc.Nome = "Britney";
        Console.WriteLine(porc.Nome + " :faz ");
        porc.emitirSom();
    }
}