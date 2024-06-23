using Microsoft.Data.SqlClient;


namespace ProvaExperimentalForms.DataBase
{
    public class Connection
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CadastroListagemDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False            \r\n            ";
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CadastroListagemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False            

        public SqlConnection ObtainConnection()
        {
            return new SqlConnection(connectionString);
        }
        
    }
}
