/** NOME: Matheus Bezerra Domingos
    RA: 166479-2024
    CURSO: ESW 5°
    DATA: 17/02/2026
    EXERCICIO: Use TryParse para tentar converter 'abc' e trate o resultado.
*/
using System;
class ABC {
    
  static void Main() {
      
     string texto = "abc";
     int textoReal = 0;
     
     if(!int.TryParse(texto, out textoReal)){
         Console.WriteLine($"Deu erro entrada inválido {textoReal}");
         return;
     }else{
         Console.WriteLine($"Deu Certo {textoReal} ");
     }
      
  }
  
}