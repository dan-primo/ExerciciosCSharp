﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoJoao = new ContaCorrente();

            contaDoJoao.titular = "João";

            Console.WriteLine(contaDoJoao.saldo);

            bool resultadoSaque = contaDoJoao.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoJoao.saldo);
            
            contaDoJoao.Depositar(500);
            Console.WriteLine(contaDoJoao.saldo);

            ContaCorrente contaDaMaria = new ContaCorrente();

            contaDaMaria.titular = "Maria";

            Console.WriteLine("Saldo Atualizado João: " + contaDoJoao.saldo);
            Console.WriteLine("Saldo Atualizado Maria: " + contaDaMaria.saldo);

           bool resultadoTransferencia = contaDoJoao.Transferir(200, contaDaMaria);

            Console.WriteLine("Saldo Atualizado João: " + contaDoJoao.saldo);
            Console.WriteLine("Saldo Atualizado Maria: " + contaDaMaria.saldo);

            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
