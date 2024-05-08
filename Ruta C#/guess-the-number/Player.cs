//defien la clase
public class Player
{
    public string Name {get; private set;}// Propiedad para gsuardar el nombre del usuruario 
    private int ultimoIntento;// Porpiedad para almacenar el ultimo intento
    public Player(string name)
    {
        Name = name;
        ultimoIntento = 0;
    }
    public int getLastGuess(){
        return ultimoIntento;
    }
    public void MakeGuess() //Metodo que se encarga de hacer la prediccion
    {
        bool isValid=true;
        while(isValid){
            Console.Write($"{Name} Ingresa tu Intento: ");
            string? input=Console.ReadLine();
            if(int.TryParse(input, out int guess)){
                ultimoIntento=guess;
                isValid=false;
            }
            else{

            Console.WriteLine("Por favor ingresa un NUMERO valido");
            }
        }
        
    }
}

