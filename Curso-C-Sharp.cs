// PRATICANDO C # com as aulas distribuidas em https://github.com/orgs/cod3rcursos/repositories

**********OBSERVAÇÃO * **********

O conteúdo disponibilizado aqui serve para ajudar na hora do estudo, portanto,
este não se trata de um arquivo executável.
	Será atualizado constantemente.
*************************************************************************************



public static void Executar() // em vez de Main por Executar
{
    System.Console.WriteLine("Primeiro");/*Acima já está "using System", 
                                                  * portanto não é preciso por no 
                                                  * código repetidas vezes "System"*/
    Console.WriteLine("Programa");
    Console.WriteLine("Terminou!");
}


internal class Comentarios
{
    public static void Executar()
    //evitar comentários desnecessários
    {
        Console.WriteLine("Código limpo é sempre melhor");
        Console.WriteLine("O C# tem xml coments: ///");
        /// XML COMENTS para gerar tag
        /// Pode fazer referências para outras partes da documentação
        /// Precione Ctrl+espaço
        ///
        /*Existem também os
         * comentários óbvios, quando o nome de uma 
         * varioável já diz todo o necessário para o entendimento dela.
         */
        //Pode usar atalho padrão: Selecionar e Ctrl+K+c e Ctrl+k+u
    }
}





internal class VariaveisEConstantes
{
    public static void Executar()
    {
        //Área da circunferência
        double raio = 4.5;
        raio = 5.7;
        const double Pi = 3.14159;
        double area = Pi * raio * raio;
        Console.WriteLine("Área 1: " + area);
        Console.WriteLine("Área 2: " + area + 1000);
        Console.WriteLine("Área 3: " + (area + 1000) + " m2");

        bool EstaChovendo = false;
        Console.WriteLine("Está chovendo: " + EstaChovendo);

        byte idade = 45; //não aceita número negativo,
                         //menor recurso de memória comparado ao int
        Console.WriteLine("Idade: " + idade);

        sbyte SaldodeGols = sbyte.MinValue;
        Console.WriteLine("Saldo de gols: " + SaldodeGols);

        short Salario = short.MaxValue;
        Console.WriteLine("Salario :" + Salario);

        int menorValorInteiro = int.MinValue; // mais usado dos inteiros
        Console.WriteLine("Menor valor inteiro: " + menorValorInteiro);

        uint populancaoBrasileira = 230_000_000;//underline é apenas visual, ajuda a visualizar 
        Console.WriteLine("População brasileira: " + populancaoBrasileira);

        long menorValorLong = long.MinValue;
        Console.WriteLine("Menor valor long: " + menorValorLong);

        ulong populacaoMundial = 7_500_000_000;
        Console.WriteLine("População mundial: " + populacaoMundial);

        float precoComputador = 1_345.98f;
        Console.WriteLine("Preço do Computador: " + precoComputador);

        var precoComputador2 = 1_345.98;
        Console.WriteLine("Teste VAR: " + precoComputador2);

        double valorApple = 1_000_000_000_000;
        Console.WriteLine("Valor empresa Apple: " + valorApple);

        decimal distanciaEntreEstrelas = decimal.MaxValue;
        Console.WriteLine("Distância entre as estrelas: " + distanciaEntreEstrelas);

        char letra = 'b';//aspas simples é somente para UMA letra
        Console.WriteLine("Letra: " + letra);

        string texto = "Sean bienvenidos";
        Console.WriteLine("Texto: " + texto);

    }

}





internal class Inferencia
{
    public static void Executar()
    {
        var nome = "Meu nome é Leandro.";//O var vai converter para string implicitamente
        Console.WriteLine(nome);

        //int idade = 42; ou 
        var idade = 42;
        Console.WriteLine("Minha idade é " + idade + " anos");

        int a;
        a = 2;
        var b = 5;
        Console.WriteLine("A + B = " + (a + b));

    }
}





internal class Interpolacao
{
    public static void Executar()
    {
        var nome = "Computer Gamer"; //string
        var marca = "Dell";
        var valor = 2_757.97; //double
        Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + valor + ".");//concatenação
        Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, valor);
        Console.WriteLine($"A marca {marca} é boa.");
        Console.WriteLine($"1 + 1 = {1 + 1}"); // $ é para ativar a interpolação de a e b

    }
}




