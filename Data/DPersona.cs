using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DPersona
    {

     public   List<Persona> GetPersonas(Persona persona)
        {
            List<Persona> personas = new List<Persona>();
            string commandText = "USP_BuscarPersonas";
            SqlParameter[] parameters = null;


            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Nombres", SqlDbType.VarChar);
            parameters[0].Value = persona.Nombres;            
            parameters[1] = new SqlParameter("@Apellidos", SqlDbType.VarChar);
            parameters[1].Value = persona.Apellidos;

            using (SqlDataReader reader =
                                    SqlHelper.ExecuteReader(SqlHelper.Connection, commandText,
                                                             System.Data.CommandType.StoredProcedure,
                                                             parameters
                                                             ))
            {
                while (reader.Read())
                {
                    personas.Add(new Persona
                    {
                        Nombres = reader["Nombres"] != null ? Convert.ToString(reader["Nombres"]) : "",
                        Apellidos = reader["Apellidos"] != null ? Convert.ToString(reader["Apellidos"]) : "",
                        FechaNacimiento= reader["FechaNacimiento"] != null ? Convert.ToDateTime(reader["FechaNacimiento"]) : DateTime.Now,
                        FechaIngreso = reader["FechaIngreso"] != null ? Convert.ToDateTime(reader["FechaIngreso"]) : DateTime.Now

                    });
                }

            }
            return personas;
        }

     public void InsPersona(Persona persona)
        {
            string commandText = "USP_InsertarPersonas";
            SqlParameter[] parameters = null;

            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Nombres", SqlDbType.VarChar);
            parameters[0].Value = persona.Nombres;
            parameters[1] = new SqlParameter("@Apellidos", SqlDbType.VarChar);
            parameters[1].Value = persona.Apellidos;
            parameters[2] = new SqlParameter("@FechaNacimiento", SqlDbType.DateTime);
            parameters[2].Value = persona.FechaNacimiento;
            parameters[3] = new SqlParameter("@FechaIngreso", SqlDbType.VarChar);
            parameters[3].Value = persona.FechaIngreso;

            SqlHelper.EjecutarSentenciaSQL(SqlHelper.Connection, commandText,
                CommandType.StoredProcedure, parameters);

        }


    }
}
