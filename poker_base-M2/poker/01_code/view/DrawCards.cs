using System;
using System.Collections.Generic;
using poker.code.model;

namespace poker.code.view
{
	/*
	Desenha as bordas das cartas
	*/
	class DrawCards
	{
		/*
		DrawCards cards outlines (edges)
		*/
		private static void DrawCardOutline(int xcoor, int ycoor)
		{
			Console.ForegroundColor = ConsoleColor.White;
			
			int x = xcoor * 12;
			int y = ycoor;
			
			Console.SetCursorPosition(x, y);
			Console.Write(" __________\n"); // Borda superior da carta
			
			for (int i = 0; i < 7; i++)
			{
				Console.SetCursorPosition(x,y + 1 + i);
				
				if ( i != 6)
					Console.WriteLine("|          |");// Bordas esquerda e direita da carta
				else
					Console.WriteLine("|__________|");// Borda inferior da carta
			}
		}
		
		/*
		// Exibe o naipe e o valor da carta dentro de seu contorno
		*/		
		public static void DrawCardSuitValue(Card card, int xcoor, int ycoor)
		{
			//char cardSuit = ' ';
			string cardSuit = "";
			int x = xcoor * 12;
			int y = ycoor;

			//hearts and diamonds are red, clubs and spades are black
			switch(parse_suite(card.suit_.ToString()))
			{
				case 1://Card.SUIT.Hearts:
					cardSuit = "\u2665"; //'♥'
					//cardSuit = 'H';
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case 2://Card.SUIT.Diamonds:
					cardSuit = "\u25C6"; //'♦';
					//cardSuit = 'D';
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case 3://Card.SUIT.Clubs:
					cardSuit = "\u2663";//'♣';
					//cardSuit = 'D';
					Console.ForegroundColor = ConsoleColor.White;
					break;
				case 4://Card.SUIT.Spades:
					cardSuit = "\u2660";//'♠';
					//cardSuit = 'S';
					Console.ForegroundColor = ConsoleColor.White;
					break;
			}

			//exibe o caractere codificado e o valor do cartão
			Console.SetCursorPosition(x + 3, y + 2);
			string simbol_ = "";
			
			if(parse_value(card, ref simbol_))
				Console.Write(simbol_);
			else
				Console.WriteLine(card.get_value());
			
			Console.SetCursorPosition(x + 3, y + 3);
			Console.Write(cardSuit);			
		}

		private static int parse_suite(string suite)
		{// converte o naipe para um valor numérico
			if (suite == "Hearts")
				return 1;
			else if (suite == "Diamonds")
				return 2;
			else if (suite == "Clubs")
				return 3;
			else if (suite == "Spades")
				return 4;
			return 0;
		}

		private static bool parse_value(Card c, ref string simbol)
		{ // parse especial values: J(11) | Q(12) | K(13) | A(1 ou 14)
			bool check = false;
			if (c.get_value() >= 11 && c.get_value() <= 14)
			{
				check = true;
				switch(c.get_value())
				{
					case 11:
						simbol = "J";
						break;
					case 12:
						simbol = "Q";
						break;
					case 13: 
						simbol = "K";
						break;
					case 14: 
						simbol = "A";
						break;
				}
			}
			//else if (c.get_value() == 14)
			//{
			//	simbol = "A";
		//		check = true;
		//	}

			return check;
		}

		public static void display_cards (List<Card> list, int x_, int y_)
		{
			//Console.Clear();
			int x = x_;//0; //x position of the cursor
			int y = y_;//1; //y position of the cursor
			//UnicodeEncoding enc = new UnicodeEncoding(true, false, false);
			Console.OutputEncoding = System.Text.Encoding.UTF8; 
			
			// Exibe a mão do jogador
			Console.ForegroundColor = ConsoleColor.White;

			int numCardsToDisplay = Math.Min(list.Count, 7);


   			 // Loop através das cartas na lista e exibe as sete primeiras cartas
			for (int i = 0; i < numCardsToDisplay; i++)
			{
				// Verifica se a posição y ultrapassa os limites do console
				if (y + 8 >= Console.WindowHeight)
				{
					Console.WriteLine("Erro: Não é possível exibir todas as cartas. A altura do console é muito pequena.");
					return;
				}

				if (i < list.Count) // Verifica se ainda há cartas para exibir
				{
				
					// Desenha a borda da carta
					DrawCards.DrawCardOutline(x, y);
					
					// Desenha o símbolo e o valor da carta
					DrawCards.DrawCardSuitValue(list[i], x, y);

				}
				
				// Move para a próxima posição à direita
				x++; 

				if (x >= Console.WindowWidth / 12)  // Se atingir a última coluna do console, move para a próxima linha e reinicia a contagem da coluna
				{
					x = 0;
					y += 8; // Incrementa a posição y para a próxima linha
				}
			}
		}
	}
}
