//É preciso importar as bibliotecas do SQLSERVER
using System.Data;
using System.Data.SqlClient;


namespace ProjetoPOO.Services
{
    //Métodos Privado que cria nova conexão com o banco
    private SqlConnection CriarConexao()
    {
        SqlConnection conexao = new SqlConnection();

        conexao.ConnectionString = 
            "Data Source = localhost;" +
            "Initial Catalog = pooCamadas;" +
            "Integrated Security = SSPI;";
        conexao.Open();
        return conexao;
    }

    public class DataBaseSqlServer
    {
        
    }
}
