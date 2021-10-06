using Microsoft.AspNetCore.Mvc;
using MusicShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicShop.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MusicShopController : ControllerBase
	{
		private readonly MusicShopContext _musicShopContext;

		public MusicShopController(MusicShopContext musicShopContext)
		{
			_musicShopContext = musicShopContext;
		}
		// GET: api/<MusicShopController>
		[HttpGet]
		public IEnumerable<Price> Get()
		{
			return _musicShopContext.Prices.ToList();
		}

		// GET api/<MusicShopController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<MusicShopController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<MusicShopController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<MusicShopController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
