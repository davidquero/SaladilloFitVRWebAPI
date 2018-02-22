using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

namespace SaladilloFitVR.Controllers
{
    public class SaladilloFitVRController : ApiController
    {
        /// <summary>
        /// Método que debe ser utilizado por otros sistemas para
        /// comprobar la conectividad con la Web API.
        /// </summary>
        /// <remarks>
        /// Devuelve HttpStatusCode.OK.
        /// </remarks>
        /// <returns>
        /// HttpResponseMessage con el resultado de la ejecución:
        /// - StatusCode = HttpStatusCode.OK
        /// </returns>
        [HttpGet]
        public HttpResponseMessage CheckConnectivity()
        {
            return this.Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}