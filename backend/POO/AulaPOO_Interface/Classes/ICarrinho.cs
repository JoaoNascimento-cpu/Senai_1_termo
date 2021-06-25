namespace Interface.Classes
{
    public interface ICarrinho
    {
        void Alterar(int cod, Produto produto);
        void Cadastrar(Produto produto);
        void Listar();
        void Deletar(Produto produto);
    }
}