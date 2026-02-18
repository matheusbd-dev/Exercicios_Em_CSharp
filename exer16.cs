/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    CURSO: ESW 5°
    DATA: 17/02/2026
    EXERCICIO: Exiba um texto em maiúsculo e minúsculo
*/
using System;
class Letras {
    
  static void Main() {
      
      string frase = "eStOu AdOrAnDo A mAtErIa dE LaBoRaToRiO De dEsEnVoLvImEnto";
      
      //Texto Maiúsculo
      Console.WriteLine(frase.ToUpper());
      
      //Texto Minúsculo
      Console.WriteLine(frase.ToLower());
      
  }
  
}