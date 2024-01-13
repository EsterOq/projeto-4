string nome;
int idade;
decimal peso;
decimal altura;
string sexo;

Console.WriteLine("Qual o seu nome? ");
nome = Console.ReadLine();

Console.WriteLine("Qual a sua idade? ");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu peso? ");
peso = decimal.Parse(Console.ReadLine());

Console.Write("Qual a sua altura? ");
altura = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu sexo? ");
sexo = Console.ReadLine();

decimal imc = peso / (altura * altura);

Console.WriteLine("“Olá, meu nome é " + nome + " e tenho " + idade + " anos. Estou animado para começar minha jornada de fitness na academia. Meu objetivo é melhorar minha saúde e bem-estar geral. Atualmente, peso " + peso + " kg e tenho " + altura + " de altura. Sou do sexo " + sexo + " e estou ansioso para trabalhar com os treinadores da academia para alcançar meus objetivos de fitness. Mal posso esperar para começar!”  Meu IMC é: " + imc); 