internal class NotacaoPonto
{
    public static void Executar()
    {
        var saudacao = "olá".ToUpper().Insert(3, " world!").Replace("world!", "mundo!");
        Console.WriteLine(saudacao);
        Console.WriteLine("Leandro".Length); //Ctrl + espace após o ponto
        Console.WriteLine("A palavra 'Leandro' tem " + ("Leandro".Length) + " letras");

        string valorImportante = null;
        Console.WriteLine(valorImportante.Length);// VAI RETORNAR ERRO devido ao valor vazio
        Console.WriteLine(valorImportante?.Length);/* O "?" vai fazer aguardar 
                                                        * algum valor na variável e vai 
                                                        * imprimir na tela um espaço de uma 
                                                        * linha vazia*/

    }
}




class LeituraDeDados
{
    public static void Executar()
    {
        Console.Write("Qual é o seu nome? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é a sua idade? ");
        int idade = int.Parse(Console.ReadLine());//Parse é para converter, há formas mais seguras

        Console.Write("Qual é o seu salário? ");
        double salario = double.Parse(Console.ReadLine(),
            CultureInfo.InvariantCulture);/* vai passar ponto para virgula,
                                               * usar no cabeçalho: using System.Globalization;*/

        Console.WriteLine($"{nome} {idade} R${salario}");
    }
}





class FormatandoNumero
{
    public static void Executar()
    {
        double valor = 15.175;
        Console.WriteLine(valor.ToString("F1"));//unica casa decimal após vírgula
        Console.WriteLine(valor.ToString("C"));//passa para valor monetário do sistema
        Console.WriteLine(valor.ToString("P"));//converte e poe o símbolo de porcentagem
        Console.WriteLine(valor.ToString("#.##"));// 2 casas decimais, mas poderia ter colocado F2

        CultureInfo cultura = new CultureInfo("en-US"); // torna fixo o símbolo
        Console.WriteLine(valor.ToString("C0", cultura));
        Console.WriteLine(valor.ToString("C2", cultura));
        //CultureInfo cultura = new CultureInfo("pt-BR");
        //Console.WriteLine(valor.ToString("C2", cultura));

        int inteiro = 256;
        Console.WriteLine(inteiro.ToString("D10"));
    }
}




class Conversoes
{
    public static void Executar()
    {
        int inteiro = 10;
        double quebrado = inteiro;//conversão implicita
        Console.WriteLine(quebrado);

        double nota = 9.7;
        int notaTruncada = (int)nota;//explicitar conversão (int), perderá valores double para int
        Console.WriteLine("Nota truncada: {0}", notaTruncada);

        Console.Write("Digite sua idade: ");
        string idadeString = Console.ReadLine();
        int idadeInteiro = int.Parse(idadeString);
        Console.WriteLine("Idade inserida: {0}", idadeInteiro);

        idadeInteiro = Convert.ToInt32(idadeString);
        Console.WriteLine("Resultado: {0}", idadeInteiro);

        Console.Write("Digite o primeiro número: ");
        string palavra = Console.ReadLine();
        int numero1;
        int.TryParse(palavra, out numero1);//digitar letra resultará 0
        Console.WriteLine("Resultado 1: {0}", numero1);

        Console.Write("Digite o segundo número: ");
        int.TryParse(Console.ReadLine(), out int numero2);//mais otimizado, digitar letra resultará 0
        Console.WriteLine("Resultado 2: {0}", numero2);
    }
}




class OperadoresAritmeticos
{
    public static void Executar()
    {
        // Preço Desconto
        var preco = 1000.0;
        var imposto = 355;
        var desconto = 0.1;

        double total = preco + imposto;
        var totalComDesconto = total - (total * desconto);
        Console.WriteLine("O preço final é {0}", totalComDesconto);

        // IMC
        double peso = 91.2;
        double altura = 1.82;
        double imc = peso / Math.Pow(altura, 2);
        Console.WriteLine($"IMC é {imc}.");

        // Número Par/Impar
        int par = 24;
        int impar = 55;
        Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); //O sinal "%" é para o resto da divisão
        Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
    }
}




class OperadoresRelacionais
{
    public static void Executar()
    {
        // double nota = 6.0;
        Console.Write("Digite a nota: ");
        double.TryParse(Console.ReadLine(), out double nota);
        double notaDeCorte = 7.0;

        Console.WriteLine("Nota inválida, > 10: {0}", nota > 10.0);
        Console.WriteLine("Nota inválida, < 0: {0}", nota < 0.0);
        Console.WriteLine("Perfeito, tirou 10: {0}", nota == 10.0);
        Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);// !=  diferente
        Console.WriteLine("Passou por média >= 7 ? {0}", nota >= notaDeCorte);
        Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
        Console.WriteLine("Reprovado? {0}", nota <= 3.0);

    }
}



