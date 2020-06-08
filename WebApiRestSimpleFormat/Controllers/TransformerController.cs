using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiRestSimpleFormat.Models;

namespace WebApiRestSimpleFormat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransformerController : ControllerBase
    {
        private readonly ILogger<TransformerController> _logger;
        public TransformerController(ILogger<TransformerController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FormatBoxModel model)
        {
            switch (model.output_format.ToLower())
            {
                case "xml":
                    {
                        Byte[] b = Encoding.UTF8.GetBytes(model.xml_file);
                        return File(b, "application/xml");
                        break;
                    }
                case "image":
                    {  
                        Byte[] b = Convert.FromBase64String(model.image_file);
                        return File(b, "image/bmp");
                        break;
                    }
            }
            return BadRequest();
        }
    }
}