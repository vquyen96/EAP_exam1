using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EAP_exam1.Data;
using EAP_exam1.Models;

namespace EAP_exam1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneysController : ControllerBase
    {
        private readonly MyContext _context;

        public MoneysController(MyContext context)
        {
            _context = context;
        }

        // GET: api/Moneys
        [HttpGet]
        public IEnumerable<Money> GetMoney()
        {
            return _context.Money;
        }

        // GET: api/Moneys/5
        [HttpGet("{id}/{value}")]
        public async Task<IActionResult> GetMoney([FromRoute] string id, int value)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var changeMoney = await _context.Money.SingleOrDefaultAsync(c => c.Id == id);
            if (changeMoney == null)
            {
                return Conflict("Đơn vị tiền tệ không đúng");
            }

            return new JsonResult(value * changeMoney.Ratio);
        }

        // PUT: api/Moneys/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMoney([FromRoute] string id, [FromBody] Money money)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != money.Id)
            {
                return BadRequest();
            }

            _context.Entry(money).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoneyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Moneys/USD
        [HttpPost("{Id}")]
        public async Task<IActionResult> PostMoney([FromRoute] string Id, [FromBody] int value)
        {
            //return new JsonResult(value);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var changeMoney = await _context.Money.SingleOrDefaultAsync(c => c.Id == Id);
            if (changeMoney == null)
            {
                return Conflict("Đơn vị tiền tệ không đúng");
            }

            return new JsonResult(value * changeMoney.Ratio);
        }

        // DELETE: api/Moneys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoney([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var money = await _context.Money.FindAsync(id);
            if (money == null)
            {
                return NotFound();
            }

            _context.Money.Remove(money);
            await _context.SaveChangesAsync();

            return Ok(money);
        }

        private bool MoneyExists(string id)
        {
            return _context.Money.Any(e => e.Id == id);
        }
    }
}