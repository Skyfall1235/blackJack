using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player
{
    [SerializeField]
    List<int> hand = new List<int>();

    public void CalculateHand()
    {
        //returns the point value of the hand & calculates the ace for its best possible fit
    }
    public void DrawCard()
    {
        //draws a card from the deck and stores it in the hand
        //potentially do the following here
        //should run calculate hand?
    }


}

