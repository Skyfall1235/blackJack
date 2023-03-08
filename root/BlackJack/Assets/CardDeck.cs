using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck
{
    //stores the strings of the names of cards
    string[] cardValue = new string[] { "Ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king"};
    string[] suites = new string[] { "hearts", "spades", "diamonds", "clubs" };
    List<int> deck = new List<int>();
    public List<int> Deck
    {
        get { return deck; }
    }


    //deck = GenerateDeck();
    //Debug.Log(deck.Count);
    //Debug.Log(Parser(deck[DrawRandomCard()]));
    //Debug.Log(deck.Count);

    public int DrawRandomCard()
    {
        int cardChoice = Random.Range(0, deck.Count - 1);
        //Debug.Log(cardChoice);
        deck.RemoveAt(cardChoice);
        return cardChoice;
    }

    public List<int> GenerateDeck()
    {
        List<int> newDeck = new List<int>();

        for (int i = 0; i < suites.Length; i++)
        {
            for(int j = 0; j < cardValue.Length; j++)
            {
                newDeck.Add((i*100) + j);
                
            }
        }
        return newDeck;
    }
    
    public string Parser(int input)
    {
        //returns the card as a string
        int cardSuite = input / 100;
        int cardType = input % 100;
   
        string card = $"{cardValue[cardType]} of {suites[cardSuite]}";
        
        return card;
    }


}
