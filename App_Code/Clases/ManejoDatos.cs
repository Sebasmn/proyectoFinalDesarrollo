using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ManejoDatos
/// </summary>
public class ManejoDatos
{
    public ManejoDatos()
    {
    }
    private Connection GetConnectionString()
    {
        MySqlConnection connection;
        string server = "localhost";
        string database = "u179925486_uta2020ds4";
        string uid = "u179925486_grupo";
        string password = "jZ=4k1x3]";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        connection = new MySqlConnection(connectionString);
        return connection;
    }

    private Estudiante getEstudiante(string cedula)
    {

    }
}