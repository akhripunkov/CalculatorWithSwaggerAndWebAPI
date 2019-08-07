using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPICalc4.Models;
using WebAPICalc4.Utilities;

namespace WebAPICalc4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public CalculatorResult res = new CalculatorResult();
        public Calculator calculator = new Calculator();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hello", "world" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpGet("calc")]
        public IEnumerable<CalculatorResult> GetCalculate(int a, int b)
        {
            res.Sum = calculator.Add(a, b);
            res.Sub = calculator.Sub(a, b);
            res.Mul = calculator.Mult(a, b);
            res.Div = calculator.Div(a, b);

            return new CalculatorResult[] { res };
        }

        [HttpGet("calc/str")]
        public string Get(string str)
        {
            return calculator.Eval(str).ToString();
        }

        [HttpGet("sum")]
        public string GetSum(int a, int b)
        {
            return calculator.Add(a, b).ToString();
        }

        [HttpGet("sub")]
        public string GetSub(int a, int b)
        {
            return calculator.Sub(a, b).ToString();
        }

        [HttpGet("mul")]
        public string GetMul(int a, int b)
        {
            return calculator.Mult(a, b).ToString();
        }

        [HttpGet("div")]
        public string GetDiv(int a, int b)
        {
            return calculator.Div(a, b).ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
