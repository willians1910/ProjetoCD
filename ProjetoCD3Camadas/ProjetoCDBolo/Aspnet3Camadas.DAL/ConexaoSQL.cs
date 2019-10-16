using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ConexaoSQL
/// </summary>
public class ConexaoSQL
{

    public ConexaoSQL()
    {
        cn = new SqlConnection();
        cmd = new SqlCommand();
        cmd.Connection = cn;
        adapter = new SqlDataAdapter();
    }

    //private string conexao = @"Data Source=SINSAON315\SQLEXPRESS;Initial Catalog=DB_TesteSinqia;User ID=sa;Password=1234"; //Teste de camadas se der mal descomenta

    protected SqlConnection cn;
    protected SqlCommand cmd;
    protected SqlDataReader reader; // modo conectado
    protected SqlDataAdapter adapter; // modo desconectado

    protected void AbrirConexao()
    {
        cn.Open();

    }

    protected void FecharConexao()
    {
        if (cn != null && cn.State == ConnectionState.Open)
        {
            cn.Close();
        }
    }
}
