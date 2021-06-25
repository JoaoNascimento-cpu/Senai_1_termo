using System;

namespace Produtos.Classes
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro;        
        
        public Usuario()
        {
            Cadastrar();
        }
        public Usuario(int _cod, string _nome, string _email, string _senha)
        {
            Codigo = _cod;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
        }

        public void Cadastrar()
        {
            Nome ="Johnny";
            Email = "joao.com";
            Senha = "123456";
        }
        public void Deletar()
        {
            Nome ="";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.UtcNow;
        }

        

    }
}