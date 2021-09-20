using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace TrabajoB {
    class BD {

        public static void Conectar(){ 
            string cnnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Personal\source\repos\TrabajoB\TrabajoB\BaseDatos.mdf;Integrated Security=True";
    
            SqlCommand cmdSelect = null;
            SqlDataReader dr = null;

            try{ 
                using(SqlConnection cnn = new SqlConnection(cnnStr)){ 
                    cnn.Open();

                    Debug.WriteLine("Conectado...");

                    cmdSelect = new SqlCommand("Select * from clientes", cnn);

                    dr = cmdSelect.ExecuteReader();

                    while(dr.Read()){ 
                        Debug.WriteLine("Id " + dr.GetInt32(0) + " Nombre " +  dr["Nombre"].ToString() + 
                                        "Clave " + dr["Clave"].ToString());
                    
                    }
                    dr.Close();

                    Console.Write("Ing. id que desea modificar : ");
                    int id = int.Parse(Console.ReadLine());

                    //Actualizar sin parámetros
                    SqlCommand cmdUpdate = new SqlCommand("Update clientes set clave = 9999 where id = " + id, cnn);

                    //Actualizar con parámetros
                    SqlCommand cmdDeleteParametros = new SqlCommand("Delete from clientes where id = @pid", cnn);
                    cmdDeleteParametros.Parameters.Add("pid",System.Data.SqlDbType.Int).Value = id;


                    Debug.WriteLine("Registros actualizados -> " + cmdUpdate.ExecuteNonQuery());
                    Debug.WriteLine("Registros eliminados -> " + cmdDeleteParametros.ExecuteNonQuery());
                }
            }catch(Exception ex){ 
                Debug.WriteLine("Error en la conexión " + ex.ToString());
            } finally{ 
                cmdSelect.Dispose();
                dr.Close();
            }
        }

    }
	
	Akashic Records of Bastard Magical Instructor Episodio 1 – Un inútil sin motivación
}
