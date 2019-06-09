using RevisaoProva_Web2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoProva_Web2.Controllers
{
    public class FuncionarioController : Controller
    {
        private REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();

        public ActionResult Index()
        {
            var listaDeFuncionario = ctx.Funcionario.ToList();

            return View(listaDeFuncionario);
        }

        public ActionResult Create()
        {
            ViewBag.FuncaoId = new SelectList(ctx.Funcao, "FuncaoId", "Descricao");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Funcionario f)
        {
            if (ModelState.IsValid)
            {
                ctx.Funcionario.Add(f);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FuncaoId = new SelectList(ctx.Funcao, "FuncaoId", "Descricao");
            return View(f);
        }

        public ActionResult Edit(int id)
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            var editarObjeto = ctx.Funcionario.Find(id);
            ViewBag.FuncaoId = new SelectList(ctx.Funcao, "FuncaoId", "Descricao");
            return View(editarObjeto);
        }

        [HttpPost]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
                ctx.Entry(funcionario).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FuncaoId = new SelectList(ctx.Funcao, "FuncaoId", "Descricao");
            return View(funcionario);

        }

        public ActionResult Details(int id)
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            var detalhesObjeto = ctx.Funcionario.Find(id);
            return View(detalhesObjeto);
        }


        public ActionResult Delete(int id)
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            var deletarObjeto = ctx.Funcionario.Find(id);
            ctx.Funcionario.Remove(deletarObjeto);
            ctx.SaveChanges();
            return View(deletarObjeto);
        }

        [HttpPost]
        public ActionResult Delete(Funcionario funcionario)
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            ctx.Entry(funcionario).State = System.Data.Entity.EntityState.Deleted;
            return RedirectToAction("Index");

        }

    }
}