//m4rc3lo - 2024-04-23
// comentar toda a classe
namespace poker.code.model;
public class Player : Person
{
    // Campo privado específico da classe
    private int playerNumber;

    // Construtor
    public Player(string name, int age, int playerNumber)
        : base(name, age)
    {
        this.playerNumber = playerNumber;
    }
}