class OperadoresLogicos
{
    public static void Executar()
    {
        var executouTrabalho1 = false;
        var executouTrabalho2 = true;
        Console.WriteLine("Vai trabalhar  2 dias esta semana e ir às compras,\n" +
            "se entregar os trabalhos e receber em 1 ou nos 2, ou nem receber,\n" +
            "como ficam os casos abaixo? ");

        Console.WriteLine("\nUm e outro:");
        bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
        Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

        Console.WriteLine("\nUm ou outro:");
        var comprouSorvete = executouTrabalho1 || executouTrabalho2; //  ||  ou condicional
        Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

        Console.WriteLine("\nOu um, ou outro:");
        var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; //  ^  ou exclusivo
        Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

        Console.WriteLine("\nEconomizou em gartar com sorvete? {0}", !comprouSorvete); //  ! inverte saída
    }
}




class OperadoresAtribuicao
{
    public static void Executar()
    {
        var num1 = 3;
        num1 = 7; // aqui o valor foi substítuido
        num1 += 10; // é a mesma coisa que: num1 = num1 + 10;
        num1 -= 3; // num1 = num1 - 3;
        num1 *= 5; // num1 = num1 * 5;
        num1 /= 2; // num1 = num1 / 2;

        Console.WriteLine(num1);

        int a = 1;
        int b = a;

        a++; // a = a + 1;  incremento
        b--; // b = b - 1;  decremento

        Console.WriteLine($"{a} {b}");// $ é para ativar a interpolação de a e b


        dynamic c = new System.Dynamic.ExpandoObject();
        c.nome = "João";

        dynamic d = c;
        d.nome = "Maria";

        Console.WriteLine(c.nome);
        Console.WriteLine(d.nome);
    }
}




class OperadoresUnarios
{
    public static void Executar()
    {
        var valorNegativo = -5;
        var numero1 = 2;
        var numero2 = 3;
        var booleano = true;
        Console.WriteLine("valorNegativo = -5; booleano = true; numero1 = 2; numero2 = 3;  \n******************");

        Console.WriteLine("-valorNegativo: ");
        Console.WriteLine(-valorNegativo);
        Console.WriteLine("!booleano: ");
        Console.WriteLine(!booleano);

        numero1++;
        Console.WriteLine("numero1++ (incremento): ");
        Console.WriteLine(numero1);

        --numero1;
        Console.WriteLine("--numero1 (decremento): ");
        Console.WriteLine(numero1);

        Console.WriteLine("\n(numero1++ == --numero2):");
        Console.WriteLine(numero1++ == --numero2);/* para BOAS PRÁTICAS evitar esse tipo de
                                                       * algorítmo, misturando muitas coisas.*/
        Console.WriteLine($"{numero1} {numero2}");
    }
}





class OperadorTernario
{
    public static void Executar()
    {
        var nota = 9.0;
        bool bomComportamento = true;
        string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
        Console.WriteLine(resultado);
    }
}



// ESTRUTURAS DE CONTROLE

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s"; /*Essa estrutura substitui as outras
                                                          *3 acima, já cria uma estrutura de valor
                                                          *lógico e passa o dígito para minusculo*/

            if (nota >= 9.0 && bomComportamento)/*nunca por ; aqui*/
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }






    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }




    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s"; /*Essa estrutura substitui as outras
                                                          *3 acima, já cria uma estrutura de valor
                                                          *lógico e passa o dígito para minusculo*/

            if (nota >= 9.0 && bomComportamento)/*nunca por ; aqui*/
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }




    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra!");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Te vejo na proxima...");
            }

            Console.WriteLine("Fim!!");
        }
    }




    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    Console.WriteLine("Parabéns!");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Obrigado por responder!");
        }
    }



    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas",
                        tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}",
                        tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}",
                        tentativasRestantes);
                }
            }
        }
    }




    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }



    class EstruturaFor
    {
        public static void Executar()
        {
            //for (int i = 1; i <= 10; i++) {
            //    Console.WriteLine($"O valor de i é {i}.");
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamano da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);
        }
    }





    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }




    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }






    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }



