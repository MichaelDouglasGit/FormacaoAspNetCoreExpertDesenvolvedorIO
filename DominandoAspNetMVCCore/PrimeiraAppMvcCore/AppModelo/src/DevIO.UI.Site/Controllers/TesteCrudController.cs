using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        public readonly DataContext _contexto;
        public TesteCrudController(DataContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            //Create
            var aluno = new Aluno {
                Nome = "Michael",
                DataNascimento = DateTime.Now,
                Email = "teste@testeemail.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            //Read
            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email.Equals("teste@testeemail.com"));
            var aluno4 = _contexto.Alunos.Where(a => a.Nome.Equals("Michael"));
            //Update
            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            //Delete
            _contexto.Alunos.Remove(aluno);

            return View();
        }
    }
}
