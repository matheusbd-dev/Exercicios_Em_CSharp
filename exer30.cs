/** NOME: Matheus Bezerra Domingos
    CURSO: ESW 5°
    RA: 166479-2024
    DATA: 18/02/2026
    OBJETIVO: Declare string '500.75', converta para double e depois para int usando casting. em C#
*/
using System;
class Ultimo {
  static void Main() {
    
    string strValor = "500.75";
    
    double doubleValor = double.Parse(strValor);
    
    Console.WriteLine(doubleValor);
    
    int intValor = (int) doubleValor;
    
    Console.WriteLine(intValor);
    
  }
}