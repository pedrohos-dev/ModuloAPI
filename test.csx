using Oracle.ManagedDataAccess.Client;

string constr = ";";

using (OracleConnection con = new OracleConnection(constr))
{
    try
    {
        con.Open();
        Console.WriteLine("Conexao bem-sucedida!");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro: " + ex.Message);
    }
}