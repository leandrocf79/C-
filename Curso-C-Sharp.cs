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































