public class Game
{//declracion de la clase game
  public int secretNumber { get; set; }//Propiedad publica representa el numero secreto que se debe adivinar
  private Random _random = new Random();//delcaro un objeto random para generar numerso aleatorios
  private Player _HumanPlayer { get; set; }//Propiedad privada que representa al jugador Humano 
  private Player _AIPlayer { get; set; }//propiedad privada que representa a la IA


  private int RandomNumberGenerator()
  {//metodo privado que genera un numero aleatorio entre 1 y 100
    return _random.Next(1, 100);
  }
  public Game(string nameplayer)  {//constructor de la clase Game que recibe el nombre del juegador como parametro
    secretNumber = RandomNumberGenerator();//genera numero aleatorio al iniciar el juego 
    _HumanPlayer = new HumanPlayer(nameplayer);//Inicializa el juego Humano con el nombre porporcionado 
    _AIPlayer = new AIPlayer("IA");//Inicializa el juego con un nombre predeterminado ("IA)
  }
  public bool CheckGuess(int guess, int targetNumber)
  {//metodo que verifica si el numero ingresado es igual a numero objetivo
    if (guess == targetNumber)
    {
      return true;//Devuelve verdadero si el numero adivinado es igual al objetivo
    }
    if (guess < targetNumber)
    {
      Console.WriteLine("El numero que ingresaste ee menor al numero por adivinar");//imprime mensaje si el numero es menor al que se debe adivinar 
    }
    else if (guess > targetNumber)
    {
      Console.WriteLine("El numero que ingresaste es mayor al numero por adivinar");
    }
    return false;//devuelve falso si el numero adivinado no es igual al objetivo 
  }

  public void startGame()
  {//metodo para iniciar el juego
    int Intento = 1;
    bool fin = false;
    bool semaforo = true;
    Console.WriteLine("Binevenida"   +  _HumanPlayer.nameGame +    "adivina el numero que pienso entre el 1 y el 100 ");
    // todo lo de arriba imprime mesnaje de bienvenida on el nombre del usuruario 
    while (!fin)
    {//empieza el bucle para continuar el juego hasta que finalice 
      if (semaforo)
      {
        //condicion para alternar entre el usuario y la IA
        _HumanPlayer.MakeGuess();//LLamamos el metodo MakeGuess del jugador humano para hacer conjetura
        if (CheckGuess(_HumanPlayer.getLastGuess(), secretNumber))
        {
          fin = true;//Finaliza el juego si el jugador adivina el numero secreto
        }
        semaforo = false;//Cambia el turno para alternar al sig jugador
      }
      else
      {//secion para IA
        _AIPlayer.MakeGuess();//Llamamos el metodo MakeGuess de la IA para hacer conjenttura
        if (CheckGuess(_AIPlayer.getLastGuess(), secretNumber))
        {
          fin = true;//Finaliza el juego si la IA adivia el numero secreto
        }
        semaforo = true;//Cambia el turno para laternar al sig. jugador
      }
      Intento++;
      //incrementa el contador de los itentos
    }
  }

  public void winner(){//metodo para imprimir mensaje si el ganador es humanplayer o IA
    if (CheckGuess(_HumanPlayer.getLastGuess(), secretNumber)){
      Console.WriteLine("Felicidades has ganado");//Para el jugador humano
      } else if (CheckGuess(_AIPlayer.getLastGuess(),secretNumber)){
        Console.WriteLine("Felicidades IA has gando ");//mensaje para la IA si gana
      }
    }
  }
