using INMETRO.SCIPP_v2.DOMINIO.CORE.Modelos;

namespace INMETRO.SCIPP_v2.DOMINIO.Modelos
{
    public class Organismo : Entidade
    {
        protected Organismo(){}

        public Organismo(int id, string nome, string codigo)
        {
            Id = id;
            Nome = nome;
            Codigo = codigo;
        }

        public string Nome { get; private set; }
        public string Codigo { get; private set; }
    }
}
