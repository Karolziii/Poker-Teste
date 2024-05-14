namespace poker.code.model;

//Declaração de uma classe chamada Player que herda da classe Person.
public class Player : Person
{
    // Campo privado específico da classe
    private int playerNumber; // Declaração de um campo privado do tipo int chamado playerNumber, que armazena o número do jogador.

    // Construtor
    public Player(string name, int age, int playerNumber) // Declaração de um construtor para a classe Player que recebe três argumentos, string 'name', um inteiro 'age' e um inteiro 'playerNumber'.
        : base(name, age)
    {
        this.playerNumber = playerNumber;
    }
}
