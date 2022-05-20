using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banconovo
{
    public class Titular
    {
        public int id {get;set;}
        public string nome {get;set;}
        public double cpf {get;set;}
        public string dataNascimento {get;set;}

       
        public override String ToString(){
            return "Id Do Titular: " +
            id + 
            "\n Nome do Titular: " +
            nome + "\n Cpf: " + cpf +
            "\n Data de Nascimento: " + dataNascimento;
        }
    }

}