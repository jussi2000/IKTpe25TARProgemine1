using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using University.Data;
using University.Models;
using University.ViewModel;

namespace University.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityContext _context;
        public StudentController
            (
               UniversityContext context
            )
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            //leiame kõik student'id ja teisendame need
            //StudentIndexViewModel'iks

            //miks peab kasutame await?
            //kui me kasutame await, siis me ootame kuni päring on lõpetanud
            //ja saame tulemuse, enne kui jätkame koodi täitmist

            var result = await _context.Students
                .Select(s => new ViewModel.StudentIndexViewModel
                {
                    Id = s.Id,
                    LastName = s.LastName,
                    FirstMidName = s.FirstMidName,
                    EnrollmentDate = s.EnrollmentDate
                }).ToListAsync();
            //miks me kasutame ToListAsync();?
            //kui me kasutame ToListAsync();, siis me saame tulemuse list'ina

            return View(result);
        }
        //POST: Student/Create
        //see meetod salvestab uue student'i andmebaasi
        [HttpPost]
        //see meetod on kaitstud CSRF rünnakute eest
        //see meetod on as[nkroonene, mis tähendab, et meetod ei saa
        //olla samaaegselt miyu korda käivitatud
        public async Task<IActionResult> Details(int? id)
        {
            //kui id on null, siis tagastame NotFound() tulemuse
            if (id == null)
            {
                return NotFound();
            }
            //leiame student'i id järgi
            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);

            var vm = new ViewModel.StudentDetailsViewModel
            {
                Id = student.Id,
                LastName = student.LastName,
                FirstMidName = student.FirstMidName,
                EnrollmentDate = student.EnrollmentDate

            };

            //kui student on null, siis tagastame NotFound() tulemuse
            if (student == null)
            {
                return NotFound();
            }

            //kui student on leitud, siis tagastame View(student) tulemuse
            return View(vm);

        }
        public IActionResult Create()
        {

            return View();
        }

        //POST: Student/Create
        //see meetod salvestab uue student'i andmebaasi
        [HttpPost]
        //see meetod on kaitstud CSRF rünnakute eest
        //see meetod on as[nkroonene, mis tähendab, et meetod ei saa
        //olla samaaegselt miyu korda käivitatud
        public async Task<IActionResult> Create(StudentCreateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var Student = new Models.Student
                {
                    LastName = vm.LastName,
                    FirstMidName = vm.FirstMidName,
                    EnrollmentDate = vm.EnrollmentDate
                };
                //lisame studen't andmebaasi ja salvestame muudatused
                _context.Add(Student);
                //miks kasutame await?
                //kui me kasutame await, siis me ootame kuni salvestamine on lõppenud
                await _context.SaveChangesAsync();
                //pärast salvestamist suuname kasutaja tagasi Index vaatesse
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }
    }
}