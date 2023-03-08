using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehavior : MonoBehaviour
{
    //the panel objects themselves
    [SerializeField] private GameObject[] gamePanels;

    //both player hands
    private List<int> playerOne = new List<int>();
    private List<int> playerTwo = new List<int>();
    //instances of the classes
    private Dealer dealer = new Dealer();
    private Player player = new Player();
    private CardDeck cardDeck = new CardDeck();

    //other variables to help control program flow
    bool playersTurn = true;
    private int playerOneScore = 0;
    private int playerTwoScore = 0;


    //has a deck
    private void DealStartingCards()
    {
        //draw 2 cards for each player
        //cardDeck.Parser(deck[DrawRandomCard()])
    }

    private void TakeTurn(ActionChoice choice)
    {
        if(playersTurn)
        {
            switch (choice)
            {
                case ActionChoice.hit:
                    //take a new card and add it to the player hand, then 
                    break;
                case ActionChoice.hold:
                    //allow dealer to continue playing until hes done, then check win condition
                    break;
            }
        }
    }

    private void CheckWinner()
    {
        //check for the winner, and for any specific win conditions
    }

    private void DisplayValues()
    {
        //display the current cards the player has, and how many the dealer has

        //player needs to display full hand, while the dealer must only display the second and consecutive cards
    }

    private void DisplayEndCondition()
    {

    }    

    

    #region start n update
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region Buttons

    public void StartButton()
    {
        //turn off the start panel
    }
    public void InstructionsButton()
    {
        //displays the instructions panel
    }

    public void ReturnButton()
    {
        //hides the instructions panel
    }

    public void QuitButton()
    {
        //kills the application
        Application.Quit();
    }

    public void RestartButton()
    {
        //reload the scene
    }

    public void HitButton()
    {
        TakeTurn(ActionChoice.hit);
    }

    public void HoldButton()
    {
        TakeTurn(ActionChoice.hold);
    }
    #endregion

}
public enum ActionChoice
{
    hit,
    hold
}
