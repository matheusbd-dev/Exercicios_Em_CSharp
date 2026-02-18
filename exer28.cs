/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    CURSO: ESW 5°
    DATA: 17/02/2026
    EXERCICIO: .Use TryParse para converter '250'.
*/
using System;
class TryParseConverter {
    
  static void Main() {
      
     string salarioBase = "250";
     int salarioReal = 0;
     
     if(int.TryParse(salarioBase, out salarioReal)){
         Console.WriteLine($"Deu certo seu salario real é {salarioReal}");
     }
      
  }
  
}