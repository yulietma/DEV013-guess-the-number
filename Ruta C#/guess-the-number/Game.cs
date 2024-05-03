using System;

public class Game
{
    private int numeroSecreto;
    public Game()
    {
        Random rnd =new Random();
        numeroSecreto=rnd.Next(1,101);
    }
    public void IniciarJuego()
    {
        Console.WriteLine("Bienvenido a Guess the Number!!");
        Console.WriteLine("Intenta adivinar el numero entre 1 y 100");
        
        int intento;
        do 
        {
            Console.Write("Ingresa tu intento: ");
            intento=Convert.ToInt32(Console.ReadLine());
            if (intento== numeroSecreto)
            {
                Console.WriteLine("Adivinaste!!! felicidades");
                return;
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine("El numero secreto es mayor");
            }
            else 
            {
                Console.WriteLine("El numero secreto es menor");
            }
        } while (true);
    }
}