using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Controllers;

//[ApiController] // 
[Route("[controller]")] // localhost/<Class Name Without Controller>
// [Route("installgentoo")] // localhost/installgentoo
public class MyExampleController : Controller
{
    private readonly ILogger<MyExampleController> _logger;

    public MyExampleController(ILogger<MyExampleController> logger)
    {
        _logger = logger;

        // _logger.Log(LogLevel.Critical, "Oh no.."); // logs to console
        // Instantiates class every time on request
        // keep it light, keep it simple.
    }

    [HttpGet(Name = "GetMyExampleData")]
    public string Get()
    {
        // MyExampleModel
        return "Remove Windows";
    }

    [HttpGet(Name = "Bonjour", Order = -1)] // where to use Order
    public string Hello() {
        // throw new Exception("아 커피 흘렸네"); // Order 여러개인 경우 알아보는 중
        return "Linux";
    }

    // [HttpGet(Name = "Hola", Order = -2)]
    // public void First() {
    //     // 아무것도 없음
    //     // -1 실행 안함
    // }


    // Throws AmbiguousMatchException
    // [HttpGet(Name = "Bonjour")]
    // public string Get2()
    // {
    //     return "I use arch btw";
    // }


    [HttpPost(Name = "PostMyExampleData")]
    public string Post()
    {
        return "Install Gentoo";
    }

    [HttpGet("Gentoo")] // "Gentoo" is RouteAttribute.Template
    public string Index() {
        return "Install Gentoo";
    }
}