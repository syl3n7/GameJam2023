using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class UICardsController : MonoBehaviour
{
    public GameObject[] cards;

    private void Start()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i].SetActive(false);
            i++;
        }
    }

    #region Card1
    public void Card1Front()
    {
        cards[0].SetActive(true);
        cards[1].SetActive(false);
    }
    public void Card1Back()
    {
        cards[0].SetActive(false);
        cards[1].SetActive(true);
    }
    #endregion

    #region Card2
    public void Card2Front()
    {
        cards[2].SetActive(true);
        cards[3].SetActive(false);
    }
    public void Card2Back()
    {
        cards[2].SetActive(false);
        cards[3].SetActive(true);
    }
    #endregion

    #region Card3
    public void Card3Front()
    {
        cards[4].SetActive(true);
        cards[5].SetActive(false);
    }
    public void Card3Back()
    {
        cards[4].SetActive(false);
        cards[5].SetActive(true);
    }
    #endregion
}
