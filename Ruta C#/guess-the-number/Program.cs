
using System;//Esta línea importa el espacio de nombres System, que contiene clases fundamentales como Console.
//Defincion de la clase prograc
class Program//Define una clase llamada Program una clase es una estructura que puede contener métodos, propiedades y otros miembros.
{
  static void Main()//el método Main, que es el punto de entrada de una aplicación de consola , modificador static significa que el método pertenece a la clase Program, void indica que el método no devuelve ningún valor.
  {
    Console.Write("Ingresa tu nombre: ");
    string? name = Console.ReadLine();// el ? e ayuda meter el nombre del usuario sin errores

    if (string.IsNullOrEmpty(name))//comprueba si la variable name es null o está vacía usando el método IsNullOrEmpty de la clase string.
    {//Si el nombre es nulo o vacío (nulo es que no es string)
      Console.WriteLine("Escribe correctamente un nombre");
    }
    else// Si name no es null ni está vacía, ejecuta el bloque de código dentro del else
    {
      Game Game = new Game(name);//crea una instancia de la clase Game pasando name como parámetro al constructor. 
      Game.startGame();//Llama al método startGame de la instancia Game.
      Game.winner();//Llama al método winner de la instancia Game.
    }
  }
}