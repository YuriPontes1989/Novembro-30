using System;
using System.Collections.Generic;
using System.Globalization;

namespace ContaBancaria_Classe_Abstratas_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista de contas
            List<Conta> list = new List<Conta>();

            //Populando a lista com as contas
            list.Add(new Poupanca(1001, "Rose", 500.0, 0.01));
            list.Add(new Juridica(1002, "Liza", 500.0, 400.0));
            list.Add(new Poupanca(1003, "Jisoo", 500.0, 0.01));
            list.Add(new Juridica(1004, "Jennie", 500.0, 400.0));

            double sum = 0.0;
            //Para cada conta da lista 
            foreach (Conta acc in list)
            {
                //Soma o saldo das contas 
                sum += acc.Saldo;
            }

            //Vai aparecer na tela a soma 
            Console.WriteLine("Total do saldo de todas as contas: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            //Saque do valor nas contas 
            foreach (Conta acc in list)
            {
                acc.Saque(10.0);
            }

            //Aparece na tela o valor do saldo  atualizado
            foreach (Conta acc in list)
            {
                Console.WriteLine("Atualização do saldo das contas: " + acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }

            Juridica bacc = new Juridica(1002, "Irene", 0.0, 500.0);



            Conta acc1 = bacc;
            Conta acc2 = new Juridica(1003, "Seulgi", 0.0, 500.0);
            Conta acc3 = new Poupanca(1004, "Joy", 0.0, 0.01);



            Juridica acc4 = (Juridica)acc2;
            acc4.Emprestimo(100);

            if (acc3 is Juridica)
            {
                Juridica acc5 = (Juridica)acc3;
                acc5.Emprestimo(200);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is Poupanca)
            {
                Poupanca acc5 = acc3 as Poupanca;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}