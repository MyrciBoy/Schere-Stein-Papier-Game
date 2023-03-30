using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    [SerializeField] private Image computer, player;
    public Text score;
    public int runde;
    public Text Win;

    /*bei BTM Press: Schere Stein Papier spielen:
     * P Random Schere Stein Papier wählen -> Rot ist Schere, Blau ist Stein, Grün ist Papier
     * C Random Schere Stein Papier wählen
     * Auswerten wer gewonnen hat
     * Msg hinschreiben wer gewonnen hat
    */
    public int playerscore;
    public int computerscore;
    public void PlayGame()


    {
        Debug.Log("Gedrückt");
        //Rot ist Schere (0), Blau ist Stein (1), Grün ist Papier (2)
        computer.GetComponent<Image>().color = Color.red;
        player.GetComponent<Image>().color = Color.blue;


        int rnd = Random.Range(0, 3);
        if (rnd == 0)
        {
            computer.color = Color.red;
        }
        if (rnd == 1)
        {
            computer.color = Color.blue;
        }
        if (rnd == 2)
        {
            computer.color = Color.green;
        }

        int rndp = Random.Range(0, 3);
        if (rndp == 0)
        {
            player.color = Color.red;
        }
        if (rndp == 1)
        {
            player.color = Color.blue;
        }
        if (rndp == 2)
        {
            player.color = Color.green;
        }

        if (player.color == Color.red && computer.color == Color.green)
        {
            playerscore++;
        }
        if (player.color == Color.green && computer.color == Color.blue)
        {
            playerscore++;
        }
        if (player.color == Color.blue && computer.color == Color.red)
        {
            playerscore++;
        }
        if (computer.color == Color.red && player.color == Color.green)
        {
            computerscore++;
        }
        if (computer.color == Color.green && player.color == Color.blue)
        {
            computerscore++;
        }
        if (computer.color == Color.blue && player.color == Color.red)
        {
            computerscore++;
        }
        runde++;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (runde >= 5)
        {
            if (playerscore > computerscore)
            {
                Win.text = "player gewinnt";
            }
            if (playerscore < computerscore)
            {
                Win.text = "computer gewinnt";
            }
            if (playerscore == computerscore)
            {
                Win.text = "unentschieden";
            }




            runde = 0;
            playerscore = 0;
            computerscore = 0;
        }
    }
}