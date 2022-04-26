using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KideiaWebAPI.Models;

namespace KideiaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessStatusController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Confirmando e-mail", "Pendente de assinatura", "Contrato Assinado", "Verificando Documentos", "Plano Selecionado"
        };

        [HttpGet]
        public IEnumerable<ProcessStatus> Get()
        {
            var rng = new Random();
            int count = 0;
            return Enumerable.Range(0, 4).Select(index => new ProcessStatus
            {
                Date = DateTime.Now.AddDays(index),
                Summary = Summaries[count++]
            })
            .ToArray();
        }
    }
}
