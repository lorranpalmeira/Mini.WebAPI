using Mini.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;

namespace Mini.WebAPI.Controllers
{
    public class MinificadorController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "origem.html", "destino.html" };
        }

        public HttpResponseMessage Get(int id)
        {

            var lista = new string[]{ "origem.html", "destino.html" };


            if (lista.Count() > id)
            {
                return Request.CreateResponse(HttpStatusCode.OK, lista[id]);
            }
            else {
                return new HttpResponseMessage(HttpStatusCode.BadRequest );
            }
        }



        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        [HttpPost]
        public HttpResponseMessage Executar([FromBody] ArquivoModel arquivo) {

            if (arquivo.Origem == "origem")
            {
                Console.WriteLine("É igual");
                MessageBox.Show("É igual");
            }
            else {
                //Console.WriteLine();
                MessageBox.Show("É Diferente");
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        

       
    }
}
