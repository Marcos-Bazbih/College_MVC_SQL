using College_MVC_SQL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace College_MVC_SQL.Controllers.api
{
    public class TeacherController : ApiController
    {
        string connectionString = "Data Source=LENOVO-MARCOS;Initial Catalog=CollegeDb;Integrated Security=True;Pooling=False";



        // GET api/<controller>
        //public IHttpActionResult Get()
        //{
        //    List<Teacher> teachersList = new List<Teacher>();

        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            string query = $@"SELECT * FROM Teachers";

        //            SqlCommand command = new SqlCommand(query, connection);

        //            SqlDataReader dataFromDB = command.ExecuteReader();

        //            if (dataFromDB.HasRows)
        //            {
        //                while (dataFromDB.Read())
        //                {
        //                    teachersList.Add(new Teacher(
        //                            dataFromDB.GetString(1),
        //                            dataFromDB.GetString(2),
        //                            dataFromDB.GetString(3),
        //                            dataFromDB.GetString(4),
        //                            dataFromDB.GetInt32(5)
        //                        ));
        //                }
        //                return Ok(new { teachersList });
        //            }
        //            connection.Close();
        //            return Ok(new { massage = "no teachers found, sorry" });
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //}

        // GET api/<controller>/5
        //public IHttpActionResult Get(int id)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            string query = $@"SELECT * FROM Teachers WHERE Id={id}";
        //            SqlCommand command = new SqlCommand(query, connection);

        //            SqlDataReader dataFromDB = command.ExecuteReader();

        //            if (dataFromDB.HasRows)
        //            {
        //                while (dataFromDB.Read())
        //                {
        //                    Teacher teacher1 = new Teacher(dataFromDB.GetString(1), dataFromDB.GetString(2), dataFromDB.GetString(3), dataFromDB.GetString(4), dataFromDB.GetInt32(5));
        //                    return Ok(new { teacher1 });
        //                }
        //            }
        //            connection.Close();
        //            return Ok(new { massage = "no teachers found" });
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //}

        // POST api/<controller>
        //public IHttpActionResult Post([FromBody] Teacher value)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            string query = $@"INSERT INTO Teachers (FirstName, LastName, Domain, Email, Salary)
        //                              VALUES('{value.firstName}', '{value.lastName}', '{value.domain}',
        //                              '{value.email}', {value.salary})";

        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.ExecuteNonQuery();

        //            connection.Close();
        //            return Ok(new { massage = "teacher added" });
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //}

        // PUT api/<controller>/5
        //public IHttpActionResult Put(int id, [FromBody] Teacher value)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            string query = $@"UPDATE Teachers SET FirstName = '{value.firstName}',
        //                                                 LastName = '{value.lastName}',
        //                                                 Domain = '{value.domain}',
        //                                                 Email = '{value.email}',
        //                                                 Salary = {value.salary}
        //                                             WHERE Id = {id}";

        //            SqlCommand cmd = new SqlCommand(query, connection);
        //            cmd.ExecuteNonQuery();

        //            connection.Close();

        //            return Ok(new { massage = "teacher updated" });
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //}

        // DELETE api/<controller>/5
        //public IHttpActionResult Delete(int id)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            string query = $@"DELETE FROM Teachers WHERE Id={id}";

        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.ExecuteNonQuery();

        //            connection.Close();
        //            return Ok(new { massage = "student deleted" });
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        return Ok(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Ok(ex.Message);
        //    }

        //}
    }
}