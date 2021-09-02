using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuradoController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Curado> _CuradosCollection;

        public CuradoController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _CuradosCollection = _mongoDB.DB.GetCollection<Curado>(typeof(Curado).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvarCurado([FromBody] CuradoDto dto)
        {
            var Curado = new Curado(dto.Nome, dto.Telefone, dto.Email, 
                                    dto.Cep, dto.Endereco, dto.Numero, 
                                    dto.Bairro, dto.Cidade, dto.Uf, 
                                    dto.DataCura);

            _CuradosCollection.InsertOne(Curado);
            
            return StatusCode(201, "Pacientes curado adicionado com sucesso !!!");
        }

        [HttpGet]
        public ActionResult ObterCurados()
        {
            var Curados = _CuradosCollection.Find(Builders<Curado>.Filter.Empty).ToList();
            
            return Ok(Curados);
        }
    }
}