using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace MeowCatAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        [HttpGet]
        public string empty()
        {
            return "You haven't choosen the list.";
        }
        [HttpGet("{id}")]
        public List<Note> onGet(string id)
        {
            var name = id + ".txt";
            var dir = "notes";
            Management.checkExistence(name,dir);
            return Management.readList(name,dir);
        }
        [HttpPost("{id}")]
        public void onPost(string id, [FromBody]List<Note> newlist)
        {
            var name = id+".txt";
            var dir = "notes";
            Management.checkExistence(name,dir);
            Management.updateList(name,dir,newlist);
        }
        [HttpDelete("{id}")]
        public void onDelete(string id)
        {
            var name = id + ".txt";
            var dir = "notes";
            Management.checkExistence(name,dir);
            IO.ClearFile(name,dir);
        }
    }
}