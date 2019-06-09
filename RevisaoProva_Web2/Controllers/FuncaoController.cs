using RevisaoProva_Web2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RevisaoProva_Web2.Controllers
{
    public class FuncaoController : Controller
    {
        // GET: Funcao
        public ActionResult Index()
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            var listaDeFuncao = ctx.Funcao.ToList();
            return View(listaDeFuncao);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Funcao funcao)
        {
            if (ModelState.IsValid)
            {
                REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
                ctx.Funcao.Add(funcao);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcao);
        }

        public ActionResult Edit(int id)
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            var editarObjeto = ctx.Funcao.Find(id);
            return View(editarObjeto);
        }

        [HttpPost]
        public ActionResult Edit(Funcao funcao)
        {
            if (ModelState.IsValid)
            {
                REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
                ctx.Entry(funcao).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcao);

        }

        public ActionResult Details(int id)
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            var detalhesObjeto = ctx.Funcao.Find(id);
            return View(detalhesObjeto);
        }


        public ActionResult Delete(int id)
        {
            REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
            var deletarObjeto = ctx.Funcao.Find(id);
            ctx.Funcao.Remove(deletarObjeto);
            ctx.SaveChanges();
            return View(deletarObjeto);
        }

        [HttpPost]
        public ActionResult Delete(Funcao funcao)
        {
                REVISAO_PROVA_PART_IIIEntities ctx = new REVISAO_PROVA_PART_IIIEntities();
                ctx.Entry(funcao).State = System.Data.Entity.EntityState.Deleted;
                return RedirectToAction("Index");
           
        }

    }
}