
using System;
//Defincion de la clase prograc
class Program
{
  static void Main()
  {
    Console.Write("Ingresa tu nombre: ");
    string? name = Console.ReadLine();// el ? e ayuda meter el nombre del usuario sin errores

    if (string.IsNullOrEmpty(name))
    {//Si el nombre es nulo o vacío (nulo es que no es string)
      Console.WriteLine("Escribe correctamente un nombre");
    }
    else
    {
      Game Game = new Game(name);//crea una instancia de la clase Game
      Game.startGame();
      Game.winner();
    }
  }
}