using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace banconovo
{
    public class BancoRepository
    {
        private const string conectaBanco = "DATABASE=banconovo;Data Source=localhost; User Id=root;";
        /*================= método Testa Conexão =====================*/
        public void TestaConexao()
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            Console.WriteLine("Conectou o banco com a aplicação");
            conexao.Close();
        }
        /*================= método Testa Conexão =====================*/
        /*================= método Inserir um novo Titular ===========*/
        public void insertTitular(Titular titular)
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "INSERT INTO titular (nome, cpf, dataNascimento ) VALUES ( '" + titular.nome + "', '" + titular.cpf + "', '" + titular.dataNascimento + "') " ;
            MySqlCommand comando = new MySqlCommand(query,conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        /*================= método Inserir um novo Titular ===========*/
        /*================== método Inserir uma nova conta ===========*/
        public void InsertConta(Conta conta){
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "INSERT INTO conta (agencia, numeroConta, poupanca, saldo ) VALUES ('" + conta.agencia + "' , '" + conta.numeroConta + "' , '" + conta.poupanca + "', '" + conta.saldo + "')";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        /*================== método Inserir uma nova Conta ===========*/
        
        /* ============= método listar Contas  ========================*/
        public List<Conta> ListarContas()
        {
            MySqlConnection conexao = new MySqlConnection(conectaBanco);
            conexao.Open();
            string query = "SELECT * FROM conta";
            MySqlCommand comando = new MySqlCommand(query,conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Conta> lista = new List<Conta>();

            while(reader.Read())
            {   
                Conta conta = new Conta();
                conta.idConta = reader.GetInt32("idConta");
                conta.agencia = reader.GetInt32("agencia");
                conta.numeroConta = reader.GetInt64("numeroConta");
                conta.saldo = reader.GetDouble("saldo");
                conta.poupanca = reader.GetDouble("poupanca");
                lista.Add(conta);
            }
            reader.Close();
            conexao.Close();
            return lista;
        }
        /*================== método lista contas =====================*/
        /*============== método listar Titular ======================*/
          public List<Titular> ListaTitular()
          {
              MySqlConnection conexao = new MySqlConnection(conectaBanco);
              conexao.Open();
              string query = "SELECT * FROM titular";
              MySqlCommand comando = new MySqlCommand(query, conexao);
              MySqlDataReader reader = comando.ExecuteReader();

              List<Titular> lista = new List<Titular>();
            
             while(reader.Read()){
                 Titular titular = new Titular();
                 titular.id = reader.GetInt16("id");
                 titular.nome = reader.GetString("nome"); 
                 titular.dataNascimento = reader.GetString("dataNascimento");
                 titular.cpf = reader.GetInt32("cpf");

                 lista.Add(titular);

             }
             reader.Close();
             conexao.Close();

             return lista;
          }
          /*==================== método Listar titulares ======================*/
          public Titular BuscarTitular(int id){

              MySqlConnection conexao = new MySqlConnection(conectaBanco);
              conexao.Open();
              string query = "SELECT * FROM titular WHERER id =" + id ;
              MySqlCommand comando = new MySqlCommand(query,conexao);
              MySqlDataReader reader = comando.ExecuteReader();
                Titular titular = null;
              if(reader.Read()){
                  titular = new Titular();
                  titular.id = reader.GetInt32("id");
                  titular.nome = reader.GetString("nome");
                  titular.dataNascimento = reader.GetString("dataNascimento");
                  titular.cpf = reader.GetDouble("cpf");
                }
            
              reader.Close();
              conexao.Close();
            return titular;
            /* ajustar daqui */
          }
    }
}