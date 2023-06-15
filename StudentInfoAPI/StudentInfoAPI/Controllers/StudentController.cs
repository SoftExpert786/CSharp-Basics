using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentInfoAPI.Data;
using StudentInfoAPI.Migrations;
using StudentInfoAPI.Models;

namespace StudentInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _data;

        public StudentController(DataContext data)
        {
            _data = data;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                IList<Student> getdata = _data.students.ToList();
                return Ok(getdata);
            }
            catch (Exception Ex)
            {
                return StatusCode(500, Ex);
            }
        }
        [HttpGet("Id")]
        public IActionResult Get(int id)
        {
            try
            {
                if (id == null)
                {
                    return StatusCode(500, "Id not null");
                }
                var DatabyId = _data.students.Find(id);
                return Ok(DatabyId);
            }
            catch (Exception Ex)
            {
                return StatusCode(500, Ex);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id == null)
                {
                    return StatusCode(500, "Id will not null here");
                }
                var deleteId = _data.students.FirstOrDefault(x => x.Id == id);
                _data.students.Remove(deleteId);
                _data.SaveChanges();
                return Ok(deleteId);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        [HttpPost]
        public IActionResult AddStudent(Student obj)
        {
            try
            {
                if (obj.Name == null)
                {
                    return StatusCode(500, "Id will not null");
                }
                _data.students.Add(obj);
                _data.SaveChanges();
                return Ok(obj);
            }
            catch (Exception Ex)
            {
                return StatusCode(500, Ex);
            }
        }
        [HttpPost("{id}")]
        public IActionResult Update(int id ,Student obj)
        {
            try
            {

                Student student= new Student()
                {
                    Id = id,
                    Name = obj.Name,
                    F_Name = obj.F_Name,
                    Age= obj.Age,
                    AdmissionDate= obj.AdmissionDate,
                };
                _data.students.Update(student);
                _data.SaveChanges();
                return Ok(obj);
            }catch(Exception Ex)
            {
                return StatusCode(500, Ex);
            }
        }
    }
}