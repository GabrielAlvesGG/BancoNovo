using System;
using System.Collections.Generic;

namespace banconovo
{
    class Program
    {
        static void Main(string[] args)
        {   
            char continuar = 's';

            while (continuar == 's' || continuar == 'S')
            {
            BancoRepository br = new BancoRepository();
            Console.Clear();
            Console.WriteLine("Bem-vindos ao Banco Novo!");
            Console.WriteLine("Digite a opção desejada a baixo: ");
            Console.WriteLine("1- Cadastrar um novo titular.");
            Console.WriteLine("2- Cadastrar uma nova conta.");
            Console.WriteLine("3- Cadastrar um títular e uma conta.");
            Console.WriteLine("4- Fazer um depósito na conta corrente.");
            Console.WriteLine("5- Fazer um depósito na poupança");
            Console.WriteLine("6- Listar todos os titulares.");
            Console.WriteLine("7- Listar todos as contas.");
            Console.WriteLine("8- Listar titulares e contas.");
            Console.WriteLine("9- Digite o cpf do titular para verificar conta.");
            int comando = int.Parse(Console.ReadLine());
            Titular titular = new Titular();
            Conta conta = new Conta();
            switch (comando)
            {
                case 1:
                /*========================== Cadastro do Títular =========================*/
            br.TestaConexao();
            
            Console.WriteLine("\nDigite as informações do funcionários");
            Console.WriteLine("DIgite o nome do Titular: ");
            titular.nome = Console.ReadLine();

            Console.WriteLine("\nDigite o cpf do Títular: ");
            titular.cpf = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a data de nascimento do Títular:  dd/mm/aaaa" );
            titular.dataNascimento =Console.ReadLine();
            br.insertTitular(titular);

            /*========================== Cadastro do Títular =========================*/
            break;
            case 2 :
                 /*========================== Cadastro da Conta   =========================*/
            
            Console.WriteLine("\nDigite o numero da Agência: ");
            conta.agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o numero da Conta ");
            conta.numeroConta = double.Parse(Console.ReadLine());
            br.InsertConta(conta);
            /*========================== Cadastro da Conta   =========================*/
            break;
            case 3 :
               /*========================== Cadastro do Títular =========================*/
            br.TestaConexao();
           
            Console.WriteLine("\nDigite as informações do funcionários");
            Console.WriteLine("DIgite o nome do Titular: ");
            titular.nome = Console.ReadLine();

            Console.WriteLine("\nDigite o cpf do Títular: ");
            titular.cpf = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a data de nascimento do Títular:  dd/mm/aaaa" );
            titular.dataNascimento =Console.ReadLine();
            br.insertTitular(titular);
            /*========================== Cadastro do Títular =========================*/
                 /*========================== Cadastro da Conta   =========================*/
            
            Console.WriteLine("\nDigite o numero da Agência: ");
            conta.agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o numero da Conta ");
            conta.numeroConta = double.Parse(Console.ReadLine());
            br.InsertConta(conta);
            /*========================== Cadastro da Conta   =========================*/
            break;
            case 4:
            /*========================== Depositos inicial  =========================*/
            Console.WriteLine("\n Depósito na conta corrente:  s/n ");
            char s = char.Parse(Console.ReadLine());
            if(s == 's'){
                Console.WriteLine("Digite o valor do primeiro depósito");
                double saldo = double.Parse(Console.ReadLine());
                conta.DepositoSaldo(saldo);
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Status do saldo no momento");
                Console.WriteLine("Saldo : R$" + conta.saldo);
                Console.ReadLine();
            }
            break;
            /*========================== Depositos inicial  =========================*/
            case 5:
            /*========================== Depositos inicial Poupança =========================*/
                 Console.WriteLine("\n Depósito na conta poupança:  s/n ");
            char poupa = char.Parse(Console.ReadLine());
            if(poupa == 's'){
                Console.WriteLine("Digite o valor do primeiro depósito");
                double saldo = double.Parse(Console.ReadLine());
                conta.DepositoPoupanca(saldo);
                Console.ReadLine();

            }
            else{
                Console.WriteLine("Status do saldo no momento");
                Console.WriteLine("Saldo : R$" + conta.poupanca);
                Console.ReadLine();
            }
            /*========================== Depositos inicial  poupança =========================*/

            break;
            case 6: 
           
            break;
            case 7:
             List<Conta> listaConta = br.ListarContas();
            foreach(Conta item in listaConta){
                Console.WriteLine(item);
            }
            break;
            case 8:


              List<Titular> listaTitular= br.ListaTitular();
            foreach (Titular item in listaTitular)
            {
                Console.WriteLine(item);
            }

             List<Conta> listaCont = br.ListarContas();
            foreach(Conta item in listaCont){
                Console.WriteLine(item);
            }
            break;
            case 9:
            Console.WriteLine("Digite o cpf do titular");
            titular.id = int.Parse(Console.ReadLine());
            titular = br.BuscarTitular(titular.id);
            Console.WriteLine("Id do Titular:" + titular.id);
            Console.WriteLine("Nome do Titular:" + titular.nome);
            Console.WriteLine("Data de nascimento:" + titular.dataNascimento);
            Console.WriteLine("Cpf do Titular:" + titular.cpf);
            break;
                default:
                Console.WriteLine("Comando invalido!!");
                break;
        
        }
        Console.WriteLine("Deseja Continuar ? (S/N)");
        continuar = char.Parse(Console.ReadLine());
            }
      
        
    }
}
}
