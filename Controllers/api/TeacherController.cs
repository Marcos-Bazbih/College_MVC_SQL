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
        static string connectionString = "Data Source=LENOVO-MARCOS;Initial Catalog=CollegeDb;Integrated Security=True;Pooling=False";
        DataClasses1DataContext collegeDataContext = new DataClasses1DataContext(connectionString);



        // GET ALL
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(collegeDataContext.Teachers.ToList());
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
                return Ok(collegeDataContext.Teachers.First((item) => item.Id == id));
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
        public IHttpActionResult Post([FromBody] Teacher value)
        {
            try
            {
                collegeDataContext.Teachers.InsertOnSubmit(value);
                collegeDataContext.SubmitChanges();
                return Ok("teacher added");
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
        public IHttpActionResult Put(int id, [FromBody] Teacher value)
        {
            try
            {
                Teacher update = collegeDataContext.Teachers.First((item) => item.Id == id);
                if (update != null)
                {
                    update.FirstName = value.FirstName;
                    update.LastName = value.LastName;
                    update.Domain = value.Domain;
                    update.Email = value.Email;
                    update.Salary = value.Salary;

                    collegeDataContext.SubmitChanges();
                    return Ok("teacher updated");
                }
                return Ok("no teacher found");
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
                collegeDataContext.Teachers.DeleteOnSubmit(collegeDataContext.Teachers.First((item) => item.Id == id));
                collegeDataContext.SubmitChanges();

                return Ok("teacher deleted");
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