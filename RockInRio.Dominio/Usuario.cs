using System;

namespace RockInRio.Dominio
{
    public class Usuario 
    {
        private int _espera;

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Espera
        {
            get { return DateTime.Now.Minute - this._espera; }
            private set { }
        }

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            this._espera = DateTime.Now.Minute;
        }

        public Usuario()
        {
            this._espera = DateTime.Now.Minute;
        }

        public bool Equals(Usuario usuario)
        {
            Usuario user = (Usuario)(usuario);
            return (this.Cpf == user.Cpf);
        }

        public override string ToString()
        {
            return $"\nNome: {this.Nome} \nCPF: {this.Cpf}";
        }
    }
}