///Classes e métodos
///

    using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
    { //Esta classe esta vinculada com a classe membros
        class Pessoa  //tipo

        {    //2 atributos
            public string Nome; //string tem valor padrão NULL
            public int Idade; // int tem valor padrão 0. Segure Ctrl e 2 clics do mouse sobre int

            //abaixo 2 comportamentos
            public string Apresentar()
            {
                return string.Format(
                    $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
            }

            public void ApresentarNoConsole()
            {
                Console.WriteLine(Apresentar());
            }

            public void Zerar()
            {
                Nome = "";
                Idade = 0;
            }
        }
    }





    using System;
//using System.Collections.Generic;      *não precisa declarar por já estar dentro 
//using System.Text;                      da mesma classe Pessoa*

namespace CursoCSharp.ClassesEMetodos
    { //Esta classe esta vinculada com a classe Pessoa
        class Membros /*esta aula mostra a possibilidade de criar varios arquivos dentro
                   * do mesmo namespace, sem ter que abrir novos arquivos, é apenas 
                   * uma questão de organização.*/
        {
            public static void Executar()
            {

                //clsse              construtor     diferenças entre as palavras Pessoas
                Pessoa sicrano = new Pessoa();//Segure Ctrl e clicar sobre pessoa
                sicrano.Nome = "Leandro";
                sicrano.Idade = 42;

                // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

                sicrano.ApresentarNoConsole();
                sicrano.Zerar();
                sicrano.ApresentarNoConsole();

                var fulano = new Pessoa();
                fulano.Nome = "Jaspion";
                fulano.Idade = 57;

                var apresentacaoDoFulano = fulano.Apresentar();
                Console.WriteLine(apresentacaoDoFulano.Length);
                Console.WriteLine(apresentacaoDoFulano);
            }
        }
    }







    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro()
        {

        }
    }

    class Construtores // 3 formas de criar os construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine(
                $"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine(
                $"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine(
                $"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }




    class CalculadoraComum
    {

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        { /// Neste caso é uma repetição, mesma 
          ///assinatura (Somar), mas não 
          ///vai dar erro por ter um item a mais, "c".
          ///o C# vai entender pela quantidade de dados
          ///digitado pelo usuário.
            return a + b + c;
        }


        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(3, 77);


            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));

            Console.WriteLine("calculadoraCadeia:");
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
            Console.WriteLine("calculadoraCadeia, resultado:");
            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }





    public class CalculadoraEstatica
    {
        ///Esse método é de CLASSE ou ESTÁTICO!

        // static diz que pode acessar diretamente sem criar instância
        //não pertence mais ao objeto, mas sim à classe 
        //           pode ser compartilhado!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método de instância!!!
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine("Resultado, multiplicar: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Soma: " + calc.Somar(2, 7));
            //Console.WriteLine(calc.Multiplicar(2, 7));     // desse modo vai dar erro
            //tem que acessar pela classe
        }
    }






    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto: {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}",
                produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("Preço com desconto: {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}",
                produto2.CalcularDesconto());
        }
    }






    class DesafioAtributo
    {
        int a = 10;
        int b = 11;
        // Uma outra forma seria:   static int b = 11;
        // e dentro de executar:    Console.WriteLine(b);
        int c = 12;

        public static void Executar()
        {
            // Acessar variável 'b' dentro do método Executar!
            // Console.WriteLine(b);

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.b);
        }
    }


    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia");
        }
    }



    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);//O zero caso tenha 1 digito
                                                                  //D2 para casas decimais
                                                                  //ordenado corretamente
        }

        public static void Executar()
        {
            Formatar(mes: 1, ano: 1996, dia: 6); //Os parâmetros estão nomeados, por isso
                                                 //a ordem arrada aqui não vai inteferir
        }
    }





    public class Moto
    {
        private string Marca; // se deixar sem o private ele já estará automaticamente
        private string Modelo;
        private uint Cilindrada;
        //get vai ler
        //set vai modificar um valor private 

        public Moto(string marca, string modelo, uint cilindrada)
        { //uint é sem sinal,
          //não permite nº negativo
          //Marca = marca;
          //Modelo = modelo;
          //Cilindrada = cilindrada;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto()
        { // Existem algoritmos melhores que esse, ver em Props

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        { // recebe novos parâmetros
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        { //uint é sem sinal, não permite número negativo
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        { //uint é sem sinal
            // 1 Opção
            //if(cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}

            // 2 Opção
            //Cilindrada = Math.Abs(cilindrada);   para tirar valores negativos

            Cilindrada = cilindrada;
        }
    }

    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca()); // esse é meio de acessar por estar private
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150); // o valor negativo não vai ser aceito
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo()
                + " " + moto2.GetCilindrada());
        }
    }






    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento; //readonly vai inicializar somente leitura
        ///const no lugar dele da erro, precisa de valor inicial
        /// exenplo,  cosnt int x = 2;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2020, 10, 10);
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }

    class Readonly
    {
        static public void Executar()
        {
            var novoCliente = new Cliente("Ana Silva",
                new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            // novoCliente.Nascimento = new DateTime(2020, 10, 10);
        }
    }





    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            //Acrecesta categoria
            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo,
                filmeParaFamilia.GeneroDoFilme);
        }
    }





    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    { //struct se parece muito com classe, veja em struct versus classe
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }



    public struct StructPonto
    {
        public int X;
        public int Y;
    }

    public class ClassePonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar()
        {
            StructPonto ponto1 = new StructPonto { X = 1, Y = 3 }; /// STRUCT
            StructPonto copiaPonto1 = ponto1; // Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            ClassePonto ponto2 = new ClassePonto { X = 2, Y = 4 };   ///CLASSE
            ClassePonto copiaPonto2 = ponto2; // Atribuição por REFERÊNCIA!!!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }



    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21; // altera idade

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }



    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;// ref vai trazer o número 3 de a e somar + 1000
        }

        //out é unidirecional
        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            // int b;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");
        }
    }





    O out é útil como uma forma duma função "retornar" mais de um valor, já que 
        existem casos onde vamos querer obter mais de um valor a partir de uma 
        função.Então, como não podemos retornar uma segunda variável pois isso 
            não é permitido no C#, temos parâmetros marcados como out , que nada 
            mais são do que variáveis para guardarmos valores que queremos
            retornar além do valor no return da função.

