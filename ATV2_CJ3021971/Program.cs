namespace ATV2_CJ3021971
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Digite seu salário: ");
            int salario = int.Parse(Console.ReadLine());
            float salariob = ((salario / 100) * 25) + salario;
            Console.WriteLine("O salario após reajuste é igual a: {0}", salariob);

            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = (n1 * 3 + 1) + (n1 * 2 - 1);
            Console.WriteLine("{0}", n2);

            Console.WriteLine("Exercicio 3");
            int patrimonio = 1000;
            Console.WriteLine("Qual a diferença percentual do primeiro dia?: ");
            float dia1 = float.Parse(Console.ReadLine());
            float patrimonio1 = ((patrimonio / 100) * dia1) + patrimonio;
            Console.WriteLine("Após o primeiro dia o patrimonio é igual a {0}", patrimonio1);
            Console.WriteLine("Qual a diferença percentual após o segundo dia: ");
            float dia2 = float.Parse(Console.ReadLine());
            float patrimonio2 = ((patrimonio1 / 100) * dia2) + patrimonio1;
            Console.WriteLine("Após o segundo dia o patrimonio é igual a {0}", patrimonio2);
            Console.WriteLine("Qual a diferenca percentual do terceiro dia: ");
            float dia3 = float.Parse(Console.ReadLine());
            float patrimonio3 = ((patrimonio2 / 100) * dia3) + patrimonio2;
            Console.WriteLine("Após o terceiro dia o patrimonio é igual a {0}", patrimonio3);
            Console.WriteLine("Qual a diferenca percentual do quarto dia: ");
            float dia4 = float.Parse(Console.ReadLine());
            float patrimonio4 = ((patrimonio3 / 100) * dia4) + patrimonio3;
            Console.WriteLine("O resultado final do investimento é igual a {0}", patrimonio4);


            
             

        }
    }
}
