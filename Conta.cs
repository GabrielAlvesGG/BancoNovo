using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banconovo
{
    public class Conta
    {   
        /* ============== Propriedades da class Conta=============*/
        public int idConta{get;set;}
        public int agencia{get;set;}

        public double numeroConta{get;set;}

        public double poupanca{get;set;}

        public double saldo {get;set;}
        public Titular titular {get;set;}
        /* ============== Propriedades da class Conta=============*/
        /* ============== Método de Depósito em saldo =====================*/
        public void DepositoSaldo (double valor){
            saldo += valor;
        }
        /* ============== Método de Depósito em saldo =====================*/
        /* ============== Método de Depósito em Poupança =====================*/
        public void DepositoPoupanca(double valorPoupanca){
            poupanca += valorPoupanca;
        }
        /* ============== Método de Depósito em Poupança =====================*/
        public double Saque(double valorSaque){
            saldo -= valorSaque * 0.5 /100;

            return saldo;
        }
        /* ============== Método de Depósito em Poupança =====================*/
        /* ============== Método de String  ==================================*/
        public override string ToString()
        {   
            
            return 
            
            "\n Agência: " + agencia + 
            "\n Numero da Conta: " + numeroConta + 
            "\n Saldo Conta Corrente: R$" + saldo +
            "\n Saldo Conta Poupança: R$" + poupanca;
        }
    }
    /* ============== Método de String =======================================*/
}