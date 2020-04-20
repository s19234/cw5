using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Ćwiczenia_5.DTO_s.Request;
using Ćwiczenia_5.Models;

namespace Ćwiczenia_5.Services
{
    public class SqlServerStudentDbService : IStudentDbService
    {
        public SqlServerStudentDbService() { }

        public void EnrollStudent(EnrollStudentRequest request)
        {
            var st = new Student();
            st.FirstName = request.FirstName;

            using (var con = new SqlConnection(""))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                con.Open();

                var tran = con.BeginTransaction();

                try
                {
                    com.CommandText = "SELECT IdStudies FROM studies WHERE name=@name";
                    com.Parameters.AddWithValue("name", request.Studies);

                    var dr = com.ExecuteReader();
                    if (!dr.Read())
                        tran.Rollback();

                    int idstudies = (int)dr["studies"];

                    com.CommandText = "INSERT INTO Student(IndexNumber, FirstName) VALUES(@Index, @Fname)";
                    com.Parameters.AddWithValue("index", request.IndexNumber);

                    com.ExecuteNonQuery();
                    tran.Commit();
                }
                catch(SqlException exc)
                {
                    tran.Rollback();
                }
            }
        }

        public void PromoteStudent(int semester, string studies)
        {
            throw new NotImplementedException();
        }
    }
}
