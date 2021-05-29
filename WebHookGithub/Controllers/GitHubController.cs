using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//./ngrok http 7700 --host-header=localhost:7700
//taskkill /f /im ngrok.exe (windows)
//linux
//ngrok process id by $ top
//$ kill -9 {ngrok_id}
//6eca8f35a4019ae7ab93f585676ce5b0eafef282
namespace WebHookGithub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {

        [GitHubWebHook]
        public IActionResult GitHub(string id, JObject data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }
        // GET: api/<GitHubController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GitHubController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GitHubController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GitHubController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GitHubController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
