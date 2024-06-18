using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coinRefrence;
    public Transform player;
    public int numberOfCoins = 10;

    int currentPosition = 0;
    public int offsetX = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        coinsCreating();
    }

    void coinsCreating()
    {
        for(int i = 0; i < numberOfCoins; i++)
        {
            currentPosition += offsetX;
            int offsetY = 0;
            if(currentPosition%4 == 0)
            {
                offsetY = offsetX;
            }
            Instantiate(coinRefrence, new Vector3(player.position.x + currentPosition, player.position.y, player.position.z), Quaternion.identity);
        }
    }
}
