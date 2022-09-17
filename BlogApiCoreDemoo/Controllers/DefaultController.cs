using BlogApiCoreDemoo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiCoreDemoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var db = new Context();
            var values = db.Employees.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employee e)
        {
            using var db = new Context();
            db.Add(e);
            db.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var db = new Context();
            var employee = db.Employees.Find(id);
            if(employee==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var db = new Context();
            var employee = db.Employees.Find(id);
            if(employee==null)
            {
                return NotFound();
            }
            else
            {
                db.Remove(employee);
                db.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult EmployeeUpdate(Employee e)
        {
            using var db = new Context();
            var emp = db.Find<Employee>(e.ID);
            if(emp==null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = e.Name;
                db.Update(emp);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}
