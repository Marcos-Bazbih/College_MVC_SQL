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
        static string connectionString = "Data Source=LENOVO-MARCOS;Initial Catalog=CollegeDb;Integrated Security=True;Pooling=False";
        DataClasses1DataContext collegeDataContext = new DataClasses1DataContext(connectionString);


        // GET ALL
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(collegeDataContext.Students.ToList());
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



        // GET BY ID
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(collegeDataContext.Students.First((item) => item.Id == id));
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

        // POST
        public IHttpActionResult Post([FromBody] Student value)
        {
            try
            {
                collegeDataContext.Students.InsertOnSubmit(value);
                collegeDataContext.SubmitChanges();
                return Ok("student added");
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





        // PUT 
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            try
            {
                Student update = collegeDataContext.Students.First((item) => item.Id == id);
                if (update != null)
                {
                    update.FirstName = value.FirstName;
                    update.LastName = value.LastName;
                    update.Bitrhday = value.Bitrhday;
                    update.Email = value.Email;
                    update.SchoolYear = value.SchoolYear;

                    collegeDataContext.SubmitChanges();
                    return Ok("student updated");
                }
                return Ok("no student found");
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

        // DELETE 
        public IHttpActionResult Delete(int id)
        {
            try
            {
                collegeDataContext.Students.DeleteOnSubmit(collegeDataContext.Students.First((item) => item.Id == id));
                collegeDataContext.SubmitChanges();

                return Ok("student deleted");
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