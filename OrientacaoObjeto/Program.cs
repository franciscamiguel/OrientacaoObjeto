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
