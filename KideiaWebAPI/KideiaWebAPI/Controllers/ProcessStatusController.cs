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

        [HttpGet("{IdUser:int}")]
        public IEnumerable<ProcessStatus> Get([FromRoute] int IdUser)
        {
            var rng = new Random();
            int count = 0;
            return Enumerable.Range(0, 4).Select(index => new ProcessStatus
            {
                Id = IdUser,
                Date = DateTime.Now.AddDays(index),
                Summary = Summaries[count++],
                Name = "Daniel"
            })
            .ToArray();
        }
    }
}
