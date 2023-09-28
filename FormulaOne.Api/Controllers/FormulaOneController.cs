using Microsoft.AspNetCore.Mvc;

namespace FormulaOne.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FormulaOneController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> SampleEndpoint()
    {
        return await Task.FromResult(Ok("This somehow worked!!!"));
    }
}