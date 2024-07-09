namespace ClasseObjeto.Classe_Objeto
{
    public class ServicoClassObjeto
    {
        /// <summary>
        /// Sempre que for criar metodo começar sempre com  um verbo+Predicado.
        /// </summary>
        public void TestarCasa() // metodos ela indica uma ação ou fazer alguma coisa
            
        {
            Casa casa1 = new Casa();
            casa1.Id = 1;
            casa1.Name = "Hostel";

            Console.WriteLine(casa1.Id);
            Console.WriteLine(casa1.Name);
        }

        public void TestarPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 2;
            pessoa.Nome = "Francisca";
            pessoa.Idade = 30;
            pessoa.CPF = "23688099885";

            Console.WriteLine("\nMeu id é: " + pessoa.Id); // concatenação: junção de caracteres
            Console.WriteLine("Meu nome é: " + pessoa.Nome);
            Console.WriteLine("Eu tenho: " + pessoa.Idade + " Anos de idade ");
            Console.WriteLine("Meu cpf é: " + pessoa.CPF);
        }


        public void TestarAnimal()
        {
            Animal animal = new Animal();
            animal.Id = 1;
            animal.Nome = "Rafeiro";
            animal.Idade = 3;
            animal.Peso = 2.3;
            animal.Altura = 1.7;
            animal.Especie = "Cavalo";

            Console.WriteLine("\nId do meu animal é: " + animal.Id +
                             "\nO nome dele é: " + animal.Nome +
                             "\nIdade dele é: " + animal.Idade +
                             "\nO peso dele é: " + animal.Peso +
                             "\nAltura dele é: " + animal.Altura +
                             "\nA especie dele é: " + animal.Especie);
        }


        public void TestarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = 1;
            funcionario.Nome = "Alberto Jaquim";
            funcionario.CPF = "23688099885";
            funcionario.RG = "123.456.9";
            funcionario.DataNacimento = new DateOnly(1992, 11, 08);
            funcionario.NomeDaMae = "Josefina Joao";
            funcionario.NomeDoPai = "Cristovão Joao";
            funcionario.Naturalizacao = "Angolana";
            funcionario.Endereco = "Rua padre Adelino";
            funcionario.Bairro = "Sambizanga";
            funcionario.Cidade = "Luanda";
            funcionario.País = "Angola";
            funcionario.Telefone = 244923030386;
            funcionario.Email = "jsteste@gmail.com";
            funcionario.Cargo = "Analista de Sistema";



            Console.WriteLine("\nId do funcionario: " + funcionario.Id +
                              "\nNome do funcionario: " + funcionario.Nome +
                              " \nCpf do funcionario é: " + funcionario.CPF +
                              "\nRg é: " + funcionario.RG +
                              "\nData de nascimento: " + funcionario.RG +
                              "\nNome da Mãe é: " + funcionario.NomeDaMae +
                              "\nNome do pai é: " + funcionario.NomeDoPai +
                              "\nNaturalozação: " + funcionario.Naturalizacao +
                              "\nEndereço: " + funcionario.Endereco +
                              "\nBairro: " + funcionario.Bairro +
                              "\nCidade: " + funcionario.Cidade +
                              "\nPaís: " + funcionario.País +
                              "\nTelefone: " + funcionario.Telefone +
                              "\nEmail: " + funcionario.Email +
                              "\nCargo: " + funcionario.Cargo);
        }
       
          
           
    }
}

