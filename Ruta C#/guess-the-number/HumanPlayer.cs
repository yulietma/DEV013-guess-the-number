using System;
public class HumanPlayer: Player{
    public HumanPlayer(string name): base(name){}
        public override void MakeGuess()
    {
        bool isValid = true;
        while(isValid){
            Console.WriteLine("Player1-");
            Console.WriteLine("Escribe un numero");
            string? input=Console.ReadLine();
            if(int.TryParse(input, out int guess)){
                AddListGuess(guess);
                isValid=false;
                } else{
                    Console.WriteLine("Entrada Invalida por favor ingresaun numero");
                }
            }
        }
    }

