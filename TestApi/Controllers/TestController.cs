using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("/api/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Message = "this works fine", MaskedField = "should be masked", Password = "abc123" });
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest r)
    {
        return Ok(r);
    }
}

public class RegisterRequest
{
    public string Name { get; set; }
    public string MaskedField { get; set; }
    public string PaymentType { get; set; }
    public string Password { get; set; }
}
