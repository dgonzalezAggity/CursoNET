using Microsoft.AspNetCore.Mvc;

public class MyController : ControllerBase
{
    private readonly IMyService _myService;

    public MyController(IMyService myService)
    {
        _myService = myService;

    }

    [HttpGet]
    public IActionResult GetMessage()
    {
        return Ok(_myService.GetMessage());
    }
}