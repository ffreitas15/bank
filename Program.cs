using System;

namespace Bank_Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com o numero da conta : ");
            int conta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o titular da conta : ");
            string titular = Console.ReadLine();

            System.Console.WriteLine("Havera  depósito inicial s/n: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                System.Console.WriteLine("Entre com valor do deposito inical");
                double depositoIncial = double.Parse(Console.ReadLine());
                ban = new Banco(conta, titular, depositoIncial);
            }
            else
            {
                ban = new Banco(conta, titular);
            }


            System.Console.WriteLine(ban);

            System.Console.WriteLine("Entre e um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            ban.depósitoEmConta(quantia);
            System.Console.WriteLine("Dados da conto atualizado " + ban);

            System.Console.WriteLine("Entre o valor de saque : ");
            double saque = double.Parse(Console.ReadLine());
            ban.SaqueEmConta(quantia);
            System.Console.WriteLine("Dados da conto atualizado " + ban);
        }
    }
}
