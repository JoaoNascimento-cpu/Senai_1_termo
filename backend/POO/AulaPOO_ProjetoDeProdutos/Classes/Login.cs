using System;

namespace Produtos.Classes
{
    public class Login
    {
        public bool Logado {get; set;}

        public Login()
        {
            Logar();
            if (Logado == true)
            {
                GerarMenu();
            }
        }

        public void GerarMenu()
        {
            string opcao;
            Console.ForegroundColor = ConsoleColor.Yellow;
                Marca marca = new Marca();
                Produto produto = new Produto();
            do
            {
                Console.WriteLine("Escolha uma opção abaixo");
                Console.WriteLine("1 - Cadastrar Marca");
                Console.WriteLine("2 - Listar Marca");
                Console.WriteLine("3 - Excluir Marca");
                Console.WriteLine("4 - Cadastrar Produto");
                Console.WriteLine("5 - Listar ProdutoS");
                Console.WriteLine("6 - Excluir Produto");
                Console.WriteLine("0 - Sair da aplicação");

                opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        marca.Cadastrar();
                        break;
                    case "2":
                        marca.Listar();
                        break;
                    case "3":
                        Console.WriteLine("Digite o codigo da marca que deseja excluir");
                        int codigo = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo);
                        break;
                    case "4":
                        produto.Cadastrar();
                        break;
                    case "5":
                        produto.Listar();
                        break;
                    case "6":
                        Console.WriteLine("Digite o codigo do Produto que deseja excluir");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                        break;                    

                    default:
                        Console.WriteLine("Saindo do Sistema");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
                
            } while (opcao != "0");
        }

        public void Logar()
        {
            Usuario user = new Usuario();
            Console.WriteLine("Digite seu email.");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua senha.");
            string senhaLogin = Console.ReadLine();

            if (emailLogin == user.Email && senhaLogin == user.Senha)
            {
                Logado = true;
                Console.WriteLine("Login efetuado com sucesso");

            }else{
                Console.WriteLine("Falha ao realizar o login, tente novamente");
            }
        }

        public void Deslogar()
        {
            Logado = false;
        }
    }
}