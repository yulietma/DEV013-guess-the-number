//defien la clase
public class Palyer
{
    public string Name {get; private set;}// Propiedad para gsuardar el nombre del usuruario 
    public int ultimoIntento { get; private set;}// Porpiedad para almacenar el ultimo intento
    public Palyer(string name)
    {
        Name = name;
        ultimoIntento = 0;
    }
    
    public void MakeGuess() //Metodo que se encarga de hacer la prediccion
    {
        Console.Write($"{Name} Ingresa tu Intento:");
        ultimoIntento = Convert.ToInt32(Console.ReadLine());// solicita por terminal que el numero se valide y sea correcto 
    }
}

