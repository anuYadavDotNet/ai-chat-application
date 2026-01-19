using Chat_Bot_Project.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/chat")]
public class ChatController : ControllerBase
{
    private readonly OllamaService _ollamaService;

    public ChatController(OllamaService ollamaService)
    {
        _ollamaService = ollamaService;
    }

    [HttpPost]
    public async Task<IActionResult> Chat([FromBody] ChatRequest request)
    {
        var reply = await _ollamaService.AskAI(request.Message);
        return Ok(new { reply });
    }
}
