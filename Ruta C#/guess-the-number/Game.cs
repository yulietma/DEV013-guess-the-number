using System;
//defincion de la clase game
public class Game
{
    private int numeroSecreto; //se crea una variable para almacenar el numero secreto esta variable es numero (int)
//Constructor de la clase game que inicializa el numero secreto
    private Palyer player; //Propiedad para almacenar una instancia Player
    
    // Constructor que inicializa su numero aleatorio y crea un nuevo objeto de tipo player
    public Game (string playerName)
    {    
        Random rnd =new Random();//creacion de una instancia d ela clase Random para generar un numero a lazar 
        numeroSecreto=rnd.Next(1,101);//genra el numero alzar entre 1 y 100 y s elo asignamos a numeroSecreto
        player = new Palyer(playerName);
    
    }

    // metodo que inicia el juego 
    public void IniciarJuego()
    {  //Console.WriteLine me ayuda a mostara lineas de texto en la terminal
        Console.WriteLine("Bienvenid@, {Name} a Guess the Number!!");
        Console.WriteLine("Intenta adivinar el numero entre 1 y 100");
    
        do // empezamos el bucle de do-while que solicita al usuario adivinar el numero
        {
            player.MakeGuess();
            if (player.ultimoIntento== numeroSecreto)// si el numero secreto es igual a intento (usuario)
            {
                Console.WriteLine("Adivinaste!!! felicidades, {Name}");
                break;
            }
            //si no comprueba si el intento del usuaurio es menor que el numeroSecreto
            else if (player.ultimoIntento < numeroSecreto)
            {
                Console.WriteLine("El numero secreto es mayor");//imprime que es mayor el numero a adivinar
            }
            else // si no, imprime que es menor el numeroSecreto
            {
                Console.WriteLine("El numero secreto es menor");
            }
        } while (true); // el bucle se repite hasta que se adivian el numero a lazar
    }
}