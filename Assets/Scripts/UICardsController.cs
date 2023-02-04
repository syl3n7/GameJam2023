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
    
    #region Card4
    public void Card4Front()
    {
        cards[6].SetActive(true);
        cards[7].SetActive(false);
    }
    public void Card4Back()
    {
        cards[6].SetActive(false);
        cards[7].SetActive(true);
    }
    #endregion

    #region Card5
    public void Card5Front()
    {
        cards[8].SetActive(true);
        cards[9].SetActive(false);
    }
    public void Card5Back()
    {
        cards[8].SetActive(false);
        cards[9].SetActive(true);
    }
    #endregion

    #region Card6
    public void Card6Front()
    {
        cards[10].SetActive(true);
        cards[11].SetActive(false);
    }
    public void Card6Back()
    {
        cards[10].SetActive(false);
        cards[11].SetActive(true);
    }
    #endregion

    #region Card7
    public void Card7Front()
    {
        cards[12].SetActive(true);
        cards[13].SetActive(false);
    }
    public void Card7Back()
    {
        cards[12].SetActive(false);
        cards[13].SetActive(true);
    }
    #endregion

    #region Card8
    public void Card8Front()
    {
        cards[14].SetActive(true);
        cards[15].SetActive(false);
    }
    public void Card8Back()
    {
        cards[14].SetActive(false);
        cards[15].SetActive(true);
    }
    #endregion

    #region Card9
    public void Card9Front()
    {
        cards[16].SetActive(true);
        cards[17].SetActive(false);
    }
    public void Card9Back()
    {
        cards[16].SetActive(false);
        cards[17].SetActive(true);
    }
    #endregion

    #region Card10
    public void Card10Front()
    {
        cards[18].SetActive(true);
        cards[19].SetActive(false);
    }
    public void Card10Back()
    {
        cards[18].SetActive(false);
        cards[19].SetActive(true);
    }
    #endregion

    #region Card11
    public void Card11Front()
    {
        cards[20].SetActive(true);
        cards[21].SetActive(false);
    }
    public void Card11Back()
    {
        cards[20].SetActive(false);
        cards[21].SetActive(true);
    }
    #endregion

    #region Card12
    public void Card12Front()
    {
        cards[22].SetActive(true);
        cards[23].SetActive(false);
    }
    public void Card12Back()
    {
        cards[22].SetActive(false);
        cards[23].SetActive(true);
    }
    #endregion

    #region Card13
    public void Card13Front()
    {
        cards[24].SetActive(true);
        cards[25].SetActive(false);
    }
    public void Card13Back()
    {
        cards[24].SetActive(false);
        cards[25].SetActive(true);
    }
    #endregion

    #region Card14
    public void Card14Front()
    {
        cards[26].SetActive(true);
        cards[27].SetActive(false);
    }
    public void Card14Back()
    {
        cards[26].SetActive(false);
        cards[27].SetActive(true);
    }
    #endregion

    #region Card15
    public void Card15Front()
    {
        cards[28].SetActive(true);
        cards[29].SetActive(false);
    }
    public void Card15Back()
    {
        cards[28].SetActive(false);
        cards[29].SetActive(true);
    }
    #endregion
}
