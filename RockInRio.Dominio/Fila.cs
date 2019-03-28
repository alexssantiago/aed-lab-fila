using System.Text;

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

    public class Fila
    {
        Elemento Primeiro, Ultimo;
        static int Posicoes;

        public Fila()
        {
            Posicoes = 0;
            this.Primeiro = new Elemento(null);
            this.Ultimo = this.Primeiro;
        }

        public bool Vazia()
        {
            return (this.Primeiro == this.Ultimo);
        }

        public void Inserir(Usuario d)
        {
            Elemento novo = new Elemento(d);

            this.Ultimo.Prox = novo;
            this.Ultimo = novo;
        }

        public Usuario Retirar()
        {
            if (this.Vazia()) return null;

            Elemento aux = this.Primeiro.Prox;
            this.Primeiro.Prox = aux.Prox;
            if (aux.Prox != null)
                aux.Prox = null;
            else
                this.Ultimo = this.Primeiro;

            Posicoes++;
            return aux.Dado;
        }

        public override string ToString()
        {
            if (this.Vazia()) return null;

            StringBuilder auxImpr = new StringBuilder();
            Elemento aux = this.Primeiro.Prox;

            while (aux != null)
            {
                auxImpr.AppendLine(aux.Dado.ToString());
                auxImpr.AppendLine($"avançou {Posicoes} posições desde o momento anterior.");

                aux = aux.Prox;
            }

            return auxImpr.ToString();
        }
    }
}
