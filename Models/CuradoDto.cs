using System;

namespace Api.Models
{
    public class CuradoDto
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public DateTime DataCura { get; set; }
    }
}