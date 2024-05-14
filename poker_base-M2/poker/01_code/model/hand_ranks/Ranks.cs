namespace poker.code.model.hand_ranks;
/*
* Classe base para Hand Ranks classes.
*/
public abstract class Ranks
{
    //---------------------------------------------------------------------------------
    //Estados
    //---------------------------------------------------------------------------------
    protected List<List<Card>> ranks_histo; // histogram
    protected List<Card> find; // declara um campo protegido na classe 'find', que é uma lista de objetos do tipo 'Card'.

    //---------------------------------------------------------------------------------
    //Comportamentos
    //---------------------------------------------------------------------------------    
    public Ranks(List<List<Card>> l) // Construtor público para a classe Ranks, que recebe uma lista de listas de cartas (l) como parâmetro.
    {
        ranks_histo = l; // Atribui a lista de listas de cartas 'l' ao campo 'ranks_histo' 
        find = new List<Card>(); // Inicializa a lista 'find' com uma nova instância de 'List<Card>()', criando uma lista vazia.


    }

    public List<Card> get_find() // método público chamado get_find(), que retorna a lista find de objetos do tipo 'Card'.
    {
        return find;
    }
    
    //verifica se na lista passada existe uma Card com owner == 1
    protected bool check_woner(List<Card> l)
    {
        foreach (var c in l) // Itera sobre cada carta c na lista l.
        {
            if (c.owner == 1) // Verifica se o proprietário da carta c é igual a 1.
                return true;
        }
        return false;
    }

    //Percorre a lista de listas e retorna uma lista
    //com as duas cartas da pessoa
    protected List<Card> copy_woner()
    {
        List<Card> list = new List<Card>(); //Declaração e inicialização de uma nova lista de cartas chamada 'list'.

        foreach (var l in ranks_histo)
        {
            foreach (var c in l) //  Verifica se o proprietário da carta c é igual a 1.
            {
                if(c.owner == 1)
                    list.Add(new Card (c)); // Se o proprietário da carta for igual a 1, cria uma nova instância de 'Card' com base na carta 'c' e a adiciona à lista 'list'.
            }
        }
        return list;
    }
        
    //Retorna uma cópia (valores nao referência) da lista
    //passada por parâmetro
    protected List<Card> value_copy (List<Card> l) // Recebe uma lista de cartas l como parâmetro e retorna uma lista de cartas.
    {
        //// Inicializa uma nova lista de cartas chamada list_copy.
        List<Card> list_copy = new List<Card>();

        //// Loop que itera sobre cada carta c na lista l.
        foreach (var c in l)
        {
            // Adiciona uma nova instância de Card, que é uma cópia da carta c, à lista list_copy.
            list_copy.Add(new Card(c));
        }
        return list_copy;
    }
        
    //método abstrato, toda classe que herda precisa 
    //implementar sua versão
    public abstract bool check ();
}
