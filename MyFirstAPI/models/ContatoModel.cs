

namespace MyFirstAPI.models
{
    public class ContatoModel
    {
        // Guild
        // new Guild();
        public int Id { get; init; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }   
        public bool Ativo { get; private set; }

        public void UpdateContact(string nome, string telefone, bool ativo)
        {
            Nome = nome;
            Telefone = telefone;
            Ativo = ativo;
        }

        public void DesativarContact() => Ativo = false;
    }
}