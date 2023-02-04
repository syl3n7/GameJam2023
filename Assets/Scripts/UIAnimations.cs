using UnityEngine;
using DG.Tweening;

public class UIAnimations : MonoBehaviour
{
    public RectTransform[] rectCards;
    public GameObject[] removeCard;

    private void Start()
    {
        foreach (var card in rectCards)
        {
            card.transform.localPosition = new Vector3(0f, 1000f, 0f);
        }
    }

    public void Play()
    {
        CardsAnimation();
    }

    public void RandomRemove()
    {
        Remove();
    }

    private void CardsAnimation()
    {
        rectCards[0].DOAnchorPos(new Vector2(-731f, 330.53f), .5f, false).SetEase(Ease.InOutSine);
        rectCards[1].DOAnchorPos(new Vector2(-586f, 337f), .5f, false).SetEase(Ease.InOutSine);
        rectCards[2].DOAnchorPos(new Vector2(-56f, 337f), .5f, false).SetEase(Ease.InOutSine);
        rectCards[3].DOAnchorPos(new Vector2(57f, 337f), .5f, false).SetEase(Ease.InOutSine).OnComplete(() =>
        {
            rectCards[4].DOAnchorPos(new Vector2(-819f, 142f), .5f, false).SetEase(Ease.InOutSine);
            rectCards[5].DOAnchorPos(new Vector2(-661f, 157f), .5f, false).SetEase(Ease.InOutSine);
            rectCards[6].DOAnchorPos(new Vector2(-519, 150f), .5f, false).SetEase(Ease.InOutSine);
            rectCards[7].DOAnchorPos(new Vector2(-283f, 135f), .5f, false).SetEase(Ease.InOutSine);
            rectCards[8].DOAnchorPos(new Vector2(-156f, 135f), .5f, false).SetEase(Ease.InOutSine);
            rectCards[9].DOAnchorPos(new Vector2(77f, 121f), .5f, false).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                rectCards[10].DOAnchorPos(new Vector2(-773f, -50f), .5f, false).SetEase(Ease.InOutSine);
                rectCards[11].DOAnchorPos(new Vector2(-661f, -50f), .5f, false).SetEase(Ease.InOutSine);
                rectCards[12].DOAnchorPos(new Vector2(-339, -64f), .5f, false).SetEase(Ease.InOutSine);
                rectCards[13].DOAnchorPos(new Vector2(-170f, -64f), .5f, false).SetEase(Ease.InOutSine);
                rectCards[14].DOAnchorPos(new Vector2(-43f, -64f), .5f, false).SetEase(Ease.InOutSine);
            });
        });
    }

    private void Remove()
    {
        for(int indexNumber = Random.Range(0, rectCards.Length); indexNumber < 3;)
        {
            Debug.Log(rectCards[indexNumber].name);
        }


        /*for (var randomCardNumber = 0; randomCardNumber < 3; randomCardNumber++)
        {
            rectCards[randomCardNumber].DOAnchorPos(new Vector2(0f, -1000f), .5f, false).SetEase(Ease.InOutSine);
        }*/
    }
}
