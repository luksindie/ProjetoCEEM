using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoCEEM.ViewModels;
using ProjetoCEEM.Models;

namespace ProjetoCEEM.Controllers
{
    public class TestesController : Controller
    {
        Context db = new Context();
        // GET: Testes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Testes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Testes/Create
        public ActionResult CreatePreCadastro()
        {
            return View();
        }

        // POST: Testes/Create
        [HttpPost]
        public ActionResult CreatePreCadastro(PreCadastroViewModel preCadastroViewModel)
        {
            
            if (ModelState.IsValid)
            {
                var codigo = Guid.NewGuid();
                PreCadastro preCadastro = new PreCadastro { DataCriacao = DateTime.Now,NomeCadastro = preCadastroViewModel.NomeCadastro,CodigoPreCadastro = codigo};
                db.PreCadastros.Add(preCadastro);
                preCadastro.CodigoPreCadastro = codigo;
                OrdemServico ordemServico = new OrdemServico {DataCadastro = preCadastro.DataCriacao,PreCadastroId = preCadastro.PreCadastroId,StatusOrdemServicoId = 1};
                Contato contato = new Contato {Descricao = preCadastroViewModel.Email,TipoContatoId = 1,PreCadastroId = 0};
                Endereco endereco = new Endereco
                {
                    Bairro = preCadastroViewModel.Bairro,
                    Cidade = preCadastroViewModel.Cidade,
                    Cep = preCadastroViewModel.Cep,
                    NumeroCasa = preCadastroViewModel.Numero,
                    Rua = preCadastroViewModel.Rua,
                    Uf = preCadastroViewModel.Estado,
                    PreCadastroId = preCadastro.PreCadastroId
                };
                db.OrdemServicos.Add(ordemServico);
                db.Contatos.Add(contato);
                db.Enderecos.Add(endereco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(preCadastroViewModel);
        }

        // GET: Testes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Testes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Testes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Testes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
