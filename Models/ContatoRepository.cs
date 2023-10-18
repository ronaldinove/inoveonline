using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace Atv3._1.Models
{
    public class ContatoRepository
    {
        //SERVIDOR: localhost ou 127.0.0.1
        //USER: root
        //BANCO DE DADOS: inove

        private const string DadosConexao = "Database= inove; Data Source = localhost; User Id = root;";

        public void testeConexao()
        {
            MySqlConnection conexao = new MySqlConnection (DadosConexao); //usada para iniciar conexão com base de dados
        
            conexao.Open();

            Console.WriteLine("Conectado!");

            conexao.Close();
        
        }

        //CRUD 

        //CREATE

        public void Inserir(ItemContato c)
        {
            MySqlConnection conexao = new MySqlConnection (DadosConexao);

            conexao.Open();

            string query = "INSERT INTO contatos (nome, phone, email, servico, mensagem) VALUES (@nome, @phone, @email, @servico, @mensagem)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@nome", c.nome);//verificar se precisa inserir o idContato
            comando.Parameters.AddWithValue("@phone", c.phone);
            comando.Parameters.AddWithValue("@email", c.email);
            comando.Parameters.AddWithValue("@servico", c.servico);
            comando.Parameters.AddWithValue("@mensagem", c.mensagem);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        //READ

        public List<ItemContato> Listagem ()//verificar se é o item contato
        {
            MySqlConnection conexao = new MySqlConnection (DadosConexao);

            conexao.Open();
            
            string query = "SELECT * FROM contatos";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            MySqlDataReader reader = comando.ExecuteReader();

            List<ItemContato> listaContatos = new List<ItemContato>();

            while(reader.Read())
            {
                ItemContato c = new ItemContato(); 

                c.idContato = reader.GetInt32("idContato"); 

                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                c.nome = reader.GetString("nome");

                if(!reader.IsDBNull(reader.GetOrdinal("phone")))
                c.phone = reader.GetString("phone");

                if(!reader.IsDBNull(reader.GetOrdinal("email")))
                c.email = reader.GetString("email");

                if(!reader.IsDBNull(reader.GetOrdinal("servico")))
                c.servico = reader.GetString("servico");

                if(!reader.IsDBNull(reader.GetOrdinal("mensagem")))
                c.mensagem = reader.GetString("mensagem");

                listaContatos.Add(c);

            }

            conexao.Close();

            return listaContatos;
        }

        //UPDATE
        public void Editar (ItemContato c)
        {
            MySqlConnection conexao = new MySqlConnection (DadosConexao); 
        
            conexao.Open();

            string query = "UPDATE contatos SET nome = @nome, phone = @phone, email = @email, servico = @servico, mensagem = @mensagem WHERE idContato = @idContato ";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@nome", c.nome);
            comando.Parameters.AddWithValue("@phone", c.phone);
            comando.Parameters.AddWithValue("@email", c.email);
            comando.Parameters.AddWithValue("@servico", c.servico);
            comando.Parameters.AddWithValue("@mensagem", c.mensagem);
            comando.Parameters.AddWithValue("@idContato", c.idContato);
  
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        //BUSCAR POR ID
        public ItemContato BuscarPorId(int idContato)
        {
            MySqlConnection conexao = new MySqlConnection (DadosConexao); 
                
            conexao.Open();

            string query = "SELECT * FROM contatos WHERE idContato = @idContato";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@idContato", idContato);
            
            MySqlDataReader reader = comando.ExecuteReader();

            ItemContato item = new ItemContato();

            if(reader.Read())
            {
                item.idContato = reader.GetInt32("idContato");

                if(!reader.IsDBNull(reader.GetOrdinal("nome")))
                {
                    item.nome = reader.GetString("nome");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("phone")))
                {
                    item.phone = reader.GetString("phone");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("email")))
                {
                    item.email = reader.GetString("email");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("servico")))
                {
                    item.servico = reader.GetString("servico");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("mensagem")))
                {
                    item.mensagem = reader.GetString("mensagem");
                }
            }

            conexao.Close();

            return item;
        }

        //DELETE

        public void Deletar (int idContato)
        {
            MySqlConnection conexao = new MySqlConnection (DadosConexao); 
        
            conexao.Open();

            string query = "DELETE FROM contatos WHERE idContato = @idContato";

            MySqlCommand comando = new MySqlCommand(query, conexao);
            
            comando.Parameters.AddWithValue("@idContato", idContato);

            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}