Um bom exemplo é o método TryParse que é usado para converter um string 
            num int. Caso ele consiga converter a string sem problemas, 
este método põe o resultado na variável out e retorna true, caso contrário,
ele põe o número zero na variável out e retorna false. Um exemplo de uso 
            típico desse método é o seguinte:


string str = "100";
if (int.TryParse(str, out int num))
{
     Console.WriteLine("{0}", num + 1);
}
else
{
    Console.WriteLine("A conversão falhou!");
}


Outro exemplo que pode ajudar a compreender este conceito é o exemplo abaixo, 
    onde temos uma função que serve para calcular a media de 3 notas de um aluno,
    e além de retornar a média deste aluno também nos "retorna" por meio de um 
    out se este aluno está aprovado ou reprovado:



double calcularMedia(float nota1, float nota2, float nota3, out String conc)
{
    float media = (nota1 + nota2 + nota3) / 3;
    conc = media >= 7 ? "aprovado" : "reprovado";
    return media;
}



String conceito;
double mediaDoAluno = Program.calcularMedia(1.6, 9.4, 5.0, out conceito);
Console.WriteLine("A media é " + mediaDoAluno + " e o aluno está " + conceito);





class ParametroPadrao
{
    public static int Somar(int a = 1, int b = 1)
    { //Valor padrão
        return a + b;
    }

    public static void Executar()
    {
        Console.WriteLine(Somar(10, 23));
        Console.WriteLine(Somar(50));
        Console.WriteLine(Somar());
        Console.WriteLine(Somar(b: 7)); // parâmetro nomeado, neste caso retorna 8
    }
}


/// COLEÇÔES
///


class ColecoesArray
{
    public static void Executar()
    {
        string[] alunos = new string[5]; ///Array só pode ter um tipo de estrutura dentro
                                         ///somente string, int, char etc.
                                         ///array é indexado, homogeneo, 
                                         ///estático e com tamanho fixo
        alunos[0] = "Anderson";
        alunos[1] = "Bia";
        alunos[2] = "Carlos";
        alunos[3] = "Daniela";
        alunos[4] = "Emanuel";

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        double somatorio = 0;
        double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

        foreach (var nota in notas)
        {
            somatorio += nota;
        }

        //for(int i = 0; i < notas.Length; i++) {
        //    somatorio += notas[i];
        //}

        double media = somatorio / notas.Length;
        Console.WriteLine(media);

        char[] letras = { 'A', 'r', 'r', 'a', 'y' };
        string palavra = new string(letras);
        Console.WriteLine(palavra);
    }
}



