namespace bcp.project.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bcp.project.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

[ApiController]
[Route("[controller]")]
public class CreditorController : ControllerBase
{
    private readonly ICreditorService CreditorService;

    public CreditorController(ICreditorService creditorService)
    {
        CreditorService = creditorService;
    }

    // GET: api/values
    [HttpGet]
    public async Task<IActionResult> GetAllCreditors()
    {
        return this.Ok(await this.CreditorService.GetAllCreditors());
    }

    //// GET api/values/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    //// POST api/values
    //[HttpPost]
    //public void Post([FromBody]string value)
    //{
    //}

    //// PUT api/values/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody]string value)
    //{
    //}

    //// DELETE api/values/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}

