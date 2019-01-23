using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExWebApiAutos.Model.ExWebApiAutosDb;
using ExWebApiAutos.Model.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExWebApiAutos.Controllers
{
    [Route("api/[controller]")]
    public class MarcaController : Controller
    {
        private IMarcaRepository repositorio;
        public MarcaController(IMarcaRepository repo)
        {
            repositorio = repo;
        }
        // GET: api/<controller>
        [HttpGet]
        public IQueryable<TMarca> Get()
        {
            return repositorio.Marcas;
        }
        // GET api/<controller>/5
        [HttpGet("{MarcaId}")]
        public TMarca Get(Guid MarcaId)
        {
            return repositorio.Marcas.Where(p => p.MarcaId == MarcaId).FirstOrDefault();
        }
        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]TMarca marca)
        {
            repositorio.SaveMarca(marca);
            return Ok(true);
        }
        // PUT api/<controller>/5
        [HttpPut("{MarcaId}")]
        public IActionResult Put(Guid MarcaId, [FromBody]TMarca marca)
        {
            marca.MarcaId = MarcaId;
            repositorio.SaveMarca(marca);
            return Ok(true);
        }
        // DELETE api/<controller>/5
        [HttpDelete("{MarcaId}")]
        public IActionResult Delete(Guid MarcaId)
        {
            repositorio.DeleteMarca(MarcaId);
            return Ok(true);
        }
    }

}