public class Produto
{
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public override bool Equals(object obj)
    {
        var produto = obj as Produto;
        return produto != null &&
               Nome == produto.Nome &&
               Preco == produto.Preco;
    }

    public override int GetHashCode()
    {
        var hashCode = -347481536;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
        hashCode = hashCode * -1521134295 + Preco.GetHashCode();
        return hashCode;
    }
}

class ColecoesList //list é dinâmico
{
    public static void Executar()
    {
        var livro = new Produto("Game of Throne", 49.9);

        var carrinho = new List<Produto>();
        carrinho.Add(livro);

        var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

        carrinho.AddRange(combo);
        Console.WriteLine(carrinho.Count);
        carrinho.RemoveAt(3); // remove o valor do indice 3

        foreach (var item in carrinho)
        {
            Console.Write(carrinho.IndexOf(item));
            Console.WriteLine($" {item.Nome} {item.Preco}");
        }

        Console.WriteLine(carrinho.Count);
        carrinho.Add(livro); // vai acrescentar mais 1 livro na quiantidade
        Console.WriteLine(carrinho.LastIndexOf(livro));
    }
}




class ColecoesArrayList
{
    public static void Executar()
    { //evitar esse tipo de estrutura
        var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

        arraylist.Add(3.14);
        //arraylist.Count

        foreach (var item in arraylist)
        {
            Console.WriteLine("{0} => {1}", item, item.GetType());
        }
    }
}




class ColecoesSet
{
    public static void Executar()
    {
        var livro = new Produto("Game of Throne", 49.9);

        var carrinho = new HashSet<Produto>(); // HashSet não é indexado e
                                               // não aceita repetição, duplicação
        carrinho.Add(livro);

        var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

        carrinho.UnionWith(combo);// Altera o carrinho
        Console.WriteLine(carrinho.Count);
        // carrinho.RemoveAt(3);

        foreach (var item in carrinho)
        {
            // Console.Write(carrinho.IndexOf(item));
            Console.WriteLine($" {item.Nome} {item.Preco}");
        }

        Console.WriteLine(carrinho.Count);
        carrinho.Add(livro);
        Console.WriteLine(carrinho.Count);
        // Console.WriteLine(carrinho.LastIndexOf(livro));
    }
}




using System;
using System.Collections;
using System.Collections.Generic; // usar

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); //   <string>  isso é um generics

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // Peek pega o intem da lista sem remover
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // desinfileirar
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);             /// fila dinâmica
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); // i minúsculo
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}





class Igualdade
{
    public static void Executar()
    {
        var p1 = new Produto("Caneta", 1.89);
        var p2 = new Produto("Caneta", 1.89);// outro local de memória
        var p3 = p2;

        Console.WriteLine(p1 == p2);
        Console.WriteLine(p3 == p2);

        Console.WriteLine(p1.Equals(p2)); // comparador
    }
}





class ColecoesStack
{
    public static void Executar()
    {
        var pilha = new Stack();

        pilha.Push(3);
        pilha.Push("a");
        pilha.Push(true);
        pilha.Push(3.14f);

        foreach (var item in pilha)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine($"\nPop: {pilha.Pop()}"); // exibe com remoção 
        foreach (var item in pilha)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine($"\nPeek: {pilha.Peek()}"); // exibe sem remoção da fila
        Console.WriteLine(pilha.Count);
    }
}





class ColecoesDictionary
{
    public static void Executar()
    {
        var filmes = new Dictionary<int, string>();

        filmes.Add(2000, "Gladiador");
        filmes.Add(2002, "Homem-Aranha");
        filmes.Add(2004, "Os Incríveis");
        filmes.Add(2006, "O Grande Truque");

        if (filmes.ContainsKey(2004))
        {
            Console.WriteLine("2004: " + filmes[2004]);
            Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
        }

        Console.WriteLine(filmes.ContainsValue("Amnésia"));

        Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

        filmes.TryGetValue(2016, out string filme2006);
        Console.WriteLine($"Filme {filme2006}!");

        foreach (var chave in filmes.Keys)
        { // percorrer chave
            Console.WriteLine(chave);
        }

        foreach (var valor in filmes.Values)
        { // percorrer valor
            Console.WriteLine(valor);
        }

        foreach (KeyValuePair<int, string> filme in filmes)
        {
            Console.WriteLine($"{filme.Value} é de {filme.Key}.");
        }

        foreach (var filme in filmes)
        {
            Console.WriteLine($"{filme.Value} é de {filme.Key}.");
        }
    }
}




