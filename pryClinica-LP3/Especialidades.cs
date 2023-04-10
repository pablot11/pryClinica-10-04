using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace pryClinica_LP3
{
    internal class Especialidades
    {
        private string cadena = "provider=microsoft.jet.oledb.4.0;data source=CLINICA.mdb";
        private OleDbConnection conector;
        private OleDbCommand comando; //Envia el comando a la base de datos
        private OleDbDataAdapter adaptador; //Da la orden de hacer las acciones del comando
        private DataTable tabla;

        //Constructor
        public Especialidades()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=CLINICA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            //Configuramos el comando
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Especialidades";
            //El adaptador se conecta al comando
            adaptador = new OleDbDataAdapter(comando);
            //      
            tabla = new DataTable();
            //
            adaptador.Fill(tabla);
        }
        public DataTable getAll()
        {
            return tabla;
        }
            






    }
}
