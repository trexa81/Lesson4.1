using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lesson4_1.Controllers
{
    [Route("api/crud")]     //crud вместо [controller]
    [ApiController]
    public class CrudController : ControllerBase
    {
        private readonly ValuesHolder _holder;

        public CrudController(ValuesHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("create")]
        public IActionResult Create([FromQuery] string input)
        {
            _holder.Add(input);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult Read()
        {
            return Ok(_holder.Get());
        }

        //[HttpPut("update")]
        //public IActionResult Update([FromQuery] string stringsToUpdate, [FromQuery] string newValue)
        //{
        //    for (int i = 0; i < _holder.Values.Count; i++)
        //    {
        //        if (holder.Values[i] == stringsToUpdate)
        //            holder.Values[i] = newValue;
        //    }

        //    return Ok();
        //}

        //[HttpDelete("delete")]
        //public IActionResult Delete([FromQuery] string stringsToDelete)
        //{
        //    holder.Values = holder.Values.Where(w => w != stringsToDelete).ToList();
        //    return Ok();

        //}
    }

    public class ValuesHolder
    {
        public object Values { get; internal set; }

        internal void Add(string input)
        {
            throw new NotImplementedException();
        }

        internal object Get()
        {
            throw new NotImplementedException();
        }
    }
}
