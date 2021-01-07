using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Web.API.Models;
using Utils.Common.Extensions;

namespace Utils.Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecryptEncryptController : ControllerBase
    {
        private readonly ILogger<DecryptEncryptController> _logger;

        public DecryptEncryptController(ILogger<DecryptEncryptController> logger)
        {
            _logger = logger;
        }

        [HttpPost("encrypt")]
        public IActionResult Encrypt([FromBody] EncryptDecryptModelDTO model)
        {
            var DecryptedText = model.Text.EncryptString(model.Key);

            return Ok(DecryptedText);
        }

        [HttpPost("decrypt")]
        public IActionResult Decrypt([FromBody] EncryptDecryptModelDTO model)
        {
            var DecryptedText = model.Text.DecryptString(model.Key);

            return Ok(DecryptedText);
        }


    }
}
