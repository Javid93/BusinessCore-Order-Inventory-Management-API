using Microsoft.AspNetCore.Mvc;

namespace BusinessCore.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult getProducts()
    {
        return Ok(new
        {
            message = "Products endpoint is working"
        });
    }
}