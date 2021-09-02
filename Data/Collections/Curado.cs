using System;

namespace Api.Data.Collections
{
    public class Curado
    {
        public Curado(string nome, string telefone, string email,
                      string cep, string endereco, int numero,
                      string bairro, string cidade, string uf,
                      DateTime dataCura)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
            this.Cep = cep;
            this.Endereco = endereco;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Uf = uf;
            this.DataCura = dataCura;

        }
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