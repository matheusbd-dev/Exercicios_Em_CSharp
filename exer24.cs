/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    CURSO: ESW 5°
    DATA: 17/02/2026
    EXERCICIO: Faça casting explícito: double → int e observe a perda decimal.
*/
using System;
class Castii {
    
  static void Main() {
      
      double doubleSalario = 2200.99;
      
      Console.WriteLine("Salario antigo: " + doubleSalario);
      
      int intSalario = (int) doubleSalario;
      
      Console.WriteLine("Salario novo: " + intSalario);
      
  
  }
  
}