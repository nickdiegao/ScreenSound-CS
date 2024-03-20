//Screen Sound
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

string mensagemBoasVindas = "Boas vindas ao ScreenSound";

/*
//Aula 1
string curso = "C# orientado a objeto";
Console.WriteLine(curso);
string nome = "Nicholas";
string sobrenome = "Diego";
Console.WriteLine(nome +" "+ sobrenome);

//Aula 2
int notaMedia = 10;
if (notaMedia > 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}
List<string> list = ["C#", "Java", "JavaScript", "Python", "C", "C++"];
Console.WriteLine(list[0]);
//
Console.Write("Digite um número: ");
string numero = Console.ReadLine()!;
int numeroInteiro = int.Parse(numero);
Console.WriteLine(list[numeroInteiro]);

//Desafio do jogo do número aleátorio
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
do
{
    Console.WriteLine("Digite um número entre 1 e 100");
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns, você acertou!");
        break;
    } else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior");
    } else
    {
        Console.WriteLine("O número é menor");
    }
} while (true);

Console.WriteLine("O jogo acabou");

//Aula 3
void exibeNumeros(double n,double b)
{
    Console.WriteLine($"A soma de {n} + {b}: {n+b}");
    Console.WriteLine($"A subtração de {n} - {b}: {n - b}");
    Console.WriteLine($"A multiplicação de {n} x {b}: {n * b}");
    Console.WriteLine($"A divisão de {n} / {b}: {n / b}");
}

exibeNumeros(3.0, 6.2);

List<string> bandas = new List<string> {"Kanye West","Radiohead","Tv Girl"};
foreach (string band in bandas)
{
    Console.WriteLine(band);   
}

List<int> numeros =  new List<int> { 1,2,3,4,5,6,7,8};
int contador = 0;

for (int i = 0; i < numeros.Count; i++)
{
    contador += numeros[i];
}
Console.WriteLine(contador);

//Aula 4
Dictionary<string, List<int>> notasJoao = new Dictionary<string, List<int>>();

notasJoao["João"] = new List<int> { 1,2,3};
foreach (var item in notasJoao) 
{
    int soma = 0;
    for (int i = 0; i < item.Value.Count; i++)
    {
        soma += item.Value[i];
    }
    double media = soma / item.Value.Count;
    Console.WriteLine(media);
}

Dictionary<string, int> estoque = new Dictionary<string, int>
{
    { "camisetas", 50 },
    { "calças", 30 },
    { "tênis", 20 },
};

string produto = "camisetas";

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
}
else
{
    Console.WriteLine("Produto não encontrado no estoque.");
}

Dictionary<string, string> perguntas = new Dictionary<string, string>
{
    {"O céu é azul?","Verdadeiro"},
    {"O sol é amarelo","Verdadeiro"}
};

int count = 0;

foreach (var item in perguntas)
{
    Console.Write(item.Key);
    string resposta = Console.ReadLine()!;

    if (resposta == "Verdadeiro")
    {
        Console.WriteLine("Parabéns você acertou!");
        count += 1;
    } else
    {
        Console.WriteLine("Você errou!");
    }
}

Dictionary<string, int> login = new Dictionary<string, int>
{
    {"Nicholas",1234},
    {"José",1234}
};

string sla = Console.ReadLine();
int slaNumerico = int.Parse(sla);

for (int i=0; i < slaNumerico; i++)
{
    string nome = Console.ReadLine();
    string senha = Console.ReadLine();
    int senhaNumerica = int.Parse(senha);
    login.Add(nome, senhaNumerica);
}
*/

//List<string> listaDeBandas = new List<string> {"RadioHead", "Deftones", "The beatles"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park",new List<int> { 10, 8, 8 });
bandasRegistradas.Add("The beatles", new List<int>());

void ExibeNomeDaFuncao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos+"\n"); 
}

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesDeMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para registras uma banda");
    Console.WriteLine("Digite 2 para listar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
   
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: ListarBandas();
            break;
        case 3: AvaliarBandas();
            break;
        case 4: ExibeMedia();
            break;
        case -1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibeNomeDaFuncao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registradada");
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDeMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibeNomeDaFuncao("Listando todas as bandas");
    //for (int i = 0; i < listaDeBandas.Count; i++)
    //{
    //    Console.WriteLine($"{i+1}° banda: {listaDeBandas[i]}");
    //}
    int count = 0;
    foreach (string band in bandasRegistradas.Keys)
    {
        count++;
        Console.WriteLine($"{count}° banda: {band}");
    }
    Console.Write("\nDigite uma tecla para voltar para o menu principal ");
    Console.ReadLine();
    Console.Clear();
    ExibirOpcoesDeMenu();
}

void AvaliarBandas()
{
    Console.Clear();
    ExibeNomeDaFuncao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota a banda {nomeBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDeMenu();
    } else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
        Console.Write("Digite uma tecla para voltar ao menu principal ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
}

void ExibeMedia()
{
    Console.Clear();
    ExibeNomeDaFuncao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine($"A média da banda {nomeBanda} foi: " + notasDaBanda.Average());
        Console.Write("Digite uma tecla para voltar para o menu principal: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu(); 
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada!");
        Console.Write("Digite uma tecla para voltar ao menu principal ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
}

ExibirOpcoesDeMenu();

/*
 var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};
 */