////////// Orinetação a Objeto



public class Carro
{
    protected readonly int VelocidadeMaxima; // readonly para manter fixa a informação
    int VelocidadeAtual;

    public Carro(int velocidadeMaxima)
    {
        VelocidadeMaxima = velocidadeMaxima;
    }

    protected int AlterarVelocidade(int delta)
    { //Protected para ocultar do usuário
        int novaVelocidade = VelocidadeAtual + delta;

        if (novaVelocidade < 0)
        {      //limitar erros na correção da nova velocidade
            VelocidadeAtual = 0;
        }
        else if (novaVelocidade > VelocidadeMaxima)
        {
            VelocidadeAtual = VelocidadeMaxima;
        }
        else
        {
            VelocidadeAtual = novaVelocidade;
        }

        return VelocidadeAtual;
    }


    // aceleração e frenagem padrão, pode ser alterado se por "virtual"
    public virtual int Acelerar()
    {
        return AlterarVelocidade(5); // velocidada será alterada de 5 em 5
    }

    public int Frear()
    {
        return AlterarVelocidade(-5); // velocidada será alterada de 5 em 5
    }
}




public class Uno : Carro
{
    public Uno() : base(200)
    {
        // sem construtor padrão usar  :  e acrescentar informação
    }
}



public class Ferrari : Carro
{
    public Ferrari() : base(350)
    {

    }

    public override int Acelerar()
    {
        //override sobrescrever um método já definido para este caso
        // Ferrari tem aceleração mais rápida que o Uno
        return AlterarVelocidade(15);
        //pode ser alterado se por "virtual" no método padrão
        //public     virtual     int Acelerar()
    }



    public new int Frear()
    // new vai ocultar o método da classe Pai,
    // é uma outra forma de se fazer a ideia acima,
    // mas tem diferença de comprtamento. Polimorfismo
    {
        return AlterarVelocidade(-15);
    }
}

class Heranca
{
    public static void Executar()
    {
        Console.WriteLine("Uno...");
        Uno carro1 = new Uno();
        Console.WriteLine(carro1.Acelerar());
        Console.WriteLine(carro1.Acelerar());
        Console.WriteLine(carro1.Frear());
        Console.WriteLine(carro1.Frear());
        Console.WriteLine(carro1.Frear());

        Console.WriteLine("Ferrari...");
        Ferrari carro2 = new Ferrari();
        Console.WriteLine(carro2.Acelerar());
        Console.WriteLine(carro2.Acelerar());
        Console.WriteLine(carro2.Frear());
        Console.WriteLine(carro2.Frear());
        Console.WriteLine(carro2.Frear());

        Console.WriteLine("Ferrari com tipo Carro...");
        Carro carro3 = new Ferrari();// Polimorfismo
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());

        Console.WriteLine("Uno com tipo Carro...");
        carro3 = new Uno(); // Polimorfismo
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Acelerar());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());
        Console.WriteLine(carro3.Frear());
    }
}








namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max.ToString());
        }
    }
}



////   ******** ENCAPSULAMENTO ver aula 82
///


namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // herança
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511999999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica); // é possível acessar, ainda está dentro da mesma classe
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}





namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            // Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            // Console.WriteLine(amiga.SegredoFamilia);
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
}




namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            // Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}



//////////
///


public class FilhoNaoReconhecido : SubCelebridade
{
    public new void MeusAcessos()
    {
        Console.WriteLine("FilhoNaoReconhecido...");

        Console.WriteLine(InfoPublica);
        Console.WriteLine(CorDoOlho);
        // Console.WriteLine(NumeroCelular);
        Console.WriteLine(JeitoDeFalar);
        // Console.WriteLine(SegredoFamilia);
        // Console.WriteLine(UsaMuitoPhotoshop);
    }
}

public class AmigoDistante
{
    public readonly SubCelebridade amiga = new SubCelebridade();

    public void MeusAcessos()
    {
        Console.WriteLine("AmigoDistante...");

        Console.WriteLine(amiga.InfoPublica);
        //Console.WriteLine(amiga.CorDoOlho);
        //Console.WriteLine(amiga.NumeroCelular);
        //Console.WriteLine(amiga.JeitoDeFalar);
        //Console.WriteLine(amiga.SegredoFamilia);
        //Console.WriteLine(amiga.UsaMuitoPhotoshop);
    }
}

