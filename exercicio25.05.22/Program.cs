
using exercicio25._05._22;

Console.WriteLine("Estamos fazendo uma entrevista com você, por favor responda esse questionário!");
String nome, cidade, altura, idade;
int peso;
Console.WriteLine("Digite o nome da pessoa: ");
nome = Console.ReadLine();
Console.WriteLine("Digite a cidade natal que ela nasceu: ");
cidade = Console.ReadLine();
Console.WriteLine("Digite o peso desta pessoa: ");
peso = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura desta pessoa: ");
altura = (Console.ReadLine());
Console.WriteLine("Digite a idade desta pessoa: ");
idade = (Console.ReadLine());

Pessoa P1 = new Pessoa (nome, cidade, peso, altura, idade);

Console.WriteLine("O nome da pessoa é: " + nome + " a sua cidade natal é " + cidade + " ela pesa " + peso + "Kg, e mede " + altura + " ahhhh! ela tem " + idade + " anos.");