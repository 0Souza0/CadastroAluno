using CadastroAluno.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAluno.Controllers
{
    public class AlunoController : Controller
    {
        // GET: /Aluno/Cadastrar — Exibe o formulário vazio
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: /Aluno/Cadastrar — Recebe e valida os dados do formulário
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            // Verifica se todas as Data Annotations foram satisfeitas
            if (!ModelState.IsValid)
            {
                // Retorna o formulário com os erros de validação
                return View(aluno);
            }

            // Dados válidos — redireciona para a página de confirmação
            return View("Confirmacao", aluno);
        }
    }
}
