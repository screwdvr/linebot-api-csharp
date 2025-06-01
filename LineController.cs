//接收來自 LINE 的 POST
//把 payload 印到 console
//回傳 200 OK 給 LINE

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LineBotApi.Controllers
{
    [ApiController]
    [Route("line")]
    public class LineController : ControllerBase
    {
        private readonly ILogger<LineController> _logger;

        public LineController(ILogger<LineController> logger)
        {
            _logger = logger;
        }

        [HttpPost("webhook")]
        public IActionResult Webhook([FromBody] object payload)
        {
            _logger.LogInformation("接收到 LINE webhook：{Payload}", payload.ToString());
            return Ok();
        }
    }
}
