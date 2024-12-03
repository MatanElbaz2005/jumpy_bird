using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    public void AddScore()
    {
        playerScore += 1;

    }
}
