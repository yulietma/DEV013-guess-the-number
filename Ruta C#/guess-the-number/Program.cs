
using System;
//Defincion de la clase progra
        Console.Write("Ingresa tu nombre: ");
        string? name = Console.ReadLine();// el ? e ayuda meter

        if (string.IsNullOrEmpty(name)){//Si el nombre es nulo o vacío
           Console.WriteLine("Escribe correctamente un nombre");
        }else{
          Game Game= new Game(name);//crea una instancia de la clase Game
          Game.start_game(); 
          Game.winnerGame(); 
        }
      