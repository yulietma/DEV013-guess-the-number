
using System;
//Defincion de la clase program
class Program
{
    static void Main(string[] args) //Metodo principal del programa
    {
        Console.Write("Ingresa tu nombre: ");
          string? playerName = Console.ReadLine();

          playerName ??="Invitado";//// Verifica si playerName es nulo y, si lo es, asigna un valor predeterminado

        //se crea una INSTANCIA de la clss Game
       Game game = new Game(playerName);
        game.IniciarJuego();//se llama el metodo IniciarJuego que esta dentro de la instancia de la clase game 
    }
}
