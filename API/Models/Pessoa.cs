using System;

namespace API.Models
{
    public class Pessoa
    {
        public Pessoa() => CriadoEm = DateTime.Now;

        public int Id {get ; set ;}
        public string Nome {get ; set ;}
        public int Idade {get ; set ;}
        public double Altura  {get ; set ;}
        public string Cpf  {get ; set ;}
        public string Email  {get ; set ;}
        public DateTime CriadoEm { get; set; }
    }
}