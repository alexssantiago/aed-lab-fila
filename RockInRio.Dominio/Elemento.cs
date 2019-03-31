namespace RockInRio.Dominio
{
    class Elemento
    {
        public Usuario Dado { get; }
        public Elemento Prox { get; set; }

        public Elemento(Usuario dado)
        {
            this.Dado = dado;
        }
    }
}
