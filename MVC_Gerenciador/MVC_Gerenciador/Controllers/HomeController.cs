using MVC_Gerenciador.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVC_Gerenciador.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string api = "https://api.github.com/users/yankelvin/repos";

            dynamic resultado = serializer.DeserializeObject(GET(api));

            ViewBag.NomeRepo1 = resultado[0]["description"];
            ViewBag.NomeRepo2 = resultado[1]["description"];

            return View();
        }

        private string GET(string url) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "[user agent]";

            try {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream()) {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            } catch (WebException ex) {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream()) {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

        public ActionResult Repo1() {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string api = "https://api.github.com/repos/yankelvin/Diagrama_de_Classes";

            dynamic resultado = serializer.DeserializeObject(GET(api));

            Repositorio repo = new Repositorio();
            repo.nome = resultado["name"];
            repo.descricao = resultado["description"];
            repo.linguagem = resultado["language"];
            repo.ultimaAtualizacao = resultado["updated_at"];
            repo.donoRepositorio = resultado["owner"]["login"];

            ViewBag.Nome = repo.nome;
            ViewBag.Descricao = repo.descricao;
            ViewBag.Linguagem = repo.linguagem;
            ViewBag.UltimaAtualizacao = repo.ultimaAtualizacao;
            ViewBag.DonoRepositorio = repo.donoRepositorio;

            return View();
        }

        public ActionResult Repo2() {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string api = "https://api.github.com/repos/yankelvin/samanthabot";

            dynamic resultado = serializer.DeserializeObject(GET(api));

            Repositorio repo = new Repositorio();
            repo.nome = resultado["name"];
            repo.descricao = resultado["description"];
            repo.linguagem = resultado["language"];
            repo.ultimaAtualizacao = resultado["updated_at"];
            repo.donoRepositorio = resultado["owner"]["login"];

            ViewBag.Nome = repo.nome;
            ViewBag.Descricao = repo.descricao;
            ViewBag.Linguagem = repo.linguagem;
            ViewBag.UltimaAtualizacao = repo.ultimaAtualizacao;
            ViewBag.DonoRepositorio = repo.donoRepositorio;

            return View();
        }
    }
}