class Encapsulamento
{
    public static void Executar()
    {
        SubCelebridade sub = new SubCelebridade();
        sub.MeusAcessos();

        new FilhoReconhecido().MeusAcessos();
        new AmigoProximo().MeusAcessos();

        new FilhoNaoReconhecido().MeusAcessos();
        new AmigoDistante().MeusAcessos();
    }
}








public class Comida
{
    public double Peso;

    public Comida(double peso)
    {
        Peso = peso;
    }

    public Comida() { }
}

public class Feijao : Comida
{
    public Feijao(double peso) : base(peso) { }
}

public class Arroz : Comida
{

}

public class Carne : Comida
{

}

public class Pessoa
{
    public double Peso;

    //public void Comer(Feijao feijao) {
    //    Peso += feijao.Peso;
    //}

    //public void Comer(Arroz arroz) {
    //    Peso += arroz.Peso;
    //}

    //public void Comer(Carne carne) {
    //    Peso += carne.Peso;
    //}

    public void Comer(Comida comida)
    {
        Peso += comida.Peso;
    }
}

class Polimorfismo
{
    public static void Executar()
    {
        Feijao ingrediente1 = new Feijao(0.3);

        Arroz ingrediente2 = new Arroz();
        ingrediente2.Peso = 0.25;

        Carne ingrediente3 = new Carne();
        ingrediente3.Peso = 0.3;

        Pessoa cliente = new Pessoa();
        cliente.Peso = 80.2;
        cliente.Comer(ingrediente1);
        cliente.Comer(ingrediente2);
        cliente.Comer(ingrediente3);

        Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}Kg!");
    }
}









public abstract class Celular
{
    public abstract string Assistente(); // cria uma classe abstrata, serve para ser
                                         // herdado
                                         // não instaciar

    public string Tocar()
    {
        return "Trim trim trim...";
    }
}

public class Samsung : Celular // cria uma classe concreta, instanciar aqui
{
    public override string Assistente()    
    {
        return "Olá! Meu nome é Bixby!";
    }
}

public class IPhone : Celular
{
    public override string Assistente()
    {
        return "Olá! Meu nome é Siri!";
    }
}

class Abstract
{
    public static void Executar()
    {
        var celulares = new List<Celular> {
                new IPhone(),
                new Samsung()
            };

        foreach (var celular in celulares)
        {
            Console.WriteLine(celular.Assistente());
        }
    }
}










interface OperacaoBinaria
{
    int Operacao(int a, int b);
}

class Soma : OperacaoBinaria
{
    public int Operacao(int a, int b)
    {
        return a + b;
    }
}

class Subtracao : OperacaoBinaria
{
    public int Operacao(int a, int b)
    {
        return a - b;
    }
}

class Multiplicacao : OperacaoBinaria
{
    public int Operacao(int a, int b)
    {
        return a * b;
    }
}

class Calculadora
{
    List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

    public string ExecutarOperacoes(int a, int b)
    {
        string resultado = "";

        foreach (var op in operacoes)
        {
            resultado +=
                $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
        }

        return resultado;
    }
}

class Interface
{
    public static void Executar()
    {
        var calc = new Calculadora();
        var resultado = calc.ExecutarOperacoes(20, 5);
        Console.WriteLine(resultado);
    }
}








sealed class SemFilho
{
    public double ValorDaFortuna()
    {
        return 1_407_033.65;
    }
}

//class SouFilho : SemFilho {

//}

class Avo
{
    public virtual bool HonrarNomeFamilia()
    {
        return true;
    }
}

class Pai : Avo
{
    public override sealed bool HonrarNomeFamilia()
    {
        return true;
    }
}

class FilhoRebelde : Pai
{
    //public override bool HonrarNomeFamilia() {
    //    return false;
    //}
}

class Sealed
{
    public static void Executar()
    {
        SemFilho semFilho = new SemFilho();
        Console.WriteLine(semFilho.ValorDaFortuna());

        FilhoRebelde filho = new FilhoRebelde();
        Console.WriteLine(filho.HonrarNomeFamilia());
    }
}






//////////////////////////////// métodos e funções
///





namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda // lambda é uma função anônima
    {
        public static void Executar()
        {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}






















































































































































































































































