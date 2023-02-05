using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;
using System.Collections;

public class UIAnimations : MonoBehaviour
{
    public List<RectTransform> rectCards = new List<RectTransform>();
    public List<RectTransform> removeCards = new List<RectTransform>();
    public List<RectTransform> discardCards = new List<RectTransform>();

    public RectTransform panel, victoryPanel, defeatPanel, cardsPanel;
    public CanvasGroup cards;

    private int hearts = 3;

    private void Start()
    {
        foreach (var card in rectCards)
        {
            card.transform.localPosition = new Vector3(0f, 1000f, 0f);
        }

        panel.transform.localPosition = new Vector3(579f, -1000f, 0f);
        victoryPanel.transform.localPosition = new Vector3(0f, -1200f, 0f);
        defeatPanel.transform.localPosition = new Vector3(0f, -1200f, 0f);
    }

    public void Play()
    {
        CardsAnimation();
        Panel();
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

    public void Remove()
    {
        hearts--;

        if (hearts > 0)
        {
            StartCoroutine("Shake");
        }

        if (hearts <= 0)
        {
            StartCoroutine("Defeat");
        }
    }

    private void Panel()
    {
        panel.DOAnchorPos(new Vector2(579f, -178f), .5f, false).SetEase(Ease.InOutSine);
    }

    public void Restart()
    {
        hearts = 3;
        foreach (var item in discardCards)
        {
            removeCards.Add(item);
        }
        discardCards.Clear();
        rectCards[13].DOScale(new Vector3(1f, 1f, 1f), 0f);
        panel.transform.localPosition = new Vector3(579f, -1000f, 0f);
        CardsAnimation();
        Panel();
        defeatPanel.DOAnchorPos(new Vector2(0f, -1200f), .5f, false).SetEase(Ease.InOutSine);
    }

    IEnumerator Shake()
    {
        for (int i = 0; i < 3; i++)
        {
            int indexNumber = Random.Range(0, removeCards.Count);
            removeCards[indexNumber].DOShakePosition(.1f, 20f);
            yield return new WaitForSeconds(.1f);
            removeCards[indexNumber].DOAnchorPos(new Vector2(0f, -1000f), .5f, false).SetEase(Ease.InOutSine);
            discardCards.Add(removeCards[indexNumber]);
            removeCards.RemoveAt(indexNumber);
        }
        yield return null;
    }

    IEnumerator Defeat()
    {
        for (int i = 0; i < removeCards.Count; i++)
        {
            removeCards[i].DOShakePosition(.1f, 20f);
            yield return new WaitForSeconds(.1f);
            removeCards[i].DOAnchorPos(new Vector2(0f, -1000f), .5f, false).SetEase(Ease.InOutSine);
        }

        yield return new WaitForSeconds(.5f);

        rectCards[13].DOShakePosition(.5f, 10f);
        yield return new WaitForSeconds(.5f);
        rectCards[13].DORotate(new Vector3(0f, 0f, 360f), .5f, RotateMode.FastBeyond360).SetLoops(5,LoopType.Restart).SetEase(Ease.Linear);
        rectCards[13].DOScale(new Vector3(0f, 0f, 0f), 2f).OnComplete(() =>
        {
            defeatPanel.DOAnchorPos(new Vector2(0f, 0f), .5f, false).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                cards.alpha = 0;
                foreach (var card in rectCards)
                {
                    card.transform.localPosition = new Vector3(0f, 1000f, 0f);
                }
            });
        });
    }
}
