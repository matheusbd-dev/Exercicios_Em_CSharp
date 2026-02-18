/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    CURSO: ESW 5°
    DATA: 17/02/2026
    EXERCICIO: Declare um char com a inicial do seu nome e exiba.
*/
using System;
class Char {
    
  static void Main() {
      
      string nome = "Fabricio Aparecido Silva";
      
      //Vetor para pegar as letras
      char primeiraLetra = nome[0];
      
      Console.WriteLine("A primeira letra do nome do " + nome + " é "
      + primeiraLetra);
      
  
  }
  
}