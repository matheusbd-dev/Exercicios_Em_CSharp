/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    CURSO: ESW 5°
    DATA: 17/02/2026
    EXERCICIO: Declare int idade = 20 e bool maiorDeIdade verificando >= 18
*/
using System;
class Idade {
    
  static void Main() {
      
      int idade = 17;
      bool maiorDeIdade = false;
      
      if(idade >= 18){
          maiorDeIdade = true;
          Console.WriteLine("Maior de Idade é " + maiorDeIdade);
      }else{
           maiorDeIdade = false;
          Console.WriteLine("Maior de Idade é " + maiorDeIdade);
      }
      
  
  }
  
}