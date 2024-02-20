using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollectedCoins : MonoBehaviour
{
    public TextMeshPro text;
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;
    public GameObject coin4;
    public GameObject coin5;
    public int coinAmount = 0;
    public bool BabyMushGrabbed = false;
    public bool AddedFiveCoin = false;

    public GameObject gameController;

    void Start()
    {
        gameController = GameObject.Find("GameController");
        BabyMushGrabbed = gameController.GetComponent<FoundBabyMushroom>().BabyMushGrabbed;
        coin1 = GameObject.Find("Coin1");
        coin2 = GameObject.Find("Coin2");
        coin3 = GameObject.Find("Coin3");
        coin4 = GameObject.Find("Coin4");
        coin5 = GameObject.Find("Coin5");
    }

    // Update is called once per frame
    void Update()
    {
        BabyMushGrabbed = gameController.GetComponent<FoundBabyMushroom>().BabyMushGrabbed;

        text.text = "Coins: " + coinAmount.ToString();
        if (BabyMushGrabbed == true && AddedFiveCoin == false)
        {
            coinAmount = coinAmount + 5;
            AddedFiveCoin = true;
        }
    }

    public void GotCoin1()
    {
        coinAmount = coinAmount + 1;
        Destroy(coin1);
    }
    public void GotCoin2()
    {
        coinAmount = coinAmount + 1;
        Destroy(coin2);
    }
    public void GotCoin3()
    {
        coinAmount = coinAmount + 1;
        Destroy(coin3);
    }
    public void GotCoin4()
    {
        coinAmount = coinAmount + 1;
        Destroy(coin4);
    }
    public void GotCoin5()
    {
        coinAmount = coinAmount + 1;
        Destroy(coin5);
    }
}
