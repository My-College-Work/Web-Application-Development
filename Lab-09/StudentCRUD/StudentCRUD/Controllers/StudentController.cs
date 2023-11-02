using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCRUD.Data;
using StudentCRUD.Models;
using StudentCRUD.Models.Domain;

namespace StudentCRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext appDbContext;
        public StudentController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await appDbContext.Students.ToListAsync();
            return View(students);  
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel addStudentRequest)
        {
            var student = new Student()
            {
                Id = Guid.NewGuid(),
                Name = addStudentRequest.Name,
                Email = addStudentRequest.Email,
            };

            await appDbContext.Students.AddAsync(student);
            await appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet] 
        public async Task<IActionResult> View(Guid id)
        {
            var student = await appDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if(student != null)
            {
                var viewModel = new UpdateStudentViewModel()
                {
                    Id = student.Id,
                    Name = student.Name,
                    Email = student.Email,
                };
                return await Task.Run(() => View("View", viewModel));
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost] 
        public async Task<IActionResult> View(UpdateStudentViewModel model)
        {
            var student = await appDbContext.Students.FindAsync(model.Id);
            if(student != null)
            {
                student.Name = model.Name;
                student.Email = model.Email;

                await appDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateStudentViewModel model)
        {
            var student = await appDbContext.Students.FindAsync(model.Id);
            if (student != null)
            {
                appDbContext.Students.Remove(student);
                await appDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
