namespace poker.code.model.hand_ranks;
/*
* Base class, of all Hand Ranks classes.
*/
public abstract class Ranks
{
    //---------------------------------------------------------------------------------
    //states
    //---------------------------------------------------------------------------------
    protected List<List<Card>> ranks_histo; // histogram
    protected List<Card> find; // gurada rank encontrado

    //---------------------------------------------------------------------------------
    //behaviors
    //---------------------------------------------------------------------------------    
    public Ranks(List<List<Card>> l) // constructor
    {
        ranks_histo = l;
        find = new List<Card>();
    }

    public List<Card> get_find() // get find list
    {
        return find;
    }
    
    //verifica se na lista passada existe uma Card com owner == 1
    protected bool check_woner(List<Card> l)
    {
        foreach (var c in l)
        {
            if (c.owner == 1)
                return true;
        }
        return false;
    }

    //Percorre a lista de listas e retorna uma lista
    //com as duas cartas da pessoa
    protected List<Card> copy_woner()
    {
        List<Card> list = new List<Card>();

        foreach (var l in ranks_histo)
        {
            foreach (var c in l)
            {
                if(c.owner == 1)
                    list.Add(new Card (c));
            }
        }
        return list;
    }
        
    //Retorna uma copia (valores nao referencia) da lista
    //passada por parametro
    protected List<Card> value_copy (List<Card> l)
    {
        List<Card> list_copy = new List<Card>();
    
        foreach (var c in l)
        {
            list_copy.Add(new Card(c));
        }
        return list_copy;
    }
        
    //metodo abstrato, toda classe que herda precisa 
    //implementar sua versao
    public abstract bool check ();
}