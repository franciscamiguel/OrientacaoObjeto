using ClasseObjeto.Classe_Objeto;

/*
#region casa 

Casa casa = new Casa(); //instancia da class, cria um objeto da classe

casa.Id = 2;
casa.Name = "Apartamento"; // Atribuição de valores.

Console.WriteLine(casa.Id);
Console.WriteLine(casa.Name);

casa.Id = 20;
casa.Name = "Mansao";

Console.WriteLine(casa.Id);
Console.WriteLine(casa.Name);

Casa casa1 = new Casa();

casa1.Id = 1;
casa1.Name = "Hostel";

Console.WriteLine(casa1.Id);
Console.WriteLine(casa1.Name);

#endregion casa
*/
// classe pessoa e animal.
/*
Pessoa pessoa = new Pessoa();

pessoa.Id = 2;
pessoa.Nome = "Francisca";
pessoa.Idade = 30;
pessoa.CPF = "23688099885";

Console.WriteLine("Meu id é: " + pessoa.Id); // concatenação: junção de caracteres
Console.WriteLine("Meu nome é: " + pessoa.Nome);
Console.WriteLine("Eu tenho: " + pessoa.Idade + " Anos de idade " );
Console.WriteLine("Meu cpf é: " + pessoa.CPF);
*/

/*
Animal animal = new Animal();

animal.Id = 1;
animal.Nome = "Rafeiro";
animal.Idade = 3;
animal.Peso = 2.3;
animal.Altura = 1.7;
animal.Especie = "Cavalo";

Console.WriteLine("Id do meu animal é: " + animal.Id +
                 "\nO nome dele é: " + animal.Nome +
                 "\nIdade dele é: " + animal.Idade + 
                 "\nO peso dele é: " + animal.Peso + 
                 "\nAltura dele é: " + animal.Altura +
                 "\nA especie dele é: " + animal.Especie);
*/


Funcionario funcionario = new Funcionario();
funcionario.Id = 1;
funcionario.Nome = "Alberto Jaquim";
funcionario.CPF = "23688099885";
funcionario.RG = "123.456.9";
funcionario.DataNacimento = new DateOnly(1992,11,08);
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

Console.WriteLine(" Id do funcionario: " + funcionario.Id +
                  "\n Nome do funcionario: " + funcionario.Nome +
                  " \n Cpf do funcionario é: " + funcionario.CPF +
                  "\n Rg é: " + funcionario.RG +
                  "\n Data de nascimento: " + funcionario.RG +
                  "\n Nome da Mãe é: " + funcionario.NomeDaMae +
                  "\n Nome do pai é: " + funcionario.NomeDoPai +
                  "\n Naturalozação: " + funcionario.Naturalizacao +
                  "\n Endereço: " + funcionario.Endereco +
                  "\n Bairro: " + funcionario.Bairro +
                  "\n Cidade: " + funcionario.Cidade +
                  "\n País: " + funcionario.País +
                  "\n Telefone: " + funcionario.Telefone +
                  "\n Email: " + funcionario.Email +
                  "\n Cargo: " + funcionario.Cargo);