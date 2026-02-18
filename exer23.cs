/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    CURSO: ESW 5°
    DATA: 17/02/2026
    EXERCICIO: Faça casting implícito: int → long e float → double.
*/
using System;
class Castingg {
    
  static void Main() {
      
      int intSalario = 500;
      
      //não há risco de perda de dados.
      long longSalario = intSalario;
      
      Console.WriteLine(longSalario);
      
      //------------------------------
      float floatSalario = longSalario;
      Console.WriteLine(floatSalario);
      
      //--------------------------------
      double doubleSalario = floatSalario;
      Console.WriteLine(doubleSalario);
      
  
  }
  
}