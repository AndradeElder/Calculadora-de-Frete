

internal class Program
{
    private static void Main()
    {
        // receba a distância entre o distribuidor e o local de entrega e calcule o valor do frete
        
        
        Console.WriteLine("===================================================================");
        Console.WriteLine("====================== Calculadora de Frete =======================");
        Console.WriteLine("=================================================================== \n");


        Console.WriteLine("Digite a distancia entre o distribuidor e o local de entrega");
        double Distancia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o peso do material.");
        double Peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n");
        Console.WriteLine("===================================================================");
        Console.WriteLine("\n");


        double ValorFrete = CalculoValor(Distancia);

        ValorFrete = CalcularValorPeso(ValorFrete, Peso);

        Console.WriteLine($"O valor do frete é: R$ {ValorFrete}");
        

        // para km é cobrado R$ 0,10 
        // A cada 200 km, deve adicionar uma taxa de R$ 1,00
        // A cada 1000 km, deve adicionar uma taxa de R$ 10,00
        static double CalculoValor(double Distancia)
        {

            double ValorFrete = Distancia * 0.10;
            ValorFrete += Distancia / 200 * 1.00;
            ValorFrete += Distancia / 1000 * 10.00;

            return ValorFrete;
        }

        // Agora precisamos calcular o frete baseado no peso da encomenda
        // O valor do frete não altera para produtos com até 5kg
        // Multiplicar o valor do frete para produtos entre 5kg até 25kg em 5x
        // Multiplicar o valor do frete para produtos entre 25kg até 75kg em 3x

        static double CalcularValorPeso(double ValorFrete, double Peso)
        {
            
            if (Peso > 5 && Peso <= 25)
            {
                ValorFrete *= 5;
            }
            else if (Peso > 25 && Peso <= 75)
            {
                ValorFrete *= 3;
            }

            return ValorFrete;
        }


    }
}

