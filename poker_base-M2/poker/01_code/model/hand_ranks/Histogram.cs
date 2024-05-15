namespace poker.code.model.hand_ranks;

public class Histogram
{
    //---------------------------------------------------------------------------------
    // Variáveis de instância / estados
    //---------------------------------------------------------------------------------
	List<Card> to_organaize; // COPY cards to evaluate
	// lista da lista de cartas, 
	List<List<Card>> histo_;

    //---------------------------------------------------------------------------------
    //Comportamentos
    //---------------------------------------------------------------------------------
	public Histogram(List<Card> c_list) // Construtor / criação de objetos
	{
	    to_organaize = new List<Card>();
		foreach (var c in c_list)
		    to_organaize.Add(new Card(c));  // Faz uma cópia

		histo_ = new List<List<Card>>(); // Cria uma lista vazia (lista de listas)

		for (int i = 0 ; i < 15 ; i++)				
		    histo_.Add(new List<Card>()); // Cria uma lista vazia (uma lista de cartas)
        count_values(); // Cria o histograma
    }
    
	/*
	// Método privado para criar o histograma
	*/
	private void count_values()
	{
		for (int i = 0 ; i < to_organaize.Count; i++ ) // Itera sobre os elementos da lista 'to_organaize'.
	    {
		    // Obtém o valor da carta (número)
			int value = to_organaize[i].get_value();
			// Adiciona a carta à lista correspondente no histograma
			histo_[value].Add(new Card(to_organaize[i]));
		}
	}
    
	// Método público para acessar o histograma
	public List<List<Card>> get_histogram()
	{return histo_;} // acessa o histogram
    
	// Método estático para ordenar uma lista de cartas
	public static List<Card> sort(List<Card>ordenar)
	{
		int loop = ordenar.Count -1;
        List<Card> ordenada = new List<Card>();
        
        foreach (var c in ordenar)
			ordenada.Add(new Card(c));
    	for (int i = 0 ; i < loop ; i++)
		{
		    bool swapped = false;
			//Console.WriteLine("For1");

			for(int j = 0 ; j < loop ; j++)
			{
				if (ordenada[j].get_value() > ordenada[j+1].get_value())
				{
					swap(j, ordenada); // Realiza a troca
					swapped = true;
				}
				//Console.WriteLine("For2");
			}

			if (!swapped)
				break;				
		}
		return ordenada;
	}

	// Método privado para suportar o método de ordenação
	private static void swap(int index, List<Card> cards)
	{	
		int i = index;
		int j = index +1;

		Card temp = new Card (cards[i]);
		cards[i] = new Card (cards[j]);
		cards[j] = new Card (temp);
	}

}
