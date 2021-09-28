using API.Models;
using System;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly DataContext _context;
        public PessoaController(DataContext context)
        {
            _context = context;
        }

        //POST: api/pessoa/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Pessoa pessoa)
        {
            _context.TabelaPessoas.Add(pessoa);
            _context.SaveChanges();
            return Created("", pessoa);
        }

        //GET: api/pessoa/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.TabelaPessoas.ToList());
    }
}