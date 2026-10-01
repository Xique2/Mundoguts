using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Hotel.UI.DAL
{
    public class DAL
    {


      
        



            public void CADASTRAUSER(ObjUsuario user)
            {
                string sql = $"INSERT INTO TbUsuario (NomeUsuario,SenhaHash )VALUES (@USER,@SENHA)";
                SqlConnection conn = new("Server=tcp:cmg-sql-dev-phl2026.database.windows.net,1433;Initial Catalog=SIGE_DB;Persist Security Info=False;User ID=dbadmin_sige;Password=Mundo@2026#Fund1X;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conn.Open();
                SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@USER", user.USUARIO);
                cmd.Parameters.AddWithValue("@SENHA", user.SENHA);
                cmd.ExecuteNonQuery();
            //CONfERIDO 
            }
            public void DELETEUSE(ObjUsuario user)
            {

                string sql = $"DELETE FROM TbUsuario WHERE IdUsuario = @USER";
                SqlConnection conn = new("Server=tcp:cmg-sql-dev-phl2026.database.windows.net,1433;Initial Catalog=SIGE_DB;Persist Security Info=False;User ID=dbadmin_sige;Password=Mundo@2026#Fund1X;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conn.Open();
                SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@USER", user.IDUSUARIO);
                  cmd.ExecuteNonQuery();
            //CONfERIDO
            }
            public void UPDATEUSER(ObjUsuario user)
            {
                SqlConnection conn = new("Server=tcp:cmg-sql-dev-phl2026.database.windows.net,1433;Initial Catalog=SIGE_DB;Persist Security Info=False;User ID=dbadmin_sige;Password=Mundo@2026#Fund1X;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conn.Open();
            string sql = "UPDATE TbUsuario SET NomeUsuario=@USER, SenhaHash=@SENHA WHERE IdUsuario=@IDUSER";
            SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@USER", user.USUARIO);
                cmd.Parameters.AddWithValue("@SENHA", user.SENHA);
                cmd.Parameters.AddWithValue("@IDUSER", user.IDUSUARIO);
                cmd.ExecuteNonQuery();
            //CONfERIDO
            }
            public void BUSCARUSER(ObjUsuario user)
            {
                List<ObjUsuario> LISTAUSER = new();
                SqlConnection conn = new("Server=tcp:cmg-sql-dev-phl2026.database.windows.net,1433;Initial Catalog=SIGE_DB;Persist Security Info=False;User ID=dbadmin_sige;Password=Mundo@2026#Fund1X;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conn.Open();
                string sql = $"SELECT * FROM TbUsuario WHERE IdUsuario = @IDUSER";
                SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@IDUSER", user.IDUSUARIO);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                  LISTAUSER.Add(new ObjUsuario
                  {
                    USUARIO = dr["NomeUsuario"].ToString(),
                    SENHA = dr["SenhaHash"].ToString(),


                  });
                
                }

            }
         













































            
        

    }
}