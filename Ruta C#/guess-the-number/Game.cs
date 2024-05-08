using System;
using System.Security.Cryptography.X509Certificates;
//defincion de la clase game
public class Game{
    public int secretNumber{get; set;}
    private Random _random= new Random();
    private Player _humanPlayer{get; set;}
    private Player _AIPlayer{get; set;}

    // Método para generar un número aleatorio entre 1 y 100
    private int RandomNumberGenerator( ){
       return _random.Next(1,100);
    }

     // Constructor de la clase Game
    public Game (string nameplayer){
       secretNumber= RandomNumberGenerator(); 
       _humanPlayer= new HumanPlayer(nameplayer);
       _AIPlayer= new AIPlayer("IA");
    }

    // Método para comprobar si el número ingresado coincide con el número secreto
     public bool CheckGuess(int guess,int targetNumber){
       if (guess==targetNumber){
            return true;
       }
       if (guess<targetNumber){
            Console.WriteLine("El número que ingresaste es menor ");
        }else if (guess>targetNumber) {
            Console.WriteLine("El número que ingresaste es mayor");
        }
      return false;
    }

     // Método para iniciar el juego
    public  void start_game(){
        int numberIntent=1;
        bool finish=false;
        bool semaforo=true;
       Console.WriteLine("Bienvenida "+_humanPlayer.nameGame+" adivina el número  pensado...entre 1 y 100");
        while (!finish){
            if (semaforo){
                _humanPlayer.MakeGuess();
                if (CheckGuess(_humanPlayer.GetLastGuess(),secretNumber)){
                  finish=true;
                }
                semaforo=false;
            }else{
                _AIPlayer.MakeGuess();
                if (CheckGuess(_AIPlayer.GetLastAIGuess(),secretNumber)){
                   finish=true;
                }
                semaforo=true;
            }
          numberIntent++;
        }
    }

    //metodo segun el resultado la linea de codigo se ejecutara
    public void winnerGame(){
        if (CheckGuess(_humanPlayer.GetLastGuess(),secretNumber)){
            Console.WriteLine("Felicidades Adivinaste el numero");
        }else if (CheckGuess(_AIPlayer.GetLastAIGuess(),secretNumber)){
            Console.WriteLine("Game Over");
            
        }
    }
}