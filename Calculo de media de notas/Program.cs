namespace CalcularMedias { 
class MediaNota
{

    static void Main()
    {
        float media;
        Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");
        Console.WriteLine("Irei auxiliar você a calcular a média do seu aluno!");
        Console.WriteLine("Digite a primeira nota: ");

        float.TryParse(Console.ReadLine(), out float nota1);
        Console.WriteLine("Digite a segunda nota: ");
        float.TryParse(Console.ReadLine(), out float nota2);
        Console.WriteLine("Digite a terceira nota: ");
        float.TryParse(Console.ReadLine(), out float nota3);
        
        media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("A média do aluno é: " + media);
        if (media < 7)
        {
            Console.WriteLine("\n\tAluno está em recuperação");
        }
        else
        {
            Console.WriteLine("\n\tAluno aprovado");
        }
    }
}
}