using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public abstract class Player {
public string nameGame {get; private set;}
private List<int> guesses {get; set;}
private List<int> AIGuesses {get; set;}
protected  Player(string nombre){
nameGame = nombre;
guesses = new List<int>();
AIGuesses = new List<int>();
}
public int getLastGuess(){
    int lastnumber= guesses.LastOrDefault();
    return lastnumber;
}
public void AddListGuess(int prediction){
    guesses.Add(prediction);
}
public int getLastAIGuess(){
    return AIGuesses.LastOrDefault();
}
public void AddListAiGuess( int prediction){
    AIGuesses.Add(prediction);
}
public abstract void MakeGuess();
}