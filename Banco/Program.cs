using System;
using Banco.classes;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Cliente kaique = new Cliente();            

                var Clientekaqiue = Cliente.CreateCliente("Kaique", "Av lucrecia ranalli corsi nº20", 19997301673, "123.453.548-56", new DateTime(2003, 03, 23));
                Console.WriteLine(Clientekaqiue.ToString());
                Console.WriteLine("");
                var Clienteluiz = Cliente.CreateCliente("luiz", "rua ernesto loreto", 19997301673, "123.453.548-56", new DateTime(200, 03, 23));
                Console.WriteLine(Clienteluiz.ToString());

                Console.WriteLine("");

                Conta ContaPoupancaKaique = new Poupanca(Clientekaqiue, 12297, 1500);
                Console.WriteLine($"Saldo do kaique = R${ContaPoupancaKaique.Saldo}");
                Console.WriteLine("");
                ContaPoupancaKaique.Sacar(100);               
                ContaPoupancaKaique.Depositar(200);
                Console.WriteLine("");


                Conta ContaCorrenteLuiz = new Corrente(Clienteluiz, 12297, 100);
                Console.WriteLine($"Saldo do luiz = R${ContaCorrenteLuiz.Saldo}");
                Console.WriteLine("");
                ContaCorrenteLuiz.Sacar(10);
                ContaCorrenteLuiz.Depositar(100);
                Console.WriteLine("");

                Console.WriteLine($"Saldo do luiz = R${ContaCorrenteLuiz.Saldo}");
                Console.WriteLine($"Saldo do kaique = R${ContaPoupancaKaique.Saldo}");

                Console.WriteLine("");
                ContaPoupancaKaique.Trasferir(1000, ContaCorrenteLuiz);
                Console.WriteLine("");

                Console.WriteLine($"Saldo do luiz = R${ContaCorrenteLuiz.Saldo}");
                Console.WriteLine($"Saldo do kaique = R${ContaPoupancaKaique.Saldo}");




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
    }
}
