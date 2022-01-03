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
    public class StudentController : ApiController
    {
        string connectionString = "Data Source=LENOVO-MARCOS;Initial Catalog=CollegeDb;Integrated Security=True;Pooling=False";



        // GET api/<controller>
        public IHttpActionResult Get()
        {
            List<Student> studentsList = new List<Student>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Students";

                    SqlCommand command = new SqlCommand(query, connection);

                    var dataFromDB = command.ExecuteReader();

                    if (dataFromDB.HasRows)
                    {
                        while (dataFromDB.Read())
                        {
                            studentsList.Add(new Student(
                                    dataFromDB.GetString(1),
                                    dataFromDB.GetString(2),
                                    dataFromDB.GetDateTime(3),
                                    dataFromDB.GetString(4),
                                    dataFromDB.GetInt32(5)
                                ));
                        }
                        return Ok(new { studentsList });
                    }
                    connection.Close();
                    return Ok(new { studentsList });
                }
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"SELECT * FROM Students
                                    WHERE Id={id}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataFromDB = command.ExecuteReader();
                    if (dataFromDB.HasRows)
                    {
                        while (dataFromDB.Read())
                        {
                            Student student1 = new Student(dataFromDB.GetString(1), dataFromDB.GetString(2), dataFromDB.GetDateTime(3), dataFromDB.GetString(4), dataFromDB.GetInt32(5));
                            return Ok(new { student1 });
                        }
                    }
                    connection.Close();
                    return Ok(new { massage = "no students found" });
                }
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] Student value)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"INSERT INTO Students (FirstName, LastName, Bitrhday, Email, SchoolYear)
                                      VALUES('{value.firstName}', '{value.lastName}', '{value.birthday}',
                                      '{value.email}', {value.schoolYear})";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    return Ok(new { massage = "student added" });
                }
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"UPDATE Students 
                                      SET FirstName = '{value.firstName}',
                                          LastName = '{value.lastName}',
                                          Bitrhday = '{value.birthday}',
                                          Email = '{value.email}',
                                          SchoolYear = {value.schoolYear}
                                      WHERE Id = {id}";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    return Ok(new { massage = "student updated" });
                }
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"DELETE Students WHERE Id = {id}";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    return Ok(new { massage = "student deleted" });
                